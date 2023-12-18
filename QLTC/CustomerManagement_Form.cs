using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLTC
{
    public partial class CustomerManagement_Form : Form
    {
        DataTable? dtCustomer;
        public CustomerManagement_Form()
        {
            InitializeComponent();
            loadDataGridView();
            loadComboBox();
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

        private void loadComboBox()
        {
            string sqlCusId = "SELECT cus_id FROM Customer";
            DataAccess.fillDataCombo(sqlCusId, cbxID, "cus_id", "cus_id");
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
        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str, cusID;
            cusID = cbxID.Text;
            if (cusID != string.Empty)
            {
                // Show all information to every field of Customer 
                str = "SELECT fullname FROM Customer WHERE cus_id = " + cusID;
                txtFullname.Text = DataAccess.getFieldValues(str);
                str = "SELECT birth FROM Customer WHERE cus_id = " + cusID;
                dtpBirth.Text = DataAccess.getFieldValues(str);
                str = "SELECT gender FROM Customer WHERE cus_id = " + cusID;
                cbxGender.Text = DataAccess.getFieldValues(str);
                str = "SELECT address FROM Customer WHERE cus_id = " + cusID;
                cbxAddress.Text = DataAccess.getFieldValues(str);
                str = "SELECT phonenum FROM Customer WHERE cus_id = " + cusID;
                txtPhonenumber.Text = DataAccess.getFieldValues(str);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Format date time from dd/ mm / yyyy to yyyy-mm - dd
            DateTime selectedDateTime = dtpBirth.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = string.Format("SELECT count(*) from Customer WHERE cus_id ='{0}'", cbxID.Text);
            if (cbxID.Text == string.Empty)
            {
                MessageBox.Show("Please enter ID!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtFullname.Text == string.Empty)
            {
                MessageBox.Show("Please enter name!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtpBirth.Value == DateTime.Now)
            {
                MessageBox.Show("Invalid date, try again!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DataAccess.executeScalar(sql) == 0)
            {
                string addCus = "INSERT INTO Customer VALUES(@cus_id, @fullname, @birth, @gender, @address, @phonenum, @status, @injected)";
                string[] name = { "@cus_id", "@fullname", "@birth", "@gender", "@address", "@phonenum", "@status", "@injected" };
                object[] value = { cbxID.Text, txtFullname.Text, formattedDateTime, cbxGender.Text, cbxAddress.Text, txtPhonenumber.Text, cbxStatus.Text, txtInjected.Text };
                DataAccess.runSQL(addCus, name, value);
                MessageBox.Show("Add successfully!Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User have already existed!Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxID.Text == String.Empty)
            {
                MessageBox.Show("Please select a customer to delete!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Do you want to delete this?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            string sqlDelete = "DELETE FROM Customer WHERE cus_id = @id";
            string[] name = { "@id" };
            object[] value = { cbxID.Text };
            DataAccess.runSQL(sqlDelete, name, value);
            MessageBox.Show("Customer deleted successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loadDataGridView();
        }

        private void reset()
        {
            cbxID.Text = string.Empty;
            txtFullname.Text = string.Empty;
            txtInjected.Text = string.Empty;
            txtPhonenumber.Text = string.Empty;
            cbxAddress.Text = string.Empty;
            dtpBirth.Text = DateTime.Now.ToShortDateString();
            cbxGender.Text = string.Empty;
            cbxStatus.Text = string.Empty;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
