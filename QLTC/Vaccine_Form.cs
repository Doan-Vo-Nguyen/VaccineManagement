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
    public partial class Vaccine_Form : Form
    {
        DataTable dtVaccine;
        public Vaccine_Form()
        {
            InitializeComponent();
        }

        private void Vaccine_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT vac_id, vacname, disease, producer, price FROM Vaccine";
            dtVaccine = DataAccess.getDataToTable(sql);
            dgvVacInfor.DataSource = dtVaccine;
            dgvVacInfor.Columns[0].HeaderText = "Vaccine ID";
            dgvVacInfor.Columns[1].HeaderText = "Vaccine Name";
            dgvVacInfor.Columns[2].HeaderText = "Vaccine Type";
            dgvVacInfor.Columns[3].HeaderText = "Vaccine Producer";
            dgvVacInfor.Columns[4].HeaderText = "Price";
            dgvVacInfor.Columns[0].Width = 100;
            dgvVacInfor.Columns[1].Width = 300;
            dgvVacInfor.Columns[2].Width = 200;
            dgvVacInfor.Columns[3].Width = 300;
            dgvVacInfor.Columns[4].Width = 200;
            dgvVacInfor.AllowUserToAddRows = false;
            dgvVacInfor.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
