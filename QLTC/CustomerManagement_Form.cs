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
    public partial class CustomerManagement_Form : Form
    {
        DataTable? dtCustomer;
        public CustomerManagement_Form()
        {
            InitializeComponent();
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Customer";
            dtCustomer = DataAccess.getDataToTable(sql);
            dgvCustomer.DataSource = dtCustomer;
            dgvCustomer.Columns[0].HeaderText = "Customer ID";
            dgvCustomer.Columns[1].HeaderText = "Full name";
            dgvCustomer.Columns[2].HeaderText = "Birth";
            dgvCustomer.Columns[3].HeaderText = "Gender";
            dgvCustomer.Columns[4].HeaderText = "Address";
            dgvCustomer.Columns[5].HeaderText = "Phone number";
            dgvCustomer.Columns[6].HeaderText = "Status";
            dgvCustomer.Columns[7].HeaderText = "Injected";
            dgvCustomer.Columns[0].Width = 100;
            dgvCustomer.Columns[1].Width = 300;
            dgvCustomer.Columns[2].Width = 200;
            dgvCustomer.Columns[3].Width = 300;
            dgvCustomer.Columns[4].Width = 200;
            dgvCustomer.Columns[5].Width = 200;
            dgvCustomer.Columns[6].Width = 200;
            dgvCustomer.Columns[7].Width = 200;
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        // CHOOSE DATA ROW FROM DATAGRIDVIEW, IT WILL DISPLAY TO OTHER.
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvCustomer.CurrentRow.Index;
            cbxID.Text = dgvCustomer.Rows[i].Cells[0].Value.ToString();
            txtFullname.Text = dgvCustomer.Rows[i].Cells[1].Value.ToString();
            dtpBirth.Text = dgvCustomer.Rows[i].Cells[2].Value.ToString();
            cbxGender.Text = dgvCustomer.Rows[i].Cells[3].Value.ToString();
            cbxAddress.Text = dgvCustomer.Rows[i].Cells[4].Value.ToString();
            txtPhonenumber.Text = dgvCustomer.Rows[i].Cells[5].Value.ToString();
            cbxStatus.Text = dgvCustomer.Rows[i].Cells[6].Value.ToString();
            txtInjected.Text = dgvCustomer.Rows[i].Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtpBirth.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string updateSQL;
            updateSQL = "UPDATE Customer SET fullname = @name, birth = @birth, gender = @gender, address = @address," +
            "phonenum = @phonenum, status = @status, injected = @injected WHERE cus_id = @id";
            string[] name = { "@name", "@birth", "@gender", "@address", "@phonenum", "@status", "@injected", "id" };
            object[] value = { txtFullname.Text, selectedDateTime, cbxGender.Text, cbxAddress.Text, txtPhonenumber.Text, cbxStatus.Text, txtInjected.Text, cbxID.Text };
            DataAccess.runSQL(updateSQL, name, value);
            MessageBox.Show("Customer updated successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
