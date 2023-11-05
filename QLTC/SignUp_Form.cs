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
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtpDate.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = string.Format("SELECT count(*) from Customer WHERE cus_id ='{0}'", txtID.Text);
            if (txtName.Text != string.Empty && cbSex.Text != string.Empty && cbxProvince.Text != string.Empty)
            {

                if (DataAccess.executeScalar(sql) == 0)
                {
                    string sql_add = "INSERT INTO Customer(cus_id, fullname ,birth, gender, address, phonenum, status, injected) VALUES(@id, @fullname, @birth ,@gender, @address, @phoneNum, @status, @injected)";
                    string[] name = { "@id", "@fullname", "@birth", "@gender", "@address", "@phoneNum", "@status", "@injected" };
                    object[] value = { txtID.Text, txtName.Text, formattedDateTime, cbSex.Text, cbxProvince.Text, txtPhoneNum.Text, "Empty", 0 };
                    DataAccess.runSQL(sql_add, name, value);
                    // get id from the user just added
                    string sql_addAccount = "INSERT INTO Account(cus_id, email, password) VALUES(@cus_id, @email, @password)";
                    string[] nameAccount = { "@cus_id", "@email", "@password" };
                    object[] valueAccount = { txtID.Text, txtEmail.Text, txtPassword.Text };
                    DataAccess.runSQL(sql_addAccount, nameAccount, valueAccount);
                    MessageBox.Show("Signup successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login_Form login_Form = new Login_Form();
                    login_Form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User have already existed!Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
        }
    }
}
