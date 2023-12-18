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
    public partial class VaccineManagement : Form
    {
        DataTable? dtVaccine;
        public VaccineManagement()
        {
            InitializeComponent();
        }

        private void VaccineManagement_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadComboBox();
        }

        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Vaccine";
            dtVaccine = DataAccess.getDataToTable(sql);
            dgvVacInfor.DataSource = dtVaccine;
            dgvVacInfor.Columns[0].HeaderText = "Vaccine ID";
            dgvVacInfor.Columns[1].HeaderText = "Vaccine Name";
            dgvVacInfor.Columns[2].HeaderText = "Vaccine Type";
            dgvVacInfor.Columns[3].HeaderText = "Vaccine Producer";
            dgvVacInfor.Columns[4].HeaderText = "Production batch";
            dgvVacInfor.Columns[5].HeaderText = "MFG";
            dgvVacInfor.Columns[6].HeaderText = "Expiry";
            dgvVacInfor.Columns[7].HeaderText = "Price";
            dgvVacInfor.Columns[8].HeaderText = "Number of injection";
            dgvVacInfor.Columns[9].HeaderText = "Distance injection";
            dgvVacInfor.Columns[0].Width = 100;
            dgvVacInfor.Columns[1].Width = 300;
            dgvVacInfor.Columns[2].Width = 200;
            dgvVacInfor.Columns[3].Width = 300;
            dgvVacInfor.Columns[4].Width = 100;
            dgvVacInfor.Columns[5].Width = 100;
            dgvVacInfor.Columns[6].Width = 100;
            dgvVacInfor.Columns[7].Width = 100;
            dgvVacInfor.Columns[8].Width = 100;
            dgvVacInfor.Columns[9].Width = 100;
            dgvVacInfor.AllowUserToAddRows = false;
            dgvVacInfor.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void loadDataGridViewSearch()
        {
            dgvVacInfor.Columns[0].HeaderText = "Vaccine ID";
            dgvVacInfor.Columns[1].HeaderText = "Vaccine Name";
            dgvVacInfor.Columns[2].HeaderText = "Vaccine Type";
            dgvVacInfor.Columns[3].HeaderText = "Vaccine Producer";
            dgvVacInfor.Columns[4].HeaderText = "Production batch";
            dgvVacInfor.Columns[5].HeaderText = "MFG";
            dgvVacInfor.Columns[6].HeaderText = "Expiry";
            dgvVacInfor.Columns[7].HeaderText = "Price";
            dgvVacInfor.Columns[8].HeaderText = "Number of injection";
            dgvVacInfor.Columns[9].HeaderText = "Distance injection";
            dgvVacInfor.Columns[0].Width = 100;
            dgvVacInfor.Columns[1].Width = 300;
            dgvVacInfor.Columns[2].Width = 200;
            dgvVacInfor.Columns[3].Width = 300;
            dgvVacInfor.Columns[4].Width = 100;
            dgvVacInfor.Columns[5].Width = 100;
            dgvVacInfor.Columns[6].Width = 100;
            dgvVacInfor.Columns[7].Width = 100;
            dgvVacInfor.Columns[8].Width = 100;
            dgvVacInfor.Columns[9].Width = 100;
            dgvVacInfor.AllowUserToAddRows = false;
            dgvVacInfor.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void loadComboBox()
        {
            string sqlVacDisease;
            sqlVacDisease = "SELECT DISTINCT disease FROM Vaccine";
            DataAccess.fillDataCombo(sqlVacDisease, cbxDisease, "disease", "disease");
        }
        private void dgvVacInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvVacInfor.CurrentRow.Index;
            txtID.Text = dgvVacInfor.Rows[i].Cells[0].Value.ToString();
            txtVacName.Text = dgvVacInfor.Rows[i].Cells[1].Value.ToString();
            cbxDisease.Text = dgvVacInfor.Rows[i].Cells[2].Value.ToString();
            txtVacProc.Text = dgvVacInfor.Rows[i].Cells[3].Value.ToString();
            txtBatch.Text = dgvVacInfor.Rows[i].Cells[4].Value.ToString();
            dtpMFG.Text = dgvVacInfor.Rows[i].Cells[5].Value.ToString();
            dtpExpiry.Text = dgvVacInfor.Rows[i].Cells[6].Value.ToString();
            txtPrice.Text = dgvVacInfor.Rows[i].Cells[7].Value.ToString();
            txtNumInject.Text = dgvVacInfor.Rows[i].Cells[8].Value.ToString();
            txtDisInject.Text = dgvVacInfor.Rows[i].Cells[9].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mfgDate = dateTimeFormatted(dtpMFG);
            string expiryDate = dateTimeFormatted(dtpExpiry);
            if (txtVacName.Text != String.Empty && txtVacProc.Text != String.Empty && txtBatch.Text != String.Empty
                && cbxDisease.Text != String.Empty && txtBatch.Text != String.Empty && txtPrice.Text != String.Empty
                && txtNumInject.Text != String.Empty && txtDisInject.Text != String.Empty)
            {
                string addSql = "INSERT INTO Vaccine VALUES(@vacname, @vactype, @producer, @proBatch, @mfg, @expiry, @price, @numInject, @distanceInject)";
                string[] name = { "@vacname", "@vactype", "producer", "@proBatch", "@mfg", "@expiry", "@price", "@numInject", "@distanceInject" };
                object[] value = { txtVacName.Text, cbxDisease.Text, txtVacProc.Text, txtBatch.Text, mfgDate, expiryDate, txtPrice.Text, txtNumInject.Text, txtDisInject.Text };
                DataAccess.runSQL(addSql, name, value);
                MessageBox.Show("Vaccine add successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridView();
            }
            else
            {
                MessageBox.Show("Please enter complete information!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string dateTimeFormatted(DateTimePicker dtp)
        {
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtp.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            return formattedDateTime;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty)
            {
                MessageBox.Show("Please select a schedule to delete!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Do you want to delete this?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            string sqlDelete = "DELETE FROM Vaccine WHERE vac_id = @id";
            string[] name = { "@id" };
            object[] value = { txtID.Text };
            DataAccess.runSQL(sqlDelete, name, value);
            MessageBox.Show("Vaccine deleted successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loadDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mfgDate = dateTimeFormatted(dtpMFG);
            string expiryDate = dateTimeFormatted(dtpExpiry);
            if (dtVaccine?.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtID.Text == String.Empty)
            {
                MessageBox.Show("Choose vaccine to update", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlUpdate = "UPDATE Vaccine SET vacname = @vacName, disease = @vacType, producer = @producer, production_batch = @proBatch, mfg = @mfg, expiry = @expiry, price = @price, num_injection = @numInject, distance_injection = @disInject WHERE vac_id = @id";
            string[] name = { "@vacName", "@vacType", "@producer", "@proBatch", "@mfg", "@expiry", "@price", "@numInject", "@disInject", "@id" };
            object[] value = { txtVacName.Text, cbxDisease.Text, txtVacProc.Text, txtBatch.Text, mfgDate, expiryDate, txtPrice.Text, txtNumInject.Text, txtDisInject.Text, txtID.Text };
            DataAccess.runSQL(sqlUpdate, name, value);
            MessageBox.Show("Schedule updated successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            reset();
            btnCancel.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtVacName.Text != string.Empty || txtVacProc.Text != string.Empty || cbxDisease.Text != string.Empty)
            {
                sql = "SELECT * FROM Vaccine WHERE 1=1";
                if (txtVacName.Text != "")
                {
                    sql = sql + " AND vacname LIKE N'%" + txtVacName.Text + "%'";
                }
                if (cbxDisease.Text != "")
                {
                    sql = sql + " AND disease LIKE N'%" + cbxDisease.Text + "%'";
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
            cbxDisease.Text = string.Empty;
            txtVacProc.Text = string.Empty;
            txtBatch.Text = string.Empty;
            dtpMFG.Text = DateTime.Now.ToShortDateString();
            dtpExpiry.Text = DateTime.Now.ToShortDateString();
            txtPrice.Text = string.Empty;
            txtNumInject.Text = "0";
            txtDisInject.Text = "0";
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
