namespace QLTC
{
    partial class ReportSchedule_Form
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbxScheduleID = new ComboBox();
            cbxCusID = new ComboBox();
            cbxProvince = new ComboBox();
            cbxCenter = new ComboBox();
            dgvSchedule = new DataGridView();
            btnView = new Button();
            btnClose = new Button();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            txtInjectedVac = new TextBox();
            txtNumPeople = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 35);
            label1.TabIndex = 0;
            label1.Text = "Schedule Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 66);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Schedule ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 66);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "Customer ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 139);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Province";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 139);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "VFA Center";
            // 
            // cbxScheduleID
            // 
            cbxScheduleID.FormattingEnabled = true;
            cbxScheduleID.Location = new Point(125, 58);
            cbxScheduleID.Name = "cbxScheduleID";
            cbxScheduleID.Size = new Size(207, 28);
            cbxScheduleID.TabIndex = 6;
            // 
            // cbxCusID
            // 
            cbxCusID.FormattingEnabled = true;
            cbxCusID.Location = new Point(507, 63);
            cbxCusID.Name = "cbxCusID";
            cbxCusID.Size = new Size(207, 28);
            cbxCusID.TabIndex = 7;
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Location = new Point(125, 136);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(207, 28);
            cbxProvince.TabIndex = 9;
            cbxProvince.SelectedIndexChanged += cbxProvince_SelectedIndexChanged;
            // 
            // cbxCenter
            // 
            cbxCenter.FormattingEnabled = true;
            cbxCenter.Location = new Point(507, 136);
            cbxCenter.Name = "cbxCenter";
            cbxCenter.Size = new Size(207, 28);
            cbxCenter.TabIndex = 10;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(25, 267);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(1093, 237);
            dgvSchedule.TabIndex = 11;
            dgvSchedule.CellContentClick += dgvSchedule_CellContentClick;
            // 
            // btnView
            // 
            btnView.Location = new Point(10, 153);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 12;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1024, 527);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 40);
            label7.Name = "label7";
            label7.Size = new Size(207, 20);
            label7.TabIndex = 14;
            label7.Text = "Number of people vaccinated";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 98);
            label8.Name = "label8";
            label8.Size = new Size(231, 20);
            label8.TabIndex = 15;
            label8.Text = "Number of vaccines administered";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(txtInjectedVac);
            groupBox1.Controls.Add(txtNumPeople);
            groupBox1.Controls.Add(btnView);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(725, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 203);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistical";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(123, 153);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtInjectedVac
            // 
            txtInjectedVac.Location = new Point(262, 98);
            txtInjectedVac.Name = "txtInjectedVac";
            txtInjectedVac.Size = new Size(125, 27);
            txtInjectedVac.TabIndex = 17;
            // 
            // txtNumPeople
            // 
            txtNumPeople.Location = new Point(262, 40);
            txtNumPeople.Name = "txtNumPeople";
            txtNumPeople.Size = new Size(125, 27);
            txtNumPeople.TabIndex = 16;
            // 
            // ReportSchedule_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 568);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(dgvSchedule);
            Controls.Add(cbxCenter);
            Controls.Add(cbxProvince);
            Controls.Add(cbxCusID);
            Controls.Add(cbxScheduleID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportSchedule_Form";
            Text = "Report Schedule";
            Load += ReportSchedule_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbxScheduleID;
        private ComboBox cbxCusID;
        private ComboBox cbxProvince;
        private ComboBox cbxCenter;
        private DataGridView dgvSchedule;
        private Button btnView;
        private Button btnClose;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private Button btnRefresh;
        private TextBox txtInjectedVac;
        private TextBox txtNumPeople;
    }
}