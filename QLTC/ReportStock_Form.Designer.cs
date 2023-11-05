namespace QLTC
{
    partial class ReportStock_Form
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
            dgvSchedule = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbxProvince = new ComboBox();
            cbxCenter = new ComboBox();
            cbxType = new ComboBox();
            cbxStatus = new ComboBox();
            dtpDate = new DateTimePicker();
            txtNameID = new TextBox();
            btnView = new Button();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(477, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 35);
            label1.TabIndex = 0;
            label1.Text = "Stock Report";
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(12, 304);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(1144, 217);
            dgvSchedule.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 62);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Province";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 62);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Center";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 158);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 4;
            label4.Text = "Vaccine Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 258);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 5;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 253);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 6;
            label6.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(358, 158);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 7;
            label7.Text = "Vaccine Name/ ID";
            // 
            // cbxProvince
            // 
            cbxProvince.FormattingEnabled = true;
            cbxProvince.Items.AddRange(new object[] { "Hà Nội", "Hồ Chí Minh", "Hải Phòng", "Cần Thơ", "Đà Nẵng", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái", "Quảng Trị" });
            cbxProvince.Location = new Point(128, 59);
            cbxProvince.Name = "cbxProvince";
            cbxProvince.Size = new Size(199, 28);
            cbxProvince.TabIndex = 10;
            cbxProvince.SelectedIndexChanged += cbxProvince_SelectedIndexChanged;
            // 
            // cbxCenter
            // 
            cbxCenter.FormattingEnabled = true;
            cbxCenter.Location = new Point(504, 58);
            cbxCenter.Name = "cbxCenter";
            cbxCenter.Size = new Size(192, 28);
            cbxCenter.TabIndex = 11;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(128, 155);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(199, 28);
            cbxType.TabIndex = 12;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(504, 250);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(192, 28);
            cbxStatus.TabIndex = 13;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(128, 253);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(199, 27);
            dtpDate.TabIndex = 14;
            // 
            // txtNameID
            // 
            txtNameID.Location = new Point(504, 151);
            txtNameID.Name = "txtNameID";
            txtNameID.Size = new Size(192, 27);
            txtNameID.TabIndex = 15;
            // 
            // btnView
            // 
            btnView.Location = new Point(15, 204);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 16;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1039, 531);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnView);
            groupBox1.Location = new Point(718, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 244);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 37);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 17;
            label8.Text = "Remaining vaccines";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 97);
            label9.Name = "label9";
            label9.Size = new Size(231, 20);
            label9.TabIndex = 19;
            label9.Text = "Number of vaccines administered";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 20;
            // 
            // ReportStock_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 572);
            Controls.Add(btnClose);
            Controls.Add(txtNameID);
            Controls.Add(dtpDate);
            Controls.Add(cbxStatus);
            Controls.Add(cbxType);
            Controls.Add(cbxCenter);
            Controls.Add(cbxProvince);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvSchedule);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "ReportStock_Form";
            Text = "Report Stock";
            Load += ReportStock_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSchedule;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbxProvince;
        private ComboBox cbxCenter;
        private ComboBox cbxType;
        private ComboBox cbxStatus;
        private DateTimePicker dtpDate;
        private TextBox txtNameID;
        private Button btnView;
        private Button btnClose;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
    }
}