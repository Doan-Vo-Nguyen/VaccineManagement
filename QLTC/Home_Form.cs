namespace QLTC
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
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
    }
}