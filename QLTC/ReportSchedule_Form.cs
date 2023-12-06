using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class ReportSchedule_Form : Form
    {
        DataTable? dtSchedule;
        private ProvinceDataManager provinceDM;
        public ReportSchedule_Form()
        {
            InitializeComponent();
            provinceDM = new ProvinceDataManager();
        }

        private void ReportSchedule_Form_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            LoadProvinces();
            loadComboBox();
        }
        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT sche.schedule_id, sche.cus_id, sche.vac_id ,vac.disease, vac.producer, sche.injection_date, cen.province, cen.center_name, vac.num_injection FROM Schedule as sche INNER JOIN Vaccine as vac ON Sche.vac_id = vac.vac_id INNER JOIN Customer as cus ON sche.cus_id = cus.cus_id JOIN Centers as cen ON sche.center_id = cen.center_id";
            dtSchedule = DataAccess.getDataToTable(sql);
            dgvSchedule.DataSource = dtSchedule;
            dgvSchedule.Columns[0].HeaderText = "Schedule ID";
            dgvSchedule.Columns[1].HeaderText = "Customer ID";
            dgvSchedule.Columns[2].HeaderText = "Vaccine ID";
            dgvSchedule.Columns[3].HeaderText = "Disease";
            dgvSchedule.Columns[4].HeaderText = "Vaccine Producer";
            dgvSchedule.Columns[5].HeaderText = "Injection date";
            dgvSchedule.Columns[6].HeaderText = "Province";
            dgvSchedule.Columns[7].HeaderText = "VFA center";
            dgvSchedule.Columns[8].HeaderText = "Number of injections";
            dgvSchedule.Columns[0].Width = 100;
            dgvSchedule.Columns[1].Width = 300;
            dgvSchedule.Columns[2].Width = 200;
            dgvSchedule.Columns[3].Width = 300;
            dgvSchedule.Columns[4].Width = 200;
            dgvSchedule.Columns[5].Width = 100;
            dgvSchedule.Columns[6].Width = 100;
            dgvSchedule.Columns[7].Width = 100;
            dgvSchedule.Columns[8].Width = 100;
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
            string sqlScheID, sqlCusID, sqlVacID;
            sqlScheID = "SELECT schedule_id FROM Schedule";
            DataAccess.fillDataCombo(sqlScheID, cbxScheduleID, "schedule_id", "schedule_id");
            sqlCusID = "SELECT DISTINCT cus_id FROM Schedule";
            DataAccess.fillDataCombo(sqlCusID, cbxCusID, "cus_id", "cus_id");
            sqlVacID = "SELECT vac_id FROM Schedule";
            DataAccess.fillDataCombo(sqlVacID, cbxVacID, "vac_id", "vac_id");
        }
        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSchedule.CurrentRow.Index;
            cbxScheduleID.Text = dgvSchedule.Rows[i].Cells[0].Value.ToString();
            cbxCusID.Text = dgvSchedule.Rows[i].Cells[1].Value.ToString();
            cbxVacID.Text = dgvSchedule.Rows[i].Cells[2].Value.ToString();
            cbxProvince.Text = dgvSchedule.Rows[i].Cells[6].Value.ToString();
            cbxCenter.Text = dgvSchedule.Rows[i].Cells[7].Value.ToString();

        }

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedProvince = cbxProvince.SelectedItem.ToString();
            var centers = provinceDM.GetVaccineCentersByProvince(selectedProvince);
            cbxCenter.Items.Clear();
            // Add the names of the vaccine centers to the ComboBox
            foreach (var center in centers)
            {

                cbxCenter.Items.Add(center.Name);
            }
        }
    }
}
