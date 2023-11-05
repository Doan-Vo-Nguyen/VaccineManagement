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
        DataTable dtSchedule;
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
        }

        // Khi chọn tỉnh thì hàm sẽ thực hiện thay đổi center theo tỉnh đã chọn
        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvince = cbxProvince.SelectedItem.ToString();
            var centers = prodm.GetVaccineCentersByProvince(selectedProvince);

            // Clear the existing items in the centerComboBox
            cbxCenter.Items.Clear();

            // Add the names of the vaccine centers to the ComboBox
            foreach (var center in centers)
            {
                cbxCenter.Items.Add(center.Name);
            }
        }
        // Đóng
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            sql = "SELECT * FROM Schedule";
            dtSchedule = DataAccess.getDataToTable(sql);
            dgvSchedule.DataSource = dtSchedule;
            dgvSchedule.Columns[0].HeaderText = "Schedule ID";
            dgvSchedule.Columns[1].HeaderText = "Customer ID";
            dgvSchedule.Columns[2].HeaderText = "Vaccine ID";
            dgvSchedule.Columns[3].HeaderText = "Date Inject";
            dgvSchedule.Columns[4].HeaderText = "Province";
            dgvSchedule.Columns[5].HeaderText = "Center Inject";
            dgvSchedule.Columns[0].Width = 100;
            dgvSchedule.Columns[1].Width = 100;
            dgvSchedule.Columns[2].Width = 100;
            dgvSchedule.Columns[3].Width = 300;
            dgvSchedule.Columns[4].Width = 200;
            dgvSchedule.Columns[5].Width = 400;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

    }
}
