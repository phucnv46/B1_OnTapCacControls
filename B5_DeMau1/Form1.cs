using B5_DeMau1.Models;
using B5_DeMau1.Repositories;
using System.ComponentModel;

namespace B5_DeMau1
{
    public partial class Form1 : Form
    {
        private readonly NhanVienRepository _repository;
        private BindingList<NhanVien> _nhanViens;
        public Form1()
        {
            InitializeComponent();
            _repository = new NhanVienRepository();
            LoadTable();
        }

        private void LoadTable()
        {
            _nhanViens = new BindingList<NhanVien>(_repository.GetListNhanViens());
            dataGridView1.DataSource = _nhanViens;
            dataGridView1.Columns[0].HeaderText = "Mã Nhân viên";
            radioButtonNam.Checked = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_nhanViens.Count > 0)
            {
                NhanVien nhanVien = _nhanViens.Last();
                textBoxMaNhanVien.Text = nhanVien.MaNhanVien;
                textBoxTenNhanVien.Text = nhanVien.YenNhanVien;
                textBoxChucVu.Text = nhanVien.ChucVu;
                if (nhanVien.GioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                    radioButtonNam.Checked = true;
                else radioButtonNu.Checked = true;
                int index = _nhanViens.IndexOf(nhanVien);
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (CheckTrong())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNhanVien = textBoxMaNhanVien.Text;
                nhanVien.YenNhanVien = textBoxTenNhanVien.Text;
                nhanVien.ChucVu = textBoxChucVu.Text;
                nhanVien.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                _repository.Them(nhanVien);
            }

        }

        private bool CheckTrong()
        {
            if (string.IsNullOrEmpty(textBoxMaNhanVien.Text) ||
                string.IsNullOrEmpty(textBoxChucVu.Text) ||
                string.IsNullOrEmpty(textBoxTenNhanVien.Text)
               )
            {
                MessageBox.Show("Có trường đang trống");
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nhanVien = (NhanVien)dataGridView1.SelectedRows[0].DataBoundItem as NhanVien;
            textBoxMaNhanVien.Text = nhanVien.MaNhanVien;
            textBoxTenNhanVien.Text = nhanVien.YenNhanVien;
            textBoxChucVu.Text = nhanVien.ChucVu;
            if (nhanVien.GioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                radioButtonNam.Checked = true;
            else radioButtonNu.Checked = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
