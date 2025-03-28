namespace B2_KetNoiDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            dateTimePickerNS = new DateTimePicker();
            label8 = new Label();
            dateTimePickerNVL = new DateTimePicker();
            label7 = new Label();
            comboBoxPB = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            textBoxMNV = new TextBox();
            label4 = new Label();
            radioButtonNu = new RadioButton();
            radioButtonNam = new RadioButton();
            label3 = new Label();
            comboBoxVT = new ComboBox();
            textBoxCCCD = new TextBox();
            label2 = new Label();
            textBoxHoTen = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            buttonTim = new Button();
            textBoxTim = new TextBox();
            groupBox4 = new GroupBox();
            buttonLamMoi = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(3, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(944, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(938, 203);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dateTimePickerNS);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dateTimePickerNVL);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBoxPB);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxMNV);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(radioButtonNu);
            groupBox2.Controls.Add(radioButtonNam);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBoxVT);
            groupBox2.Controls.Add(textBoxCCCD);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxHoTen);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(947, 238);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thong tin nhân viên";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(731, 175);
            numericUpDown1.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(636, 28);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 19;
            label9.Text = "Ngày sinh";
            // 
            // dateTimePickerNS
            // 
            dateTimePickerNS.Location = new Point(714, 26);
            dateTimePickerNS.Name = "dateTimePickerNS";
            dateTimePickerNS.Size = new Size(184, 27);
            dateTimePickerNS.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(609, 106);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 17;
            label8.Text = "Ngày vào làm";
            // 
            // dateTimePickerNVL
            // 
            dateTimePickerNVL.Location = new Point(714, 104);
            dateTimePickerNVL.Name = "dateTimePickerNVL";
            dateTimePickerNVL.Size = new Size(184, 27);
            dateTimePickerNVL.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 177);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 15;
            label7.Text = "Phòng ban";
            // 
            // comboBoxPB
            // 
            comboBoxPB.FormattingEnabled = true;
            comboBoxPB.Location = new Point(395, 169);
            comboBoxPB.Name = "comboBoxPB";
            comboBoxPB.Size = new Size(151, 28);
            comboBoxPB.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(618, 170);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 12;
            label6.Text = "Hệ số lương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 35);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 11;
            label5.Text = "Giới tính";
            // 
            // textBoxMNV
            // 
            textBoxMNV.Location = new Point(395, 99);
            textBoxMNV.Name = "textBoxMNV";
            textBoxMNV.Size = new Size(154, 27);
            textBoxMNV.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 99);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Mã NV";
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(495, 31);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 8;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(395, 33);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 7;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 166);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Vai trò";
            // 
            // comboBoxVT
            // 
            comboBoxVT.FormattingEnabled = true;
            comboBoxVT.Location = new Point(100, 166);
            comboBoxVT.Name = "comboBoxVT";
            comboBoxVT.Size = new Size(151, 28);
            comboBoxVT.TabIndex = 5;
            // 
            // textBoxCCCD
            // 
            textBoxCCCD.Location = new Point(100, 107);
            textBoxCCCD.Name = "textBoxCCCD";
            textBoxCCCD.Size = new Size(154, 27);
            textBoxCCCD.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 107);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "CCCD";
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(100, 35);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(154, 27);
            textBoxHoTen.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ tên";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(buttonTim);
            groupBox3.Controls.Add(textBoxTim);
            groupBox3.Location = new Point(6, 526);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(403, 89);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // buttonTim
            // 
            buttonTim.Location = new Point(303, 39);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(94, 29);
            buttonTim.TabIndex = 21;
            buttonTim.Text = "Tìm kiếm";
            buttonTim.UseVisualStyleBackColor = true;
            buttonTim.Click += buttonTim_Click;
            // 
            // textBoxTim
            // 
            textBoxTim.Location = new Point(6, 41);
            textBoxTim.Name = "textBoxTim";
            textBoxTim.Size = new Size(257, 27);
            textBoxTim.TabIndex = 20;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(buttonLamMoi);
            groupBox4.Controls.Add(buttonXoa);
            groupBox4.Controls.Add(buttonSua);
            groupBox4.Controls.Add(buttonThem);
            groupBox4.Location = new Point(427, 526);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(517, 89);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Công cụ";
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.Location = new Point(377, 40);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(94, 29);
            buttonLamMoi.TabIndex = 25;
            buttonLamMoi.Text = "LamMoi";
            buttonLamMoi.UseVisualStyleBackColor = true;
            buttonLamMoi.Click += buttonLamMoi_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(253, 40);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 24;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(124, 40);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 23;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(6, 39);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 22;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 639);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label label7;
        private ComboBox comboBoxPB;
        private Label label6;
        private Label label5;
        private TextBox textBoxMNV;
        private Label label4;
        private RadioButton radioButtonNu;
        private RadioButton radioButtonNam;
        private Label label3;
        private ComboBox comboBoxVT;
        private TextBox textBoxCCCD;
        private Label label2;
        private TextBox textBoxHoTen;
        private Label label1;
        private Label label9;
        private DateTimePicker dateTimePickerNS;
        private Label label8;
        private DateTimePicker dateTimePickerNVL;
        private GroupBox groupBox3;
        private Button buttonTim;
        private TextBox textBoxTim;
        private GroupBox groupBox4;
        private Button buttonSua;
        private Button buttonThem;
        private Button buttonLamMoi;
        private Button buttonXoa;
        private NumericUpDown numericUpDown1;
    }
}
