namespace QLTC
{
    partial class ScheduleManagement_Form
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
            btnDelete = new Button();
            dgvSchedule = new DataGridView();
            btnUpdate = new Button();
            label1 = new Label();
            btnClose = new Button();
            btnCancel = new Button();
            groupBox2 = new GroupBox();
            txtTotal = new TextBox();
            label15 = new Label();
            cbxScheduleID = new ComboBox();
            label14 = new Label();
            cbxVacType = new ComboBox();
            cbxVacName = new ComboBox();
            cbxCenterInject = new ComboBox();
            cbxProvince = new ComboBox();
            dtpDateInject = new DateTimePicker();
            txtPrice = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label6 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cbxCusID = new ComboBox();
            cbxAddress = new ComboBox();
            label8 = new Label();
            txtPhonenumber = new TextBox();
            label7 = new Label();
            cbSex = new ComboBox();
            dtpBirth = new DateTimePicker();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(208, 685);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(48, 449);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(1084, 230);
            dgvSchedule.TabIndex = 16;
            dgvSchedule.CellContentClick += dgvSchedule_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(393, 685);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(444, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 35);
            label1.TabIndex = 14;
            label1.Text = "Schedule Management";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1038, 685);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(594, 685);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(cbxScheduleID);
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
            groupBox2.Location = new Point(48, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1086, 217);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "SERVICE INFORMATION";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(869, 184);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(180, 27);
            txtTotal.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(749, 187);
            label15.Name = "label15";
            label15.Size = new Size(42, 20);
            label15.TabIndex = 15;
            label15.Text = "Total";
            // 
            // cbxScheduleID
            // 
            cbxScheduleID.FormattingEnabled = true;
            cbxScheduleID.Location = new Point(160, 31);
            cbxScheduleID.Name = "cbxScheduleID";
            cbxScheduleID.Size = new Size(226, 28);
            cbxScheduleID.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 34);
            label14.Name = "label14";
            label14.Size = new Size(88, 20);
            label14.TabIndex = 13;
            label14.Text = "Schedule ID";
            // 
            // cbxVacType
            // 
            cbxVacType.FormattingEnabled = true;
            cbxVacType.Location = new Point(519, 31);
            cbxVacType.Name = "cbxVacType";
            cbxVacType.Size = new Size(188, 28);
            cbxVacType.TabIndex = 11;
            cbxVacType.SelectedIndexChanged += cbxVacType_SelectedIndexChanged;
            // 
            // cbxVacName
            // 
            cbxVacName.FormattingEnabled = true;
            cbxVacName.Location = new Point(869, 26);
            cbxVacName.Name = "cbxVacName";
            cbxVacName.Size = new Size(180, 28);
            cbxVacName.TabIndex = 10;
            cbxVacName.SelectedIndexChanged += cbxVacName_SelectedIndexChanged;
            // 
            // cbxCenterInject
            // 
            cbxCenterInject.FormattingEnabled = true;
            cbxCenterInject.Items.AddRange(new object[] { "VFA Long Xuyên", "VFA Vũng Tàu", "VFA Bắc Giang", "VFA Bắc Kạn", "VFA Bạc Liêu", "VFA Bắc Ninh", "VFA Bến Tre", "VFA Quy Nhơn", "VFA Thủ Dầu Một", "VFA Đồng Xoài", "VFA Phan Thiết", "VFA Cà Mau", "VFA Cao Bằng", "VFA Buôn Ma Thuột", "VFA Gia Nghĩa", "VFA Điện Biên Phủ", "VFA Biên Hòa", "VFA Cao Lãnh", "VFA Pleiku", "VFA Hà Giang", "VFA Phủ Lý", "VFA Hà Tĩnh", "VFA Hải Dương", "VFA Vị Thanh", "VFA Hòa Bình", "VFA Hưng Yên", "VFA Nha Trang", "VFA Rạch Giá", "VFA Kon Tum", "VFA Lai Châu", "VFA Đà Lạt", "VFA Lạng Sơn", "VFA Lào Cai", "VFA Tân An", "VFA Nam Định", "VFA Vinh", "VFA Ninh Bình", "VFA Phan Rang – Tháp Chàm", "VFA Việt Trì", "VFA Tuy Hòa", "VFA Đồng Hới", "VFA Tam Kỳ", "VFA Quảng Ngãi", "VFA Hạ Long", "VFA Đông Hà", "VFA Sóc Trăng", "VFA Sơn La", "VFA Tây Ninh", "VFA Thái Bình", "VFA Thái Nguyên", "VFA Thanh Hóa", "VFA Huế", "VFA Mỹ Tho", "VFA Trà Vinh", "VFA Tuyên Quang", "VFA Vĩnh Long", "VFA Vĩnh Yên", "VFA Yên Bái" });
            cbxCenterInject.Location = new Point(869, 101);
            cbxCenterInject.Name = "cbxCenterInject";
            cbxCenterInject.Size = new Size(180, 28);
            cbxCenterInject.TabIndex = 9;
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Location = new Point(519, 101);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(188, 28);
            cbxProvince.TabIndex = 12;
            // 
            // dtpDateInject
            // 
            dtpDateInject.Location = new Point(160, 104);
            dtpDateInject.Name = "dtpDateInject";
            dtpDateInject.Size = new Size(226, 27);
            dtpDateInject.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(519, 184);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(188, 27);
            txtPrice.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(749, 104);
            label13.Name = "label13";
            label13.Size = new Size(81, 20);
            label13.TabIndex = 4;
            label13.Text = "VFA Center";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 104);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 3;
            label12.Text = "Date inject";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(404, 104);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 4;
            label6.Text = "Province";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(404, 184);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 2;
            label11.Text = "Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(749, 34);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 1;
            label10.Text = "Vaccine Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(404, 34);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 0;
            label9.Text = "Vaccine Type";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxCusID);
            groupBox1.Controls.Add(cbxAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPhonenumber);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbSex);
            groupBox1.Controls.Add(dtpBirth);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(48, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 173);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "INJECTOR INFORMATION";
            // 
            // cbxCusID
            // 
            cbxCusID.FormattingEnabled = true;
            cbxCusID.Location = new Point(64, 29);
            cbxCusID.Name = "cbxCusID";
            cbxCusID.Size = new Size(181, 28);
            cbxCusID.TabIndex = 20;
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
            // btnAdd
            // 
            btnAdd.Location = new Point(48, 685);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ScheduleManagement_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 726);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvSchedule);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ScheduleManagement_Form";
            Text = "Schedule Management";
            Load += ScheduleManagement_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private DataGridView dgvSchedule;
        private Button btnUpdate;
        private Label label1;
        private Button btnClose;
        private Button btnCancel;
        private GroupBox groupBox2;
        private ComboBox cbxVacType;
        private ComboBox cbxVacName;
        private ComboBox cbxCenterInject;
        private ComboBox cbxProvince;
        private DateTimePicker dtpDateInject;
        private TextBox txtPrice;
        private Label label13;
        private Label label12;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox cbxAddress;
        private Label label8;
        private TextBox txtPhonenumber;
        private Label label7;
        private ComboBox cbSex;
        private DateTimePicker dtpBirth;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Button btnAdd;
        private ComboBox cbxScheduleID;
        private Label label14;
        private TextBox txtTotal;
        private Label label15;
        private ComboBox cbxCusID;
    }
}