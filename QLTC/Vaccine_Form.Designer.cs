namespace QLTC
{
    partial class Vaccine_Form
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
            txtVacName = new TextBox();
            txtVacType = new TextBox();
            txtVacProc = new TextBox();
            txtPrice = new TextBox();
            dgvVacInfor = new DataGridView();
            btnCancel = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVacInfor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(394, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 35);
            label1.TabIndex = 0;
            label1.Text = "Vaccine Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Vaccine ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 152);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Vaccine name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 76);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Vaccine Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 152);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 4;
            label5.Text = "Vaccine Producer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(852, 76);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 5;
            label6.Text = "Price";
            // 
            // txtID
            // 
            txtID.Location = new Point(167, 76);
            txtID.Name = "txtID";
            txtID.Size = new Size(221, 27);
            txtID.TabIndex = 6;
            // 
            // txtVacName
            // 
            txtVacName.Location = new Point(167, 145);
            txtVacName.Name = "txtVacName";
            txtVacName.Size = new Size(221, 27);
            txtVacName.TabIndex = 7;
            // 
            // txtVacType
            // 
            txtVacType.Location = new Point(573, 76);
            txtVacType.Name = "txtVacType";
            txtVacType.Size = new Size(219, 27);
            txtVacType.TabIndex = 8;
            // 
            // txtVacProc
            // 
            txtVacProc.Location = new Point(573, 149);
            txtVacProc.Name = "txtVacProc";
            txtVacProc.Size = new Size(219, 27);
            txtVacProc.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(926, 76);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(176, 27);
            txtPrice.TabIndex = 10;
            // 
            // dgvVacInfor
            // 
            dgvVacInfor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacInfor.Location = new Point(28, 205);
            dgvVacInfor.Name = "dgvVacInfor";
            dgvVacInfor.RowHeadersWidth = 51;
            dgvVacInfor.RowTemplate.Height = 29;
            dgvVacInfor.Size = new Size(1074, 283);
            dgvVacInfor.TabIndex = 11;
            dgvVacInfor.CellContentClick += dgvVacInfor_CellContentClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(176, 528);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1008, 528);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(28, 528);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(573, 53);
            label7.Name = "label7";
            label7.Size = new Size(174, 20);
            label7.TabIndex = 18;
            label7.Text = "* Condition for searching";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(167, 122);
            label8.Name = "label8";
            label8.Size = new Size(174, 20);
            label8.TabIndex = 19;
            label8.Text = "* Condition for searching";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(573, 126);
            label9.Name = "label9";
            label9.Size = new Size(174, 20);
            label9.TabIndex = 20;
            label9.Text = "* Condition for searching";
            // 
            // Vaccine_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 569);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnSearch);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(dgvVacInfor);
            Controls.Add(txtPrice);
            Controls.Add(txtVacProc);
            Controls.Add(txtVacType);
            Controls.Add(txtVacName);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Vaccine_Form";
            Text = "Vaccine Form";
            Load += Vaccine_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVacInfor).EndInit();
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
        private TextBox txtVacName;
        private TextBox txtVacType;
        private TextBox txtVacProc;
        private TextBox txtPrice;
        private DataGridView dgvVacInfor;
        private Button btnCancel;
        private Button btnExit;
        private Button btnSearch;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}