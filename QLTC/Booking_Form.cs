using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTC
{
    public partial class Booking_Form : Form
    {
        private ProvinceDataManager provinceDM;
        private string ID;
        DataTable dtBooking;
        public Booking_Form()
        {
            InitializeComponent();
            provinceDM = new ProvinceDataManager();
        }

        private void Booking_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
            checkIDNull();
            //Detach event
            cbxVacType.SelectedIndexChanged -= cbxVacType_SelectedIndexChange;
            DataAccess.connect();
            LoadProvinces();
            if (ID != null)
            {
                MessageBox.Show(ID);
                userSession();
            }
            else
            {
                adminSession();
            }
            loadDataGridView();
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
            // When choose user ID , all field of User information will fill
            str = "SELECT cus_id FROM Customer WHERE cus_id = " + ID;
            txtID.Text = DataAccess.getFieldValues(str);
            str = "SELECT fullname FROM Customer WHERE cus_id = " + ID;
            txtName.Text = DataAccess.getFieldValues(str);
            str = "SELECT birth FROM Customer WHERE cus_id = " + ID;
            dtpBirth.Text = DataAccess.getFieldValues(str);
            str = "SELECT gender FROM Customer WHERE cus_id = " + ID;
            cbSex.Text = DataAccess.getFieldValues(str);
            str = "SELECT address FROM Customer WHERE cus_id = " + ID;
            cbxAddress.Text = DataAccess.getFieldValues(str);
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

        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT sche.schedule_id, sche.cus_id, sche.vac_id, vac.vacname,disease, vac.producer, sche.injection_date, sche.province, sche.injection_center, vac.price, vac.num_injection FROM Schedule as sche INNER JOIN Vaccine as vac ON Sche.vac_id = vac.vac_id INNER JOIN Customer as cus ON sche.cus_id = cus.cus_id";
            dtBooking = DataAccess.getDataToTable(sql);
            dgvSchedule.DataSource = dtBooking;
            dgvSchedule.Columns[0].HeaderText = "Schedule ID";
            dgvSchedule.Columns[1].HeaderText = "Customer ID";
            dgvSchedule.Columns[2].HeaderText = "Vaccine ID";
            dgvSchedule.Columns[3].HeaderText = "Vaccine name";
            dgvSchedule.Columns[4].HeaderText = "Disease";
            dgvSchedule.Columns[5].HeaderText = "Vaccine Producer";
            dgvSchedule.Columns[6].HeaderText = "Injection date";
            dgvSchedule.Columns[7].HeaderText = "Province";
            dgvSchedule.Columns[8].HeaderText = "VFA center";
            dgvSchedule.Columns[9].HeaderText = "Price";
            dgvSchedule.Columns[10].HeaderText = "Number of injections";
            dgvSchedule.Columns[0].Width = 100;
            dgvSchedule.Columns[1].Width = 300;
            dgvSchedule.Columns[2].Width = 200;
            dgvSchedule.Columns[3].Width = 300;
            dgvSchedule.Columns[4].Width = 200;
            dgvSchedule.Columns[5].Width = 100;
            dgvSchedule.Columns[6].Width = 100;
            dgvSchedule.Columns[7].Width = 100;
            dgvSchedule.Columns[8].Width = 100;
            dgvSchedule.Columns[9].Width = 100;
            dgvSchedule.Columns[10].Width = 100;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.EditMode = DataGridViewEditMode.EditProgrammatically;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtpDateInject.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            if (dtpDateInject.Value == DateTime.MinValue)
            {
                MessageBox.Show("Please select a date to inject!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbxCenterInject.Text == string.Empty)
            {
                MessageBox.Show("Please select a VFA center to inject!", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string addSql;
            int vacId = int.Parse(DataAccess.getFieldValues("SELECT vac_id FROM Vaccine WHERE vacname LIKE N'%" + cbxVacName.SelectedValue.ToString() + "%'"));
            // Call the procedure
            try
            {
                // Your existing code to insert into the Schedule table
                string addSqlSchedule = "INSERT INTO Schedule VALUES(@cus_id, @vac_id, @injection_date, @province, @injection_center)";
                string[] nameSchedule = { "@cus_id", "@vac_id", "@injection_date","@province", "@injection_center" };
                object[] valueSchedule = { txtID.Text, vacId, formattedDateTime, cbxProvince.Text, cbxCenterInject.Text };
                DataAccess.runSQL(addSqlSchedule, nameSchedule, valueSchedule);

                // Call the stored procedure to insert into IntermediacteCalendar

                using (SqlCommand cmd = new SqlCommand("InsertVaccinationSchedule", DataAccess.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameters for the stored procedure
                    cmd.Parameters.AddWithValue("@cus_id", txtID.Text);
                    cmd.Parameters.AddWithValue("@vac_id", vacId); // Replace with the actual vaccine ID
                    cmd.Parameters.AddWithValue("@injection_date", formattedDateTime); // Replace with the actual injection date
                    cmd.Parameters.AddWithValue("@province", cbxProvince.Text);
                    cmd.Parameters.AddWithValue("@injection_center", cbxCenterInject.Text);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Schedule add successfully!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
