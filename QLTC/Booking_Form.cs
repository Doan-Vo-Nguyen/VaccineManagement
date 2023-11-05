using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTC
{
    public partial class Booking_Form : Form
    {
        private ProvinceDataManager provinceDM;
        private string ID;
        public Booking_Form()
        {
            InitializeComponent();
            provinceDM = new ProvinceDataManager();
        }

        private void Booking_Form_Load(object sender, EventArgs e)
        {
            checkIDNull();
            //Detach event
            cbxVacType.SelectedIndexChanged -= cbxVacType_SelectedIndexChange;
            DataAccess.connect();
            LoadProvinces();
            if(ID != null)
            {
                MessageBox.Show(ID);
                userSession();
            }
            else
            {
                adminSession();
            }    
            txtID.Enabled = false;
            //Detach event
            cbxVacType.SelectedIndexChanged += cbxVacType_SelectedIndexChange;
        }

        private void LoadProvinces()
        {
            var provinces = provinceDM.GetProvinces();
            cbxProvince.Items.Clear();
            foreach (var province in provinces)
            {
                cbxProvince.Items.Add(province.Name);
            }
        }

        private void userSession()
        {
            string str;
            MessageBox.Show(ID);
            // When choose user ID , all field of User information will fill
            str = "SELECT cus_id FROM Customer WHERE cus_id = " + ID;
            txtID.Text = DataAccess.getFieldValues(str);
            str = "SELECT fullname FROM Customer WHERE cus_id = " + ID;
            txtName.Text = DataAccess.getFieldValues(str);
            str = "SELECT birth FROM Customer WHERE cus_id = " + ID;
            dtpBirth.Text = DataAccess.getFieldValues(str);
            str = "SELECT gender FROM Customer WHERE cus_id = " + ID;
            cbSex.Text = DataAccess.getFieldValues(str);
            str = "SELECT phonenum FROM Customer WHERE cus_id = " + ID;
            txtPhonenumber.Text = DataAccess.getFieldValues(str);
            DataAccess.fillDataCombo("SELECT DISTINCT disease FROM Vaccine", cbxVacType, "disease", "disease");
            cbxVacType.SelectedIndex = 0;
            DataAccess.fillDataCombo("SELECT vacname FROM Vaccine WHERE disease LIKE N'%" + cbxVacType.SelectedValue.ToString() + "%'", cbxVacName, "vacname", "vacname");
            cbxVacName.SelectedIndex = 0;
            MessageBox.Show(cbxVacType.Text);
            MessageBox.Show(cbxVacName.Text);
        }

        private void adminSession()
        {
            string str;
            str = "SELECT cus_id FROM Customer";
            txtID.Text = DataAccess.getFieldValues(str);
            str = "SELECT fullname FROM Customer";
            txtName.Text = DataAccess.getFieldValues(str);
            str = "SELECT birth FROM Customer";
            dtpBirth.Text = DataAccess.getFieldValues(str);
            str = "SELECT gender FROM Customer";
            cbSex.Text = DataAccess.getFieldValues(str);
            str = "SELECT phonenum FROM Customer";
            txtPhonenumber.Text = DataAccess.getFieldValues(str);
            DataAccess.fillDataCombo("SELECT DISTINCT disease FROM Vaccine", cbxVacType, "disease", "disease");
            cbxVacType.SelectedIndex = 0;
            DataAccess.fillDataCombo("SELECT vacname FROM Vaccine WHERE disease LIKE N'%" + cbxVacType.SelectedValue.ToString() + "%'", cbxVacName, "vacname", "vacname");
            cbxVacName.SelectedIndex = 0;
        }
        // Chọn tỉnh thì trung tâm sẽ thay đổi theo tỉnh đã chọn
        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvince = cbxProvince.SelectedItem.ToString();
            var centers = provinceDM.GetVaccineCentersByProvince(selectedProvince);

            // Clear the existing items in the centerComboBox
            cbxCenterInject.Items.Clear();

            // Add the names of the vaccine centers to the ComboBox
            foreach (var center in centers)
            {
                cbxCenterInject.Items.Add(center.Name);
            }
        }

        private void cbxVacType_SelectedIndexChange(object sender, EventArgs e)
        {
            string str;
            if (cbxVacType.Text == "")
            {
                //cbxVacName.Text = "";
                txtPrice.Text = "";
            }
            // When choose Vac type  , all field of SERVICE INFORMATION will fill
            DataAccess.fillDataCombo("SELECT vacname FROM Vaccine WHERE disease LIKE N'%" + cbxVacType.SelectedValue.ToString() + "%'", cbxVacName, "vacname", "vacname");
        }

        private void cbxVacName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbxVacName.Text != "")
            {
                str = "SELECT price FROM Vaccine WHERE vacname LIKE N'%" + cbxVacName.SelectedValue.ToString() + "%'";
                txtPrice.Text = DataAccess.getFieldValues(str);
            }
            else
            {
                MessageBox.Show("Choose vaccine name!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkIDNull()
        {
            ID = Login_Form.cusID.ToString();
            MessageBox.Show(ID);
            if (ID != null)
            {
                ID = Login_Form.cusID.ToString();
            }
            else
            {
                ID = "";
            }

        }
    }
}
