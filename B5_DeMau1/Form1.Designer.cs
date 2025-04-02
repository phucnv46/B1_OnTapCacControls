namespace B5_DeMau1
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
            label1 = new Label();
            label2 = new Label();
            textBoxMaNhanVien = new TextBox();
            textBoxTenNhanVien = new TextBox();
            label3 = new Label();
            textBoxChucVu = new TextBox();
            label4 = new Label();
            radioButtonNam = new RadioButton();
            radioButtonNu = new RadioButton();
            dataGridView1 = new DataGridView();
            buttonThem = new Button();
            buttonExit = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 43);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // textBoxMaNhanVien
            // 
            textBoxMaNhanVien.Location = new Point(115, 93);
            textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            textBoxMaNhanVien.Size = new Size(224, 27);
            textBoxMaNhanVien.TabIndex = 2;
            // 
            // textBoxTenNhanVien
            // 
            textBoxTenNhanVien.Location = new Point(115, 175);
            textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            textBoxTenNhanVien.Size = new Size(224, 27);
            textBoxTenNhanVien.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên nhân viên";
            // 
            // textBoxChucVu
            // 
            textBoxChucVu.Location = new Point(557, 97);
            textBoxChucVu.Name = "textBoxChucVu";
            textBoxChucVu.Size = new Size(188, 27);
            textBoxChucVu.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 100);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 5;
            label4.Text = "Chức vụ";
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(557, 190);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 7;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(667, 190);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 8;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 293);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(568, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(751, 301);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 10;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(751, 376);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 190);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 12;
            label5.Text = "Giới tính";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 516);
            Controls.Add(label5);
            Controls.Add(buttonExit);
            Controls.Add(buttonThem);
            Controls.Add(dataGridView1);
            Controls.Add(radioButtonNu);
            Controls.Add(radioButtonNam);
            Controls.Add(textBoxChucVu);
            Controls.Add(label4);
            Controls.Add(textBoxTenNhanVien);
            Controls.Add(label3);
            Controls.Add(textBoxMaNhanVien);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxMaNhanVien;
        private TextBox textBoxTenNhanVien;
        private Label label3;
        private TextBox textBoxChucVu;
        private Label label4;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonNu;
        private DataGridView dataGridView1;
        private Button buttonThem;
        private Button buttonExit;
        private Label label5;
    }
}
