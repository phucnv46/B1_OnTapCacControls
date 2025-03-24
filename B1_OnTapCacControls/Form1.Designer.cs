namespace B1_OnTapCacControls
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
        private void InitializeComponent() // Hàm khởi tạo các thành phần của form
        {
            label1 = new Label();
            textBoxMSV = new TextBox();
            textBoxTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            radioButtonNu = new RadioButton();
            radioButtonNam = new RadioButton();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            label4 = new Label();
            numericUpDownDiem = new NumericUpDown();
            dataGridView1 = new DataGridView();
            comboBoxMon = new ComboBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 45);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // textBoxMSV
            // 
            textBoxMSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMSV.Location = new Point(200, 42);
            textBoxMSV.Name = "textBoxMSV";
            textBoxMSV.PlaceholderText = "Xin mời nhập mã sinh viên";
            textBoxMSV.Size = new Size(295, 34);
            textBoxMSV.TabIndex = 1;
            // 
            // textBoxTen
            // 
            textBoxTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTen.Location = new Point(200, 121);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.PlaceholderText = "Xin mời nhập tên";
            textBoxTen.Size = new Size(295, 34);
            textBoxTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 124);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 188);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(200, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonNu);
            groupBox1.Controls.Add(radioButtonNam);
            groupBox1.Location = new Point(51, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 106);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(212, 55);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 1;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(25, 55);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 0;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(629, 45);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 7;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(629, 120);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 8;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(629, 183);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 9;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 415);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 10;
            label4.Text = "Điểm";
            // 
            // numericUpDownDiem
            // 
            numericUpDownDiem.Location = new Point(132, 413);
            numericUpDownDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDiem.Name = "numericUpDownDiem";
            numericUpDownDiem.Size = new Size(150, 27);
            numericUpDownDiem.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 517);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 188);
            dataGridView1.TabIndex = 12;
            // 
            // comboBoxMon
            // 
            comboBoxMon.FormattingEnabled = true;
            comboBoxMon.Location = new Point(572, 259);
            comboBoxMon.Name = "comboBoxMon";
            comboBoxMon.Size = new Size(151, 28);
            comboBoxMon.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 259);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 14;
            label5.Text = "Môn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 705);
            Controls.Add(label5);
            Controls.Add(comboBoxMon);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDownDiem);
            Controls.Add(label4);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBoxTen);
            Controls.Add(label2);
            Controls.Add(textBoxMSV);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxMSV;
        private TextBox textBoxTen;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private RadioButton radioButtonNu;
        private RadioButton radioButtonNam;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Label label4;
        private NumericUpDown numericUpDownDiem;
        private DataGridView dataGridView1;
        private ComboBox comboBoxMon;
        private Label label5;
    }
}
