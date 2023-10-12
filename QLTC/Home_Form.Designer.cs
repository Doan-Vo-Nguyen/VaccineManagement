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
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tslIntroduction = new ToolStripMenuItem();
            tslBooking = new ToolStripMenuItem();
            tslPriceList = new ToolStripMenuItem();
            tslReport = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, tslIntroduction, tslBooking, tslPriceList, tslReport });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1128, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // tslIntroduction
            // 
            tslIntroduction.Name = "tslIntroduction";
            tslIntroduction.Size = new Size(104, 24);
            tslIntroduction.Text = "Introduction";
            // 
            // tslBooking
            // 
            tslBooking.Name = "tslBooking";
            tslBooking.Size = new Size(78, 24);
            tslBooking.Text = "Booking";
            tslBooking.Click += tslBooking_Click;
            // 
            // tslPriceList
            // 
            tslPriceList.Name = "tslPriceList";
            tslPriceList.Size = new Size(73, 24);
            tslPriceList.Text = "Vaccine";
            // 
            // tslReport
            // 
            tslReport.Name = "tslReport";
            tslReport.Size = new Size(68, 24);
            tslReport.Text = "Report";
            // 
            // Home_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1128, 474);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home_Form";
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem tslIntroduction;
        private ToolStripMenuItem tslBooking;
        private ToolStripMenuItem tslPriceList;
        private ToolStripMenuItem tslReport;
    }
}