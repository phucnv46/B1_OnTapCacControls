namespace B6_ChuaDeMau2
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
            textBoxMaSach = new TextBox();
            textBoxDonGia = new TextBox();
            label3 = new Label();
            textBoxTenSach = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButton100 = new RadioButton();
            radioButton1000 = new RadioButton();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 30);
            label1.Name = "label1";
            label1.Size = new Size(183, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 105);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sách";
            // 
            // textBoxMaSach
            // 
            textBoxMaSach.Location = new Point(137, 107);
            textBoxMaSach.Name = "textBoxMaSach";
            textBoxMaSach.Size = new Size(164, 27);
            textBoxMaSach.TabIndex = 2;
            // 
            // textBoxDonGia
            // 
            textBoxDonGia.Location = new Point(137, 191);
            textBoxDonGia.Name = "textBoxDonGia";
            textBoxDonGia.Size = new Size(164, 27);
            textBoxDonGia.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 189);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá";
            // 
            // textBoxTenSach
            // 
            textBoxTenSach.Location = new Point(552, 102);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.Size = new Size(164, 27);
            textBoxTenSach.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 100);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "Tên sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 189);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Số trang";
            // 
            // radioButton100
            // 
            radioButton100.AutoSize = true;
            radioButton100.Location = new Point(499, 187);
            radioButton100.Name = "radioButton100";
            radioButton100.Size = new Size(93, 24);
            radioButton100.TabIndex = 8;
            radioButton100.TabStop = true;
            radioButton100.Text = "100 trang";
            radioButton100.UseVisualStyleBackColor = true;
            // 
            // radioButton1000
            // 
            radioButton1000.AutoSize = true;
            radioButton1000.Location = new Point(625, 187);
            radioButton1000.Name = "radioButton1000";
            radioButton1000.Size = new Size(101, 24);
            radioButton1000.TabIndex = 9;
            radioButton1000.TabStop = true;
            radioButton1000.Text = "1000 trang";
            radioButton1000.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 234);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(564, 204);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(674, 234);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton1000);
            Controls.Add(radioButton100);
            Controls.Add(label5);
            Controls.Add(textBoxTenSach);
            Controls.Add(label4);
            Controls.Add(textBoxDonGia);
            Controls.Add(label3);
            Controls.Add(textBoxMaSach);
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
        private TextBox textBoxMaSach;
        private TextBox textBoxDonGia;
        private Label label3;
        private TextBox textBoxTenSach;
        private Label label4;
        private Label label5;
        private RadioButton radioButton100;
        private RadioButton radioButton1000;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
