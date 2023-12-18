namespace QLTC
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lbSignUp = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(308, 148);
            label1.Name = "label1";
            label1.Size = new Size(355, 35);
            label1.TabIndex = 0;
            label1.Text = "LOG IN WITH VFA ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 213);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 333);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(427, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 27);
            txtEmail.TabIndex = 3;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(427, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(212, 27);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(467, 424);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(105, 29);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "LOG IN NOW";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            btnLogIn.KeyDown += btnLogIn_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(490, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 62);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 535);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account";
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.Location = new Point(578, 535);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(61, 20);
            lbSignUp.TabIndex = 8;
            lbSignUp.TabStop = true;
            lbSignUp.Text = "Sign Up";
            lbSignUp.LinkClicked += lbSignUp_LinkClicked;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 570);
            Controls.Add(lbSignUp);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_Form";
            Text = "Login";
            Load += Login_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogIn;
        private PictureBox pictureBox1;
        private Label label4;
        private LinkLabel lbSignUp;
    }
}