using Microsoft.VisualBasic;
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
    public partial class PersonalInformation_Form : Form
    {
        private string ID;
        public PersonalInformation_Form()
        {
            InitializeComponent();
        }

        private void PersonalInformation_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
            
            txtID.Enabled = false;
            txtInjected.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userSession()
        {
            string str;
            // When choose user ID , all field of User information will 
            MessageBox.Show(ID);
            // When choose user ID , all field of User information will fill
            str = "SELECT cus_id FROM Customer WHERE cus_id = " + ID;
            txtID.Text = DataAccess.getFieldValues(str);
            str = "SELECT fullname FROM Customer WHERE cus_id = " + ID;
            txtName.Text = DataAccess.getFieldValues(str);
            str = "SELECT birth FROM Customer WHERE cus_id = " + ID;
            dtp_Birth.Text = DataAccess.getFieldValues(str);
            str = "SELECT gender FROM Customer WHERE cus_id = " + ID;
            cbSex.Text = DataAccess.getFieldValues(str);
            str = "SELECT phonenum FROM Customer WHERE cus_id = " + ID;
            txtPhonenum.Text = DataAccess.getFieldValues(str);
            str = "SELECT status FROM Customer WHERE cus_id = " + ID;
            txtStatus.Text = DataAccess.getFieldValues(str);
            str = "SELECT injected FROM Customer WHERE cus_id = " + ID;
            txtInjected.Text = DataAccess.getFieldValues(str);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtp_Birth.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            DataAccess.connect();
            string sql;
            sql = "UPDATE Customer SET fullname = @name, birth = @birth, gender = @gender, address = @address, phonenum = @phonenum, status = @status, injected = @injected WHERE cus_id = @id";
            string[] name = { "@name", "@birth", "@gender", "@address", "@phonenum", "@status", "injected", "id" };
            object[] value = { txtName.Text, formattedDateTime, cbSex.Text, txtAddress.Text, txtPhonenum.Text, txtStatus.Text, txtInjected.Text, txtID.Text };
            DataAccess.runSQL(sql, name, value);
            MessageBox.Show("Updated successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
