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
        DataTable? dtVaccine;
        public Vaccine_Form()
        {
            InitializeComponent();
        }
        private void Vaccine_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
            loadDataGridView();
            txtID.Enabled = false;
        }
        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT vac_id, vacname, disease, producer, price, num_injection, distance_injection FROM Vaccine";
            dtVaccine = DataAccess.getDataToTable(sql);
            dgvVacInfor.DataSource = dtVaccine;
            dgvVacInfor.Columns[0].HeaderText = "Vaccine ID";
            dgvVacInfor.Columns[1].HeaderText = "Vaccine Name";
            dgvVacInfor.Columns[2].HeaderText = "Vaccine Type";
            dgvVacInfor.Columns[3].HeaderText = "Vaccine Producer";
            dgvVacInfor.Columns[4].HeaderText = "Price";
            dgvVacInfor.Columns[5].HeaderText = "Number Injection";
            dgvVacInfor.Columns[6].HeaderText = "Distance Injection";
            dgvVacInfor.Columns[0].Width = 100;
            dgvVacInfor.Columns[1].Width = 300;
            dgvVacInfor.Columns[2].Width = 200;
            dgvVacInfor.Columns[3].Width = 300;
            dgvVacInfor.Columns[4].Width = 100;
            dgvVacInfor.Columns[5].Width = 100;
            dgvVacInfor.Columns[6].Width = 100;
            dgvVacInfor.AllowUserToAddRows = false;
            dgvVacInfor.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void loadDataGridViewSearch()
        {
            dgvVacInfor.DataSource = dtVaccine;
            dgvVacInfor.Columns[0].HeaderText = "Vaccine ID";
            dgvVacInfor.Columns[1].HeaderText = "Vaccine Name";
            dgvVacInfor.Columns[2].HeaderText = "Vaccine Type";
            dgvVacInfor.Columns[3].HeaderText = "Vaccine Producer";
            dgvVacInfor.Columns[4].HeaderText = "Price";
            dgvVacInfor.Columns[5].HeaderText = "Number Injection";
            dgvVacInfor.Columns[6].HeaderText = "Distance Injection";
            dgvVacInfor.Columns[0].Width = 100;
            dgvVacInfor.Columns[1].Width = 300;
            dgvVacInfor.Columns[2].Width = 200;
            dgvVacInfor.Columns[3].Width = 300;
            dgvVacInfor.Columns[4].Width = 100;
            dgvVacInfor.Columns[5].Width = 100;
            dgvVacInfor.Columns[6].Width = 100;
            // Not allow user add data directly
            dgvVacInfor.AllowUserToAddRows = false;
            // Not allow user update data directly
            dgvVacInfor.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dgvVacInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvVacInfor.CurrentRow.Index;
            txtID.Text = dgvVacInfor.Rows[i].Cells[0].Value.ToString();
            txtVacName.Text = dgvVacInfor.Rows[i].Cells[1].Value.ToString();
            txtVacType.Text = dgvVacInfor.Rows[i].Cells[2].Value.ToString();
            txtVacProc.Text = dgvVacInfor.Rows[i].Cells[3].Value.ToString();
            txtPrice.Text = dgvVacInfor.Rows[i].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtVacName.Text != string.Empty || txtVacProc.Text != string.Empty || txtVacType.Text != string.Empty)
            {
                sql = "SELECT * FROM Vaccine WHERE 1=1";
                if (txtVacName.Text != "")
                {
                    sql = sql + " AND vacname LIKE N'%" + txtVacName.Text + "%'";
                }
                if (txtVacType.Text != "")
                {
                    sql = sql + " AND disease LIKE N'%" + txtVacType.Text + "%'";
                }
                if (txtVacProc.Text != "")
                {
                    sql = sql + " AND producer LIKE N'%" + txtVacProc.Text + "%'";
                }
            }
            else
            {
                MessageBox.Show("Please type a condition for searching", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtVaccine = DataAccess.getDataToTable(sql);
            if (dtVaccine.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("There are " + dtVaccine.Rows.Count + "records that satisfy the condition", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvVacInfor.DataSource = dtVaccine;
            loadDataGridViewSearch();
        }

        private void reset()
        {
            txtID.Text = string.Empty;
            txtVacName.Text = string.Empty;
            txtVacProc.Text = string.Empty;
            txtVacType.Text = string.Empty;
            txtPrice.Text = "0";
            loadDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
