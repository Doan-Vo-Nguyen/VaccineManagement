namespace QLTC
{
    partial class Home_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            menuStrip1 = new MenuStrip();
            tslFile = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            tslExit = new ToolStripMenuItem();
            tslBooking = new ToolStripMenuItem();
            tslVaccineInfor = new ToolStripMenuItem();
            tslPersonalInfor = new ToolStripMenuItem();
            tslManagement = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            vaccineToolStripMenuItem = new ToolStripMenuItem();
            tslReport = new ToolStripMenuItem();
            tsmiStock = new ToolStripMenuItem();
            tsmiSchedule = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tslFile, tslBooking, tslVaccineInfor, tslPersonalInfor, tslManagement, tslReport });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1128, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tslFile
            // 
            tslFile.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, tslExit });
            tslFile.Name = "tslFile";
            tslFile.Size = new Size(46, 24);
            tslFile.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(145, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // tslExit
            // 
            tslExit.Name = "tslExit";
            tslExit.Size = new Size(145, 26);
            tslExit.Text = "Exit";
            tslExit.Click += tslExit_Click;
            // 
            // tslBooking
            // 
            tslBooking.Name = "tslBooking";
            tslBooking.Size = new Size(78, 24);
            tslBooking.Text = "Booking";
            tslBooking.Click += tslBooking_Click;
            // 
            // tslVaccineInfor
            // 
            tslVaccineInfor.Name = "tslVaccineInfor";
            tslVaccineInfor.Size = new Size(73, 24);
            tslVaccineInfor.Text = "Vaccine";
            tslVaccineInfor.Click += tslVaccineInfor_Click;
            // 
            // tslPersonalInfor
            // 
            tslPersonalInfor.Name = "tslPersonalInfor";
            tslPersonalInfor.Size = new Size(160, 24);
            tslPersonalInfor.Text = "Personal Information";
            tslPersonalInfor.Click += tslPersonalInfor_Click;
            // 
            // tslManagement
            // 
            tslManagement.DropDownItems.AddRange(new ToolStripItem[] { customerToolStripMenuItem, vaccineToolStripMenuItem, scheduleToolStripMenuItem });
            tslManagement.Name = "tslManagement";
            tslManagement.Size = new Size(111, 24);
            tslManagement.Text = "Management";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(224, 26);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // vaccineToolStripMenuItem
            // 
            vaccineToolStripMenuItem.Name = "vaccineToolStripMenuItem";
            vaccineToolStripMenuItem.Size = new Size(224, 26);
            vaccineToolStripMenuItem.Text = "Vaccine";
            vaccineToolStripMenuItem.Click += vaccineToolStripMenuItem_Click;
            // 
            // tslReport
            // 
            tslReport.DropDownItems.AddRange(new ToolStripItem[] { tsmiStock, tsmiSchedule });
            tslReport.Name = "tslReport";
            tslReport.Size = new Size(68, 24);
            tslReport.Text = "Report";
            // 
            // tsmiStock
            // 
            tsmiStock.Name = "tsmiStock";
            tsmiStock.Size = new Size(224, 26);
            tsmiStock.Text = "Stock";
            tsmiStock.Click += stockToolStripMenuItem_Click;
            // 
            // tsmiSchedule
            // 
            tsmiSchedule.Name = "tsmiSchedule";
            tsmiSchedule.Size = new Size(224, 26);
            tsmiSchedule.Text = "Schedule";
            tsmiSchedule.Click += tsmiSchedule_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(50, 280);
            label1.Name = "label1";
            label1.Size = new Size(393, 58);
            label1.TabIndex = 1;
            label1.Text = "Welcome to VFA";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(224, 26);
            scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // Home_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1128, 474);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home_Form";
            Text = "Home";
            Load += Home_Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tslFile;
        private ToolStripMenuItem tslExit;
        private ToolStripMenuItem tslBooking;
        private ToolStripMenuItem tslVaccineInfor;
        private ToolStripMenuItem tslPersonalInfor;
        private ToolStripMenuItem tslReport;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem tsmiStock;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem tsmiSchedule;
        private ToolStripMenuItem tslManagement;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem vaccineToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
    }
}