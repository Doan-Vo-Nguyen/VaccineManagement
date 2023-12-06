using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class Login_Form : Form
    {
        public static string? sqlcusID;
        public static string? cusID;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            sqlcusID = "";
            cusID = "";
            if (txtEmail.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                string logincus_sql = "SELECT * FROM Account WHERE email = '" + txtEmail.Text + "' AND password = '" + txtPassword.Text + "'";
                string loginadmin_sql = "SELECT * FROM Admin WHERE email = '" + txtEmail.Text + "' AND password = '" + txtPassword.Text + "'";
                // check if exist
                if (DataAccess.checkKey(logincus_sql))
                {
                    sqlcusID = "SELECT cus_id FROM Account WHERE email = '" + txtEmail.Text + "' AND password = '" + txtPassword.Text + "'";
                    cusID = DataAccess.getFieldValues(sqlcusID);
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Home_Form home_Form = new Home_Form();
                    home_Form.ShowDialog();
                }
                else if (DataAccess.checkKey(loginadmin_sql))
                {
                    string adminName_sql = "SELECT admin_name FROM Admin WHERE email = '" + txtEmail.Text + "' AND password = '" + txtPassword.Text + "'";
                    string adminName = DataAccess.getFieldValues(adminName_sql);
                    MessageBox.Show("Login successful! Welcome back admin " + adminName + "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Home_Form home_Form = new Home_Form();
                    home_Form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login fail!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtEmail.Text == string.Empty && txtPassword.Text != string.Empty)
            {
                MessageBox.Show("Please fill the email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPassword.Text == string.Empty && txtEmail.Text != string.Empty)
            {
                MessageBox.Show("Please fill the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_Form signUp_Form = new SignUp_Form();
            signUp_Form.ShowDialog();
        }

        private void btnLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }
    }
}
