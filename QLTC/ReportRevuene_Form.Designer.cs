namespace QLTC
{
    partial class ReportRevuene_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefresh = new Button();
            txtTotalRevuene = new TextBox();
            groupBox1 = new GroupBox();
            btnView = new Button();
            label7 = new Label();
            btnClose = new Button();
            dgvRevuene = new DataGridView();
            cbxCenter = new ComboBox();
            cbxScheduleID = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            dtpStartDay = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            cbxQuarter = new ComboBox();
            cbxProvince = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevuene).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(132, 163);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtTotalRevuene
            // 
            txtTotalRevuene.Location = new Point(132, 37);
            txtTotalRevuene.Name = "txtTotalRevuene";
            txtTotalRevuene.Size = new Size(239, 27);
            txtTotalRevuene.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(txtTotalRevuene);
            groupBox1.Controls.Add(btnView);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(736, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 210);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistical";
            // 
            // btnView
            // 
            btnView.Location = new Point(14, 163);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 12;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 40);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 14;
            label7.Text = "Total Revuene";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1035, 536);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvRevuene
            // 
            dgvRevuene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevuene.Location = new Point(36, 278);
            dgvRevuene.Name = "dgvRevuene";
            dgvRevuene.RowHeadersWidth = 51;
            dgvRevuene.RowTemplate.Height = 29;
            dgvRevuene.Size = new Size(1093, 237);
            dgvRevuene.TabIndex = 28;
            dgvRevuene.CellContentClick += dgvRevuene_CellContentClick;
            // 
            // cbxCenter
            // 
            cbxCenter.FormattingEnabled = true;
            cbxCenter.Location = new Point(518, 74);
            cbxCenter.Name = "cbxCenter";
            cbxCenter.Size = new Size(207, 28);
            cbxCenter.TabIndex = 26;
            // 
            // cbxScheduleID
            // 
            cbxScheduleID.FormattingEnabled = true;
            cbxScheduleID.Location = new Point(136, 69);
            cbxScheduleID.Name = "cbxScheduleID";
            cbxScheduleID.Size = new Size(207, 28);
            cbxScheduleID.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 74);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 22;
            label6.Text = "VFA Center";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 155);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 21;
            label5.Text = "Province";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 235);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 20;
            label4.Text = "End date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 235);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 19;
            label3.Text = "Start day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 77);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 18;
            label2.Text = "Schedule ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(428, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 17;
            label1.Text = "Revuene Report";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 155);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 31;
            label8.Text = "Quarter";
            // 
            // dtpStartDay
            // 
            dtpStartDay.Location = new Point(136, 235);
            dtpStartDay.Name = "dtpStartDay";
            dtpStartDay.Size = new Size(207, 27);
            dtpStartDay.TabIndex = 37;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(518, 235);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(207, 27);
            dtpEndDate.TabIndex = 36;
            // 
            // cbxQuarter
            // 
            cbxQuarter.FormattingEnabled = true;
            cbxQuarter.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbxQuarter.Location = new Point(136, 152);
            cbxQuarter.Name = "cbxQuarter";
            cbxQuarter.Size = new Size(207, 28);
            cbxQuarter.TabIndex = 34;
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Location = new Point(518, 152);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(207, 28);
            cbxProvince.TabIndex = 35;
            cbxProvince.SelectedIndexChanged += cbxProvince_SelectedIndexChanged;
            // 
            // ReportRevuene_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 586);
            Controls.Add(cbxProvince);
            Controls.Add(cbxQuarter);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDay);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(dgvRevuene);
            Controls.Add(cbxCenter);
            Controls.Add(cbxScheduleID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportRevuene_Form";
            Text = "Report Revuene";
            Load += ReportRevuene_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevuene).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private TextBox txtTotalRevuene;
        private GroupBox groupBox1;
        private Button btnView;
        private Label label7;
        private Button btnClose;
        private DataGridView dgvRevuene;
        private ComboBox cbxCenter;
        private ComboBox cbxScheduleID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private DateTimePicker dtpStartDay;
        private DateTimePicker dtpEndDate;
        private ComboBox cbxQuarter;
        private ComboBox cbxProvince;
    }
}