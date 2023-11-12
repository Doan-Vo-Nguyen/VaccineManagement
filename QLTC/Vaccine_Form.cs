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
        private string ID;
        public Vaccine_Form()
        {
            InitializeComponent();
        }

        private void Vaccine_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
            loadDataGridView();
            updateFunctionForRole();
        }

        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT vac_id, vacname, disease, producer, price, num_injection FROM Vaccine";
            dtVaccine = DataAccess.getDataToTable(sql);
            dgvVacInfor.DataSource = dtVaccine;
            dgvVacInfor.Columns[0].HeaderText = "Vaccine ID";
            dgvVacInfor.Columns[1].HeaderText = "Vaccine Name";
            dgvVacInfor.Columns[2].HeaderText = "Vaccine Type";
            dgvVacInfor.Columns[3].HeaderText = "Vaccine Producer";
            dgvVacInfor.Columns[4].HeaderText = "Price";
            dgvVacInfor.Columns[4].HeaderText = "Number of injections";
            dgvVacInfor.Columns[0].Width = 100;
            dgvVacInfor.Columns[1].Width = 300;
            dgvVacInfor.Columns[2].Width = 200;
            dgvVacInfor.Columns[3].Width = 300;
            dgvVacInfor.Columns[4].Width = 200;
            dgvVacInfor.Columns[4].Width = 100;
            dgvVacInfor.AllowUserToAddRows = false;
            dgvVacInfor.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateFunctionForRole()
        {
            if (ID != String.Empty)
            {
                ID = Login_Form.cusID.ToString();
                string sqlcusID = "SELECT * FROM Account WHERE cus_id = '" + ID + "'";
                if (DataAccess.checkKey(sqlcusID))
                {

                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCancel.Enabled = true;
                    btnSearch.Enabled = true;
                    btnExit.Enabled = true;
                }
            }
            else
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnCancel.Enabled = true;
                btnSearch.Enabled = true;
                btnExit.Enabled = true;
            }
        }
    }
}
