using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTC
{
    public partial class ReportRevuene_Form : Form
    {
        DataTable? dtRevuene;
        private ProvinceDataManager? provinceDM;
        public ReportRevuene_Form()
        {
            InitializeComponent();
            provinceDM = new ProvinceDataManager();
        }
        private void ReportRevuene_Form_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadComboBox();
            LoadProvinces();
            cbxScheduleID.Enabled = false;
        }
        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT sche.schedule_id, cen.province, cen.center_name, sche.injection_date, sche.total FROM Schedule as sche INNER JOIN Centers as cen ON sche.center_id = cen.center_id";
            dtRevuene = DataAccess.getDataToTable(sql);
            dgvRevuene.DataSource = dtRevuene;
            dgvRevuene.Columns[0].HeaderText = "Schedule ID";
            dgvRevuene.Columns[1].HeaderText = "Province";
            dgvRevuene.Columns[2].HeaderText = "VFA center";
            dgvRevuene.Columns[3].HeaderText = "Injection date";
            dgvRevuene.Columns[4].HeaderText = "Total";
            dgvRevuene.Columns[0].Width = 100;
            dgvRevuene.Columns[1].Width = 300;
            dgvRevuene.Columns[2].Width = 200;
            dgvRevuene.Columns[3].Width = 200;
            dgvRevuene.Columns[4].Width = 200;
            dgvRevuene.AllowUserToAddRows = false;
            dgvRevuene.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvRevuene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvRevuene.CurrentRow.Index;
            cbxScheduleID.Text = dgvRevuene.Rows[i].Cells[0].Value.ToString();
            cbxProvince.Text = dgvRevuene.Rows[i].Cells[1].Value.ToString();
            cbxCenter.Text = dgvRevuene.Rows[i].Cells[2].Value.ToString();
        }

        private void loadComboBox()
        {
            string sqlScheID;
            sqlScheID = "SELECT schedule_id FROM Schedule";
            DataAccess.fillDataCombo(sqlScheID, cbxScheduleID, "schedule_id", "schedule_id");
        }

        private void LoadProvinces()
        {
            var provinces = provinceDM?.GetProvinces();
            foreach (var province in provinces)
            {
                cbxProvince.Items.Add(province.Name);
            }
        }
        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedProvince = cbxProvince.SelectedItem.ToString();
            var centers = provinceDM?.GetVaccineCentersByProvince(selectedProvince);
            cbxCenter.Items.Clear();
            // Add the names of the vaccine centers to the ComboBox
            foreach (var center in centers)
            {
                cbxCenter.Items.Add(center.Name);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // Check for center selection
            if (!string.IsNullOrEmpty(cbxCenter.Text))
            {
                // View total revenue for chosen center
                string sqlTotal = "SELECT SUM(sche.total) as sum FROM Schedule as sche JOIN Centers as cen ON sche.center_id = cen.center_id WHERE cen.center_name = N'" + cbxCenter.Text + "'";
                string sum = DataAccess.getFieldValues(sqlTotal);
                txtTotalRevuene.Text = sum.ToString();
                return;
            }

            // Check for quarter selection
            if (!string.IsNullOrEmpty(cbxQuarter.Text))
            {
                viewQuarter();
                return;
            }

            // Check for date range selection
            if (dtpStartDay.Value != DateTime.Now && dtpEndDate.Value != DateTime.Now)
            {
                getTotalRevenue(dtpStartDay, dtpEndDate);
            }
        }

        private void viewQuarter()
        {
            int quarter = int.Parse(cbxQuarter.Text);
            string sql = "SELECT SUM(total) AS totalRevenue FROM Schedule WHERE MONTH(injection_date) BETWEEN ";
            switch (quarter)
            {
                case 1:
                    sql += "1 AND 3";
                    break;
                case 2:
                    sql += "4 AND 6";
                    break;
                case 3:
                    sql += "7 AND 9";
                    break;
                case 4:
                    sql += "10 AND 12";
                    break;
                default:
                    sql += "1 AND 12";
                    break;
            }
            using (SqlCommand command = new SqlCommand(sql, DataAccess.conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal totalRevenue = 0;

                        if (!reader.IsDBNull(reader.GetOrdinal("totalRevenue")))
                        {
                            totalRevenue = reader.GetDecimal(reader.GetOrdinal("totalRevenue"));
                        }
                        else
                        {
                            totalRevenue = 0;
                        }    
                        txtTotalRevuene.Text = totalRevenue.ToString();
                    }
                }
            }
        }
        private string dateTimeFormatted(DateTimePicker dtp)
        {
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtp.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            return formattedDateTime;
        }
        private void getTotalRevenue(DateTimePicker startDate, DateTimePicker endDate)
        {
            string start = dateTimeFormatted(startDate);
            string end = dateTimeFormatted(endDate);

            decimal totalRevenue = 0;
            // Execute SQL query to retrieve revenue data based on start and end dates
            string sql = "SELECT SUM(total) AS TotalRevenue FROM Schedule WHERE injection_date BETWEEN @StartDate AND @EndDate";
            using (SqlCommand command = new SqlCommand(sql, DataAccess.conn))
            {
                command.Parameters.AddWithValue("@StartDate", start);
                command.Parameters.AddWithValue("@EndDate", end);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("TotalRevenue")))
                        {
                            totalRevenue = reader.GetDecimal(reader.GetOrdinal("TotalRevenue"));
                        }
                        else
                        {
                            totalRevenue = 0;
                        }    
                    }

                    txtTotalRevuene.Text = totalRevenue.ToString();
                }
            }
        }
        private void reset()
        {
            cbxScheduleID.Text = string.Empty;
            cbxCenter.Text = string.Empty;
            cbxProvince.Text = string.Empty;
            cbxQuarter.Text = string.Empty;
            dtpStartDay.Text = DateTime.Now.ToShortDateString();
            dtpEndDate.Text = string.Empty;
            txtTotalRevuene.Text = "0";
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
