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
    }
}