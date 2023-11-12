namespace QLTC
{
    partial class CustomerManagement_Form
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
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbxID = new ComboBox();
            txtFullname = new TextBox();
            dtpBirth = new DateTimePicker();
            cbxGender = new ComboBox();
            cbxAddress = new ComboBox();
            txtPhonenumber = new TextBox();
            txtInjected = new TextBox();
            cbxStatus = new ComboBox();
            dgvCustomer = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(403, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 35);
            label1.TabIndex = 0;
            label1.Text = "Customer Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 179);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 79);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Full name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 79);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 79);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 4;
            label5.Text = "Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(856, 79);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 181);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 6;
            label7.Text = "Phone number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(578, 181);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 7;
            label8.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(851, 177);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 8;
            label9.Text = "Injected";
            // 
            // cbxID
            // 
            cbxID.FormattingEnabled = true;
            cbxID.Location = new Point(82, 76);
            cbxID.Name = "cbxID";
            cbxID.Size = new Size(200, 28);
            cbxID.TabIndex = 9;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(399, 78);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(173, 27);
            txtFullname.TabIndex = 10;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(639, 76);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(182, 27);
            dtpBirth.TabIndex = 11;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbxGender.Location = new Point(929, 76);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(172, 28);
            cbxGender.TabIndex = 12;
            // 
            // cbxAddress
            // 
            cbxAddress.FormattingEnabled = true;
            cbxAddress.Location = new Point(82, 173);
            cbxAddress.Name = "cbxAddress";
            cbxAddress.Size = new Size(200, 28);
            cbxAddress.TabIndex = 13;
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(399, 178);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new Size(173, 27);
            txtPhonenumber.TabIndex = 14;
            // 
            // txtInjected
            // 
            txtInjected.Location = new Point(936, 174);
            txtInjected.Name = "txtInjected";
            txtInjected.Size = new Size(165, 27);
            txtInjected.TabIndex = 15;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Excellent", "Good", "Fair", "Poor", "Critical" });
            cbxStatus.Location = new Point(640, 173);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(181, 28);
            cbxStatus.TabIndex = 16;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(14, 230);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(1110, 264);
            dgvCustomer.TabIndex = 17;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(188, 527);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(380, 527);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1030, 527);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 527);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // CustomerManagement_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 568);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvCustomer);
            Controls.Add(cbxStatus);
            Controls.Add(txtInjected);
            Controls.Add(txtPhonenumber);
            Controls.Add(cbxAddress);
            Controls.Add(cbxGender);
            Controls.Add(dtpBirth);
            Controls.Add(txtFullname);
            Controls.Add(cbxID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerManagement_Form";
            Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbxID;
        private TextBox txtFullname;
        private DateTimePicker dtpBirth;
        private ComboBox cbxGender;
        private ComboBox cbxAddress;
        private TextBox txtPhonenumber;
        private TextBox txtInjected;
        private ComboBox cbxStatus;
        private DataGridView dgvCustomer;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Button btnAdd;
    }
}