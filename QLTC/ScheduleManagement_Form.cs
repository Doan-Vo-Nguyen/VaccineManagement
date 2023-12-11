using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class ScheduleManagement_Form : Form
    {
        DataTable? dtCusManagent;
        private ProvinceDataManager provinceDM;
        public ScheduleManagement_Form()
        {
            InitializeComponent();
            provinceDM = new ProvinceDataManager();
        }

        private void ScheduleManagement_Form_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            LoadProvinces();
            loadComboBox();
        }

        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT sche.schedule_id, sche.cus_id, vac.vacname,disease, vac.producer, sche.injection_date, cen.province, cen.center_name, vac.price, vac.num_injection, sche.total FROM Schedule as sche INNER JOIN Vaccine as vac ON Sche.vac_id = vac.vac_id INNER JOIN Customer as cus ON sche.cus_id = cus.cus_id JOIN Centers as cen ON sche.center_id = cen.center_id";
            dtCusManagent = DataAccess.getDataToTable(sql);
            dgvSchedule.DataSource = dtCusManagent;
            dgvSchedule.Columns[0].HeaderText = "Schedule ID";
            dgvSchedule.Columns[1].HeaderText = "Customer ID";
            dgvSchedule.Columns[2].HeaderText = "Vaccine name";
            dgvSchedule.Columns[3].HeaderText = "Disease";
            dgvSchedule.Columns[4].HeaderText = "Vaccine Producer";
            dgvSchedule.Columns[5].HeaderText = "Injection date";
            dgvSchedule.Columns[6].HeaderText = "Province";
            dgvSchedule.Columns[7].HeaderText = "VFA center";
            dgvSchedule.Columns[8].HeaderText = "Price";
            dgvSchedule.Columns[9].HeaderText = "Number of injections";
            dgvSchedule.Columns[10].HeaderText = "Total";
            dgvSchedule.Columns[0].Width = 100;
            dgvSchedule.Columns[1].Width = 300;
            dgvSchedule.Columns[2].Width = 200;
            dgvSchedule.Columns[3].Width = 300;
            dgvSchedule.Columns[4].Width = 200;
            dgvSchedule.Columns[5].Width = 100;
            dgvSchedule.Columns[6].Width = 100;
            dgvSchedule.Columns[7].Width = 100;
            dgvSchedule.Columns[8].Width = 100;
            dgvSchedule.Columns[9].Width = 100;
            dgvSchedule.Columns[10].Width = 100;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadProvinces()
        {
            var provinces = provinceDM.GetProvinces();
            foreach (var province in provinces)
            {
                cbxProvince.Items.Add(province.Name);
            }
        }
        private void loadComboBox()
        {
            string sqlCusID = "SELECT cus_id FROM Customer";
            DataAccess.fillDataCombo(sqlCusID, cbxCusID, "cus_id", "cus_id");
            string sqlScheID = "SELECT schedule_id FROM Schedule";
            DataAccess.fillDataCombo(sqlScheID, cbxScheduleID, "schedule_id", "schedule_id");
        }
        private void cbxVacType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVacType.Text == "")
            {
                //cbxVacName.Text = "";
                txtPrice.Text = "";
            }
            // When choose Vac type  , all field of SERVICE INFORMATION will fill
            DataAccess.fillDataCombo("SELECT vacname FROM Vaccine WHERE disease LIKE N'%" + cbxVacType.SelectedValue.ToString() + "%'", cbxVacName, "vacname", "vacname");
        }
        private void cbxVacName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbxVacName.Text != "")
            {
                str = "SELECT price FROM Vaccine WHERE vacname LIKE N'%" + cbxVacName.SelectedValue.ToString() + "%'";
                txtPrice.Text = DataAccess.getFieldValues(str);
            }
            else
            {
                MessageBox.Show("Choose vaccine name!");
            }
        }
        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvince = cbxProvince.SelectedItem.ToString();
            var centers = provinceDM.GetVaccineCentersByProvince(selectedProvince);
            cbxCenterInject.Items.Clear();
            // Add the names of the vaccine centers to the ComboBox
            foreach (var center in centers)
            {

                cbxCenterInject.Items.Add(center.Name);
            }
        }
        private void cbxCusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str, cusID;
            cusID = cbxCusID.Text;
            if (cusID != string.Empty)
            {
                // Show all information to every field of Customer 
                str = "SELECT fullname FROM Customer WHERE cus_id = " + cusID;
                txtName.Text = DataAccess.getFieldValues(str);
                str = "SELECT birth FROM Customer WHERE cus_id = " + cusID;
                dtpBirth.Text = DataAccess.getFieldValues(str);
                str = "SELECT gender FROM Customer WHERE cus_id = " + cusID;
                cbSex.Text = DataAccess.getFieldValues(str);
                str = "SELECT address FROM Customer WHERE cus_id = " + cusID;
                cbxAddress.Text = DataAccess.getFieldValues(str);
                str = "SELECT phonenum FROM Customer WHERE cus_id = " + cusID;
                txtPhonenumber.Text = DataAccess.getFieldValues(str);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtpDateInject.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            if (dtpDateInject.Value == DateTime.MinValue)
            {
                MessageBox.Show("Please select a date to inject!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbxCenterInject.Text == string.Empty)
            {
                MessageBox.Show("Please select a VFA center to inject!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int vacId = int.Parse(DataAccess.getFieldValues("SELECT vac_id FROM Vaccine WHERE vacname LIKE N'%" + cbxVacName.SelectedValue.ToString() + "%'"));
            // Call the procedure
            try
            {
                if (CheckDuplicatedSchedule(formattedDateTime, cbxCusID.Text))
                {
                    MessageBox.Show("You cannot register for more 2 schedules on the same day!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (getVaccineNumber() > 0)
                {
                    MessageBox.Show("Vaccine is out of stock, please understand", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string center = DataAccess.getFieldValues("SELECT DISTINCT center_id FROM Centers WHERE center_name = N'" + cbxCenterInject.Text + "' AND province = N'" + cbxProvince.Text + "'");
                int centerID = int.Parse(center);
                // Your existing code to insert into the Schedule table
                string addSqlSchedule = "INSERT INTO Schedule VALUES(@cus_id, @vac_id, @injection_date, @center_id, @total)";
                string[] nameSchedule = { "@cus_id", "@vac_id", "@injection_date", "@center_id", "@total" };
                object[] valueSchedule = { cbxCusID.Text, vacId, formattedDateTime, centerID, txtTotal.Text };
                DataAccess.runSQL(addSqlSchedule, nameSchedule, valueSchedule);
                // Call the stored procedure to insert into IntermediacteCalendar
                using (SqlCommand cmd = new SqlCommand("InsertVaccinationSchedule", DataAccess.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Parameters for the stored procedure
                    cmd.Parameters.AddWithValue("@cus_id", cbxCusID.Text);
                    cmd.Parameters.AddWithValue("@vac_id", vacId); // Replace with the actual vaccine ID
                    cmd.Parameters.AddWithValue("@center_id", centerID);
                    cmd.Parameters.AddWithValue("@injection_date", formattedDateTime); // Replace with the actual injection date
                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Schedule add successfully!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    updateVaccineNumber(cbxCenterInject);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool CheckDuplicatedSchedule(string injectionDate, string cusID)
        {
            // SQL query to check for duplicated schedules
            string sqlDuplicated = "SELECT COUNT(*) as count FROM Schedule WHERE injection_date = @injectionDate AND cus_id = @cusID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlDuplicated, DataAccess.conn))
                {

                    cmd.Parameters.AddWithValue("@injectionDate", injectionDate);
                    cmd.Parameters.AddWithValue("@cusID", cusID);
                    int num = Convert.ToInt32(cmd.ExecuteScalar());
                    return num > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error checking duplicated schedule: " + ex.Message);
                return false;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxScheduleID.Text == String.Empty)
            {
                MessageBox.Show("Please select a schedule to delete!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Do you want to delete this?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            string sqlDelete = "DELETE FROM Schedule WHERE schedule_id = @id";
            string[] name = { "@id" };
            object[] value = { cbxScheduleID.Text };
            DataAccess.runSQL(sqlDelete, name, value);
            MessageBox.Show("Schedule deleted successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loadDataGridView();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtpDateInject.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlUpdate;
            if (dtCusManagent?.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string center = DataAccess.getFieldValues("SELECT DISTINCT center_id FROM Centers WHERE center_name = " + cbxCenterInject.Text + " AND province = " + cbxProvince.Text);
                int centerID = int.Parse(center);
                sqlUpdate = "UPDATE Schedule SET  injection_date = @injectionDate, center_id = @center_id WHERE schedule_id = @id";
                string[] name = { "@injectionDate", "@center_id", "@id" };
                object[] value = { formattedDateTime, centerID, cbxScheduleID.Text };
                DataAccess.runSQL(sqlUpdate, name, value);
                MessageBox.Show("Schedule updated successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridView();
                reset();
                btnCancel.Enabled = true;
            }
        }
        private int getVaccineNumber()
        {
            string center = DataAccess.getFieldValues("SELECT DISTINCT center_id FROM Centers WHERE center_name = N'" + cbxCenterInject.Text + "' AND province = N'" + cbxProvince.Text + "'");
            int centerID = int.Parse(center);
            string sqlNumber = "SELECT quanity FROM VaccineWarehouse WHERE center_id = " + centerID;
            int number = int.Parse(DataAccess.getFieldValues(sqlNumber));
            return number;
        }
        private void updateVaccineNumber(System.Windows.Forms.ComboBox cbx)
        {
            int vacNumber = getVaccineNumber();
            try
            {
                if (cbx != null && getVaccineNumber() != 0)
                {
                    int quanity = vacNumber - 1;
                    string center = DataAccess.getFieldValues("SELECT DISTINCT center_id FROM Centers WHERE center_name = N'" + cbxCenterInject.Text + "' AND province = N'" + cbxProvince.Text + "'");
                    int centerID = int.Parse(center);
                    string sqlUpdate = "UPDATE VaccineWarehouse set quanity = @quanity WHERE center_id = @center_id";
                    string[] name = { "@quanity", "@center_id" };
                    object[] value = { quanity, centerID };
                    DataAccess.runSQL(sqlUpdate, name, value);
                }
            }
            catch
            {
                MessageBox.Show("Invalid!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSchedule.CurrentRow.Index;
            cbxScheduleID.Text = dgvSchedule.Rows[i].Cells[0].Value.ToString();
            cbxCusID.Text = dgvSchedule.Rows[i].Cells[1].Value.ToString();
            cbxVacName.Text = dgvSchedule.Rows[i].Cells[2].Value.ToString();
            cbxVacType.Text = dgvSchedule.Rows[i].Cells[3].Value.ToString();
            dtpDateInject.Text = dgvSchedule.Rows[i].Cells[5].Value.ToString();
            cbxProvince.Text = dgvSchedule.Rows[i].Cells[6].Value.ToString();
            cbxCenterInject.Text = dgvSchedule.Rows[i].Cells[7].Value.ToString();
            txtPrice.Text = dgvSchedule.Rows[i].Cells[8].Value.ToString();
            txtTotal.Text = dgvSchedule.Rows[i].Cells[10].Value.ToString();
        }
        private void reset()
        {
            cbxScheduleID.Text = string.Empty;
            cbxVacType.Text = string.Empty;
            cbxVacName.Text = string.Empty;
            cbxProvince.Text = string.Empty;
            dtpDateInject.Text = DateTime.Now.ToShortDateString();
            cbxCenterInject.Text = string.Empty;
            txtPrice.Text = "0";
            txtTotal.Text = "0";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
