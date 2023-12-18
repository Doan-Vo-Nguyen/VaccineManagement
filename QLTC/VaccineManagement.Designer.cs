namespace QLTC
{
    partial class VaccineManagement
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
            btnSearch = new Button();
            btnExit = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvVacInfor = new DataGridView();
            txtPrice = new TextBox();
            txtVacProc = new TextBox();
            txtVacName = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtBatch = new TextBox();
            label9 = new Label();
            dtpMFG = new DateTimePicker();
            dtpExpiry = new DateTimePicker();
            groupBox1 = new GroupBox();
            label11 = new Label();
            txtDisInject = new TextBox();
            txtNumInject = new TextBox();
            label10 = new Label();
            cbxDisease = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvVacInfor).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(529, 533);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1061, 533);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 34;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(715, 533);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Refresh";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(339, 533);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(173, 533);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 533);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvVacInfor
            // 
            dgvVacInfor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacInfor.Location = new Point(12, 266);
            dgvVacInfor.Name = "dgvVacInfor";
            dgvVacInfor.RowHeadersWidth = 51;
            dgvVacInfor.RowTemplate.Height = 29;
            dgvVacInfor.Size = new Size(1143, 261);
            dgvVacInfor.TabIndex = 29;
            dgvVacInfor.CellContentClick += dgvVacInfor_CellContentClick;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(95, 176);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(167, 27);
            txtPrice.TabIndex = 28;
            // 
            // txtVacProc
            // 
            txtVacProc.Location = new Point(971, 34);
            txtVacProc.Name = "txtVacProc";
            txtVacProc.Size = new Size(163, 27);
            txtVacProc.TabIndex = 27;
            // 
            // txtVacName
            // 
            txtVacName.Location = new Point(384, 34);
            txtVacName.Name = "txtVacName";
            txtVacName.Size = new Size(165, 27);
            txtVacName.TabIndex = 25;
            // 
            // txtID
            // 
            txtID.Location = new Point(95, 34);
            txtID.Name = "txtID";
            txtID.Size = new Size(167, 27);
            txtID.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 179);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 23;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(843, 37);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 22;
            label5.Text = "Vaccine Producer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 37);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 21;
            label4.Text = "Vaccine Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 37);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 20;
            label3.Text = "Vaccine name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 19;
            label2.Text = "Vaccine ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(458, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 35);
            label1.TabIndex = 18;
            label1.Text = "Vaccine Management";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 104);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 36;
            label7.Text = "Batch";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(278, 104);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 37;
            label8.Text = "MFG";
            // 
            // txtBatch
            // 
            txtBatch.Location = new Point(95, 101);
            txtBatch.Name = "txtBatch";
            txtBatch.Size = new Size(167, 27);
            txtBatch.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(631, 104);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 41;
            label9.Text = "Expiry";
            // 
            // dtpMFG
            // 
            dtpMFG.Location = new Point(398, 99);
            dtpMFG.Name = "dtpMFG";
            dtpMFG.Size = new Size(210, 27);
            dtpMFG.TabIndex = 42;
            // 
            // dtpExpiry
            // 
            dtpExpiry.Location = new Point(764, 99);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(205, 27);
            dtpExpiry.TabIndex = 43;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxDisease);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDisInject);
            groupBox1.Controls.Add(txtNumInject);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpExpiry);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpMFG);
            groupBox1.Controls.Add(txtVacName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtBatch);
            groupBox1.Controls.Add(txtVacProc);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(15, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1140, 213);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "VACCINE INFORMATION";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(631, 179);
            label11.Name = "label11";
            label11.Size = new Size(127, 20);
            label11.TabIndex = 47;
            label11.Text = "Distance injection";
            // 
            // txtDisInject
            // 
            txtDisInject.Location = new Point(764, 176);
            txtDisInject.Name = "txtDisInject";
            txtDisInject.Size = new Size(205, 27);
            txtDisInject.TabIndex = 46;
            // 
            // txtNumInject
            // 
            txtNumInject.Location = new Point(398, 179);
            txtNumInject.Name = "txtNumInject";
            txtNumInject.Size = new Size(210, 27);
            txtNumInject.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(268, 183);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 44;
            label10.Text = "Number injection";
            // 
            // cbxDisease
            // 
            cbxDisease.FormattingEnabled = true;
            cbxDisease.Location = new Point(669, 33);
            cbxDisease.Name = "cbxDisease";
            cbxDisease.Size = new Size(168, 28);
            cbxDisease.TabIndex = 48;
            // 
            // VaccineManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 574);
            Controls.Add(btnSearch);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvVacInfor);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "VaccineManagement";
            Text = "Vaccine Management";
            Load += VaccineManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVacInfor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btnExit;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvVacInfor;
        private TextBox txtPrice;
        private TextBox txtVacProc;
        private TextBox txtVacName;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private TextBox txtBatch;
        private Label label9;
        private DateTimePicker dtpMFG;
        private DateTimePicker dtpExpiry;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox txtDisInject;
        private TextBox txtNumInject;
        private Label label10;
        private ComboBox cbxDisease;
    }
}