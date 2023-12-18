namespace QLTC
{
    partial class SignUp_Form
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            dtpDate = new DateTimePicker();
            cbSex = new ComboBox();
            label7 = new Label();
            txtPhoneNum = new TextBox();
            btnSignUp = new Button();
            label8 = new Label();
            lbLogIn = new LinkLabel();
            label9 = new Label();
            label10 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cbxProvince = new ComboBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(510, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 35);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 70);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 139);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "FullName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 330);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(721, 330);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 385);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // txtID
            // 
            txtID.Location = new Point(453, 70);
            txtID.Name = "txtID";
            txtID.Size = new Size(249, 27);
            txtID.TabIndex = 6;
            txtID.KeyDown += txtID_KeyDown;
            // 
            // txtName
            // 
            txtName.Location = new Point(453, 136);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 7;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(453, 326);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(110, 27);
            dtpDate.TabIndex = 8;
            dtpDate.KeyDown += dtpDate_KeyDown;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cbSex.Location = new Point(584, 325);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(118, 28);
            cbSex.TabIndex = 9;
            cbSex.Tag = "";
            cbSex.KeyDown += cbSex_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 446);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 11;
            label7.Text = "PhoneNumber";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(456, 443);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(247, 27);
            txtPhoneNum.TabIndex = 12;
            txtPhoneNum.KeyDown += txtPhoneNum_KeyDown;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(518, 498);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 13;
            btnSignUp.Text = "SIGN UP ";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            btnSignUp.KeyDown += btnSignUp_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(423, 543);
            label8.Name = "label8";
            label8.Size = new Size(171, 20);
            label8.TabIndex = 14;
            label8.Text = "Already have an account";
            // 
            // lbLogIn
            // 
            lbLogIn.AutoSize = true;
            lbLogIn.Location = new Point(600, 543);
            lbLogIn.Name = "lbLogIn";
            lbLogIn.Size = new Size(50, 20);
            lbLogIn.TabIndex = 15;
            lbLogIn.TabStop = true;
            lbLogIn.Text = "Log in";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(348, 207);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 16;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(348, 274);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 17;
            label10.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(453, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 27);
            txtEmail.TabIndex = 18;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(453, 271);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(249, 27);
            txtPassword.TabIndex = 19;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Items.AddRange(new object[] { "Hà Nội", "Hồ Chí Minh", "Hải Phòng", "Cần Thơ", "Đà Nẵng", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái", "Quảng Trị" });
            cbxProvince.Location = new Point(453, 388);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(250, 28);
            cbxProvince.TabIndex = 20;
            cbxProvince.KeyDown += cbxProvince_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(721, 70);
            label11.Name = "label11";
            label11.Size = new Size(223, 20);
            label11.TabIndex = 21;
            label11.Text = "Note: Please enter the correct ID";
            // 
            // SignUp_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 572);
            Controls.Add(label11);
            Controls.Add(cbxProvince);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lbLogIn);
            Controls.Add(label8);
            Controls.Add(btnSignUp);
            Controls.Add(txtPhoneNum);
            Controls.Add(label7);
            Controls.Add(cbSex);
            Controls.Add(dtpDate);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp_Form";
            Text = "Sign Up";
            Load += SignUp_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtName;
        private DateTimePicker dtpDate;
        private ComboBox cbSex;
        private Label label7;
        private TextBox txtPhoneNum;
        private Button btnSignUp;
        private Label label8;
        private LinkLabel lbLogIn;
        private Label label9;
        private Label label10;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox cbxProvince;
        private Label label11;
    }
}