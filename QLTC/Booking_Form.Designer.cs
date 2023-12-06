namespace QLTC
{
    partial class Booking_Form
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
            groupBox1 = new GroupBox();
            cbxAddress = new ComboBox();
            label8 = new Label();
            txtPhonenumber = new TextBox();
            label7 = new Label();
            cbSex = new ComboBox();
            dtpBirth = new DateTimePicker();
            txtName = new TextBox();
            txtID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbxProvince = new ComboBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            cbxScheduleID = new ComboBox();
            label15 = new Label();
            txtTotal = new TextBox();
            label14 = new Label();
            cbxVacType = new ComboBox();
            cbxVacName = new ComboBox();
            cbxCenterInject = new ComboBox();
            dtpDateInject = new DateTimePicker();
            txtPrice = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            btnClose = new Button();
            label1 = new Label();
            btnUpdate = new Button();
            dgvSchedule = new DataGridView();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPhonenumber);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbSex);
            groupBox1.Controls.Add(dtpBirth);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1069, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "INJECTOR INFORMATION";
            // 
            // cbxAddress
            // 
            cbxAddress.FormattingEnabled = true;
            cbxAddress.Location = new Point(844, 26);
            cbxAddress.Name = "cbxAddress";
            cbxAddress.Size = new Size(181, 28);
            cbxAddress.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(703, 33);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 18;
            label8.Text = "Address";
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(844, 105);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new Size(181, 27);
            txtPhonenumber.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(703, 108);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 16;
            label7.Text = "Phone number";
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Location = new Point(64, 105);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(181, 28);
            cbSex.TabIndex = 15;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(440, 103);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(190, 27);
            dtpBirth.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(440, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 27);
            txtName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(64, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(181, 27);
            txtID.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 33);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 3;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 108);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 2;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 110);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 33);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Fullname";
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Location = new Point(498, 117);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(180, 28);
            cbxProvince.TabIndex = 12;
            cbxProvince.SelectedIndexChanged += cbxProvince_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 125);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 4;
            label6.Text = "Province";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxScheduleID);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(cbxVacType);
            groupBox2.Controls.Add(cbxVacName);
            groupBox2.Controls.Add(cbxCenterInject);
            groupBox2.Controls.Add(cbxProvince);
            groupBox2.Controls.Add(dtpDateInject);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(31, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1069, 225);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "SERVICE INFORMATION";
            // 
            // cbxScheduleID
            // 
            cbxScheduleID.FormattingEnabled = true;
            cbxScheduleID.Location = new Point(186, 35);
            cbxScheduleID.Name = "cbxScheduleID";
            cbxScheduleID.Size = new Size(196, 28);
            cbxScheduleID.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(64, 46);
            label15.Name = "label15";
            label15.Size = new Size(88, 20);
            label15.TabIndex = 15;
            label15.Text = "Schedule ID";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(883, 192);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(180, 27);
            txtTotal.TabIndex = 14;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(713, 195);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 13;
            label14.Text = "Total";
            // 
            // cbxVacType
            // 
            cbxVacType.FormattingEnabled = true;
            cbxVacType.Location = new Point(498, 35);
            cbxVacType.Name = "cbxVacType";
            cbxVacType.Size = new Size(180, 28);
            cbxVacType.TabIndex = 11;
            cbxVacType.SelectedIndexChanged += cbxVacType_SelectedIndexChange;
            // 
            // cbxVacName
            // 
            cbxVacName.FormattingEnabled = true;
            cbxVacName.Location = new Point(883, 38);
            cbxVacName.Name = "cbxVacName";
            cbxVacName.Size = new Size(180, 28);
            cbxVacName.TabIndex = 10;
            cbxVacName.SelectedIndexChanged += cbxVacName_SelectedIndexChanged;
            // 
            // cbxCenterInject
            // 
            cbxCenterInject.FormattingEnabled = true;
            cbxCenterInject.Location = new Point(883, 117);
            cbxCenterInject.Name = "cbxCenterInject";
            cbxCenterInject.Size = new Size(180, 28);
            cbxCenterInject.TabIndex = 9;
            // 
            // dtpDateInject
            // 
            dtpDateInject.Location = new Point(186, 120);
            dtpDateInject.Name = "dtpDateInject";
            dtpDateInject.Size = new Size(196, 27);
            dtpDateInject.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(498, 192);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 27);
            txtPrice.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(696, 125);
            label13.Name = "label13";
            label13.Size = new Size(181, 20);
            label13.TabIndex = 4;
            label13.Text = "VFA Center wants to inject";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 125);
            label12.Name = "label12";
            label12.Size = new Size(178, 20);
            label12.TabIndex = 3;
            label12.Text = "Desired date for injection";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(404, 195);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 2;
            label11.Text = "Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(696, 38);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 1;
            label10.Text = "Vaccine Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(388, 38);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 0;
            label9.Text = "Vaccine Type";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(31, 648);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(529, 648);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1006, 648);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(387, 10);
            label1.Name = "label1";
            label1.Size = new Size(361, 35);
            label1.TabIndex = 5;
            label1.Text = "REGISTER FOR VACCINATION";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(356, 648);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(32, 458);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(1069, 162);
            dgvSchedule.TabIndex = 7;
            dgvSchedule.CellContentClick += dgvSchedule_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(197, 648);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Booking_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 689);
            Controls.Add(btnDelete);
            Controls.Add(dgvSchedule);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Booking_Form";
            Text = "Booking";
            Load += Booking_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnOK;
        private Button btnCancel;
        private Button btnClose;
        private Label label1;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbxProvince;
        private DateTimePicker dtpBirth;
        private TextBox txtName;
        private ComboBox cbSex;
        private Label label9;
        private ComboBox cbxCenterInject;
        private DateTimePicker dtpDateInject;
        private TextBox txtPrice;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnUpdate;
        private DataGridView dgvSchedule;
        private Button btnDelete;
        private TextBox txtPhonenumber;
        private Label label7;
        private ComboBox cbxVacName;
        private ComboBox cbxVacType;
        private ComboBox cbxAddress;
        private Label label8;
        private TextBox txtTotal;
        private Label label14;
        private ComboBox cbxScheduleID;
        private Label label15;
    }
}