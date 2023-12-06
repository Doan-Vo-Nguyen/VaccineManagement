using System.Data.SqlTypes;

namespace QLTC
{
    public partial class Home_Form : Form
    {
        private string? ID;
        public Home_Form()
        {

            InitializeComponent();

        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            ID = Login_Form.cusID?.ToString();
            if (ID != null)
            {
                ID = Login_Form.cusID?.ToString();
            }
            updateUIForRole();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tslBooking_Click(object sender, EventArgs e)
        {
            Booking_Form bookingForm = new Booking_Form();
            bookingForm.ShowDialog();
        }

        private void tslPersonalInfor_Click(object sender, EventArgs e)
        {
            PersonalInformation_Form perInfor = new PersonalInformation_Form();
            perInfor.ShowDialog();
        }

        private void tslVaccineInfor_Click(object sender, EventArgs e)
        {
            Vaccine_Form vaccineForm = new Vaccine_Form();
            vaccineForm.ShowDialog();
        }

        private void tslExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID = null;
            this.Close();
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportStock_Form reportStock_Form = new ReportStock_Form();
            reportStock_Form.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagement_Form personalManagement = new CustomerManagement_Form();
            personalManagement.ShowDialog();
        }

        private void vaccineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VaccineManagement vaccineManagement = new VaccineManagement();
            vaccineManagement.ShowDialog();
        }

        private void tsmiSchedule_Click(object sender, EventArgs e)
        {
            ReportSchedule_Form reportSchedule_Form = new ReportSchedule_Form();
            reportSchedule_Form.ShowDialog();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleManagement_Form scheduleManagement_Form = new ScheduleManagement_Form();
            scheduleManagement_Form.ShowDialog();
        }

        private void revueneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportRevuene_Form reportRevuene_Form = new ReportRevuene_Form();
            reportRevuene_Form.ShowDialog();
        }
        private void updateUIForRole()
        {
            if (ID != String.Empty)
            {
                ID = Login_Form.cusID?.ToString();
                string sqlcusID = "SELECT * FROM Account WHERE cus_id = '" + ID + "'";
                if (DataAccess.checkKey(sqlcusID))
                {

                    tslFile.Visible = true;
                    tslVaccineInfor.Visible = true;
                    tslBooking.Visible = true;
                    tslPersonalInfor.Visible = true;
                    tslReport.Visible = false;
                    tslManagement.Visible = false;
                }
            }
            else
            {
                tslFile.Visible = true;
                tslVaccineInfor.Visible = false;
                tslBooking.Visible = false;
                tslManagement.Visible = true;
                tslPersonalInfor.Visible = false;
                tslReport.Visible = true;
                tslManagement.Visible = true;
            }
        }
    }
}