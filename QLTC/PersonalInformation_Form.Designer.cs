namespace QLTC
{
    partial class PersonalInformation_Form
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvSchedule = new DataGridView();
            gb_PersonalInfor = new GroupBox();
            cbxStatus = new ComboBox();
            cbxProvince = new ComboBox();
            dtp_Birth = new DateTimePicker();
            txtInjected = new TextBox();
            cbSex = new ComboBox();
            txtPhonenum = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            lb_Injected = new Label();
            lb_Status = new Label();
            lb_Phonenum = new Label();
            lb_Address = new Label();
            lb_Sex = new Label();
            lb_Birth = new Label();
            lb_Name = new Label();
            lb_ID = new Label();
            gb_Schedule = new GroupBox();
            btnUpdate = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            gb_PersonalInfor.SuspendLayout();
            gb_Schedule.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(441, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 35);
            label1.TabIndex = 0;
            label1.Text = "Personal Information";
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(5, 24);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(1126, 189);
            dgvSchedule.TabIndex = 2;
            // 
            // gb_PersonalInfor
            // 
            gb_PersonalInfor.Controls.Add(cbxStatus);
            gb_PersonalInfor.Controls.Add(cbxProvince);
            gb_PersonalInfor.Controls.Add(dtp_Birth);
            gb_PersonalInfor.Controls.Add(txtInjected);
            gb_PersonalInfor.Controls.Add(cbSex);
            gb_PersonalInfor.Controls.Add(txtPhonenum);
            gb_PersonalInfor.Controls.Add(txtName);
            gb_PersonalInfor.Controls.Add(txtID);
            gb_PersonalInfor.Controls.Add(lb_Injected);
            gb_PersonalInfor.Controls.Add(lb_Status);
            gb_PersonalInfor.Controls.Add(lb_Phonenum);
            gb_PersonalInfor.Controls.Add(lb_Address);
            gb_PersonalInfor.Controls.Add(lb_Sex);
            gb_PersonalInfor.Controls.Add(lb_Birth);
            gb_PersonalInfor.Controls.Add(lb_Name);
            gb_PersonalInfor.Controls.Add(lb_ID);
            gb_PersonalInfor.Location = new Point(21, 57);
            gb_PersonalInfor.Name = "gb_PersonalInfor";
            gb_PersonalInfor.Size = new Size(1137, 176);
            gb_PersonalInfor.TabIndex = 3;
            gb_PersonalInfor.TabStop = false;
            gb_PersonalInfor.Text = "Personal Information";
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Excellent", "Good", "Fair", "Poor", "Critical" });
            cbxStatus.Location = new Point(659, 131);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(181, 28);
            cbxStatus.TabIndex = 18;
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Location = new Point(81, 130);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(170, 28);
            cbxProvince.TabIndex = 17;
            // 
            // dtp_Birth
            // 
            dtp_Birth.Location = new Point(659, 30);
            dtp_Birth.Name = "dtp_Birth";
            dtp_Birth.Size = new Size(181, 27);
            dtp_Birth.TabIndex = 16;
            // 
            // txtInjected
            // 
            txtInjected.Location = new Point(942, 131);
            txtInjected.Name = "txtInjected";
            txtInjected.Size = new Size(168, 27);
            txtInjected.TabIndex = 15;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbSex.Location = new Point(939, 29);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(168, 28);
            cbSex.TabIndex = 14;
            // 
            // txtPhonenum
            // 
            txtPhonenum.Location = new Point(411, 131);
            txtPhonenum.Name = "txtPhonenum";
            txtPhonenum.Size = new Size(169, 27);
            txtPhonenum.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(407, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 27);
            txtName.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Location = new Point(81, 29);
            txtID.Name = "txtID";
            txtID.Size = new Size(170, 27);
            txtID.TabIndex = 8;
            // 
            // lb_Injected
            // 
            lb_Injected.AutoSize = true;
            lb_Injected.Location = new Point(874, 135);
            lb_Injected.Name = "lb_Injected";
            lb_Injected.Size = new Size(62, 20);
            lb_Injected.TabIndex = 7;
            lb_Injected.Text = "Injected";
            // 
            // lb_Status
            // 
            lb_Status.AutoSize = true;
            lb_Status.Location = new Point(604, 135);
            lb_Status.Name = "lb_Status";
            lb_Status.Size = new Size(49, 20);
            lb_Status.TabIndex = 6;
            lb_Status.Text = "Status";
            // 
            // lb_Phonenum
            // 
            lb_Phonenum.AutoSize = true;
            lb_Phonenum.Location = new Point(287, 135);
            lb_Phonenum.Name = "lb_Phonenum";
            lb_Phonenum.Size = new Size(105, 20);
            lb_Phonenum.TabIndex = 5;
            lb_Phonenum.Text = "Phone number";
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Location = new Point(6, 134);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(62, 20);
            lb_Address.TabIndex = 4;
            lb_Address.Text = "Address";
            // 
            // lb_Sex
            // 
            lb_Sex.AutoSize = true;
            lb_Sex.Location = new Point(876, 35);
            lb_Sex.Name = "lb_Sex";
            lb_Sex.Size = new Size(57, 20);
            lb_Sex.TabIndex = 3;
            lb_Sex.Text = "Gender";
            // 
            // lb_Birth
            // 
            lb_Birth.AutoSize = true;
            lb_Birth.Location = new Point(604, 35);
            lb_Birth.Name = "lb_Birth";
            lb_Birth.Size = new Size(41, 20);
            lb_Birth.TabIndex = 2;
            lb_Birth.Text = "Date";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Location = new Point(318, 36);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(49, 20);
            lb_Name.TabIndex = 1;
            lb_Name.Text = "Name";
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Location = new Point(20, 35);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(24, 20);
            lb_ID.TabIndex = 0;
            lb_ID.Text = "ID";
            // 
            // gb_Schedule
            // 
            gb_Schedule.Controls.Add(dgvSchedule);
            gb_Schedule.Location = new Point(21, 295);
            gb_Schedule.Name = "gb_Schedule";
            gb_Schedule.Size = new Size(1137, 219);
            gb_Schedule.TabIndex = 4;
            gb_Schedule.TabStop = false;
            gb_Schedule.Text = "Personal Schedule";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(26, 249);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(178, 249);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // PersonalInformation_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 518);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(gb_PersonalInfor);
            Controls.Add(gb_Schedule);
            Name = "PersonalInformation_Form";
            Text = "Personal Information";
            Load += PersonalInformation_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            gb_PersonalInfor.ResumeLayout(false);
            gb_PersonalInfor.PerformLayout();
            gb_Schedule.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvSchedule;
        private GroupBox gb_PersonalInfor;
        private GroupBox gb_Schedule;
        private Button btnUpdate;
        private Button btnClose;
        private Label lb_Sex;
        private Label lb_Birth;
        private Label lb_Name;
        private Label lb_ID;
        private Label lb_Status;
        private Label lb_Phonenum;
        private Label lb_Address;
        private TextBox txtInjected;
        private ComboBox cbSex;
        private TextBox txtPhonenum;
        private TextBox txtName;
        private TextBox txtID;
        private Label lb_Injected;
        private DateTimePicker dtp_Birth;
        private ComboBox cbxProvince;
        private ComboBox cbxStatus;
    }
}