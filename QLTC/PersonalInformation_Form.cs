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
        private string? ID;
        DataTable? dtSchedule;
        public PersonalInformation_Form()
        {
            InitializeComponent();
        }
        private void PersonalInformation_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
            ID = Login_Form.cusID;
            if (ID != null)
            {
                userSession();
            }
            loadDataGridView();
            txtID.Enabled = false;
            txtInjected.Enabled = false;
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
            dtp_Birth.Text = DataAccess.getFieldValues(str);
            str = "SELECT gender FROM Customer WHERE cus_id = " + ID;
            cbSex.Text = DataAccess.getFieldValues(str);
            str = "SELECT address FROM Customer WHERE cus_id = " + ID;
            cbxProvince.Text = DataAccess.getFieldValues(str);
            str = "SELECT phonenum FROM Customer WHERE cus_id = " + ID;
            txtPhonenum.Text = DataAccess.getFieldValues(str);
            str = "SELECT status FROM Customer WHERE cus_id = " + ID;
            cbxStatus.Text = DataAccess.getFieldValues(str);
            str = "SELECT injected FROM Customer WHERE cus_id = " + ID;
            txtInjected.Text = DataAccess.getFieldValues(str);
        }
        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT sche.schedule_id, vac.vacname, vac.disease, cen.center_name, intcalen.injection_date1, " +
            "intcalen.injection_date2, intcalen.injection_date3, intcalen.injection_date_repeat, sche.total " +
            "FROM Schedule as sche INNER JOIN Vaccine as vac ON Sche.vac_id = vac.vac_id INNER JOIN Customer as cus ON sche.cus_id = cus.cus_id " +
            "INNER JOIN IntermediacteCalendar as intcalen ON sche.schedule_id = intcalen.schedule_id JOIN Centers as cen " +
            "ON sche.center_id = cen.center_id WHERE sche.cus_id = " + ID;
            dtSchedule = DataAccess.getDataToTable(sql);
            dgvSchedule.DataSource = dtSchedule;
            dgvSchedule.Columns[0].HeaderText = "Schedule ID";
            dgvSchedule.Columns[1].HeaderText = "Vaccine name";
            dgvSchedule.Columns[2].HeaderText = "Disease";
            dgvSchedule.Columns[3].HeaderText = "VFA center";
            dgvSchedule.Columns[4].HeaderText = "First injection date";
            dgvSchedule.Columns[5].HeaderText = "Second injection date";
            dgvSchedule.Columns[6].HeaderText = "Third injection date";
            dgvSchedule.Columns[7].HeaderText = "Repeat injection date";
            dgvSchedule.Columns[8].HeaderText = "Total";
            dgvSchedule.Columns[0].Width = 100;
            dgvSchedule.Columns[1].Width = 300;
            dgvSchedule.Columns[2].Width = 200;
            dgvSchedule.Columns[3].Width = 300;
            dgvSchedule.Columns[4].Width = 100;
            dgvSchedule.Columns[5].Width = 100;
            dgvSchedule.Columns[6].Width = 100;
            dgvSchedule.Columns[7].Width = 100;
            dgvSchedule.Columns[8].Width = 100;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.EditMode = DataGridViewEditMode.EditProgrammatically;
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
            object[] value = { txtName.Text, formattedDateTime, cbSex.Text, cbxProvince.Text, txtPhonenum.Text, cbxStatus.Text, txtInjected.Text, txtID.Text };
            DataAccess.runSQL(sql, name, value);
            MessageBox.Show("Updated successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
