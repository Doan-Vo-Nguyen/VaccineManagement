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
    public partial class ReportStock_Form : Form
    {
        // khai báo biến prodm của lớp ProvinceDataManager
        private ProvinceDataManager prodm;
        DataTable? dtSchedule;
        public ReportStock_Form()
        {
            InitializeComponent();
            prodm = new ProvinceDataManager();
        }

        // Load dữ liệu tỉnh lên form
        private void ReportStock_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
            LoadProvinces();
            LoadDataGridView();
            string sqlCenID = "SELECT center_id FROM VaccineWarehouse";
            DataAccess.fillDataCombo(sqlCenID, cbxCenterID, "center_id", "center_id");
        }

        // Khi chọn tỉnh thì hàm sẽ thực hiện thay đổi center theo tỉnh đã chọn
        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedProvince = cbxProvince.SelectedItem.ToString();
            var centers = prodm.GetVaccineCentersByProvince(selectedProvince);

            // Clear the existing items in the centerComboBox
            cbxCenter.Items.Clear();

            // Add the names of the vaccine centers to the ComboBox
            foreach (var center in centers)
            {
                cbxCenter.Items.Add(center.Name);
            }
        }

        // Hàm lấy tỉnh từ Class ProvinceVaccine 
        private void LoadProvinces()
        {
            var provinces = prodm.GetProvinces();
            cbxProvince.Items.Clear();
            foreach (var province in provinces)
            {
                cbxProvince.Items.Add(province.Name);
            }
        }
        // Load dữ liệu lên DataGridView
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT vacw.center_id, cen.center_name, vacw.quanity, vacw.input_day, cen.province, vacw.status FROM VaccineWarehouse as vacw JOIN Centers as cen ON vacw.center_id = cen.center_id";
            dtSchedule = DataAccess.getDataToTable(sql);
            dgvSchedule.DataSource = dtSchedule;
            dgvSchedule.Columns[0].HeaderText = "Center ID";
            dgvSchedule.Columns[1].HeaderText = "Center name";
            dgvSchedule.Columns[2].HeaderText = "Quanity";
            dgvSchedule.Columns[3].HeaderText = "Input day";
            dgvSchedule.Columns[4].HeaderText = "Province";
            dgvSchedule.Columns[5].HeaderText = "Status";
            dgvSchedule.Columns[0].Width = 100;
            dgvSchedule.Columns[1].Width = 100;
            dgvSchedule.Columns[2].Width = 100;
            dgvSchedule.Columns[3].Width = 200;
            dgvSchedule.Columns[4].Width = 200;
            dgvSchedule.Columns[5].Width = 200;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbxCenter.Text != string.Empty || cbxCenterID.Text != string.Empty)
            {
                string sqlRemain = "SELECT quanity FROM VaccineWarehouse as vacw JOIN Centers as cen ON vacw.center_id = cen.center_id WHERE vacw.center_id = N'" + cbxCenterID.Text + "' OR cen.center_name = N'" + cbxCenter.Text + "'";
                txtRemainVac.Text = DataAccess.getFieldValues(sqlRemain);
                string sqlInjectedVac = "SELECT count(sche.schedule_id) FROM Customer as cus JOIN Schedule as sche ON cus.cus_id = sche.cus_id JOIN Centers as cen ON sche.center_id = cen.center_id WHERE cen.center_name = N'" + cbxCenter.Text + "' OR cen.center_id = N'" + cbxCenterID.Text + "'";
                txtInjectedVac.Text = DataAccess.getFieldValues(sqlInjectedVac);
            }
            else
            {
                MessageBox.Show("Please select the Center name or Center ID to make a query", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbxCenterID.Text = string.Empty;
            cbxProvince.Text = string.Empty;
            cbxCenter.Text = string.Empty;
            dtpDate.Text = DateTime.Now.ToShortDateString();
            cbxStatus.Text = string.Empty;
            txtInjectedVac.Text = "0";
            txtRemainVac.Text = "0";
            
        }

        // Đóng
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
