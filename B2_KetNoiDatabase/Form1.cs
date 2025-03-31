using B2_KetNoiDatabase.Models;
using B2_KetNoiDatabase.Repositories;
using System.ComponentModel;

namespace B2_KetNoiDatabase
{
    public partial class Form1 : Form
    {
        //Dungf list trong winform để cập nhật cần dùng BindingList
        BindingList<NhanVien> _nhanViens;
        NhanVienRepository _repository;
        GenericRepository<VaiTro> _vaiTroRepository = new GenericRepository<VaiTro>();
        GenericRepository<PhongBan> _phongBanRepository = new GenericRepository<PhongBan>();
        GenericRepository<NhanVien> _NhanVienRepository = new GenericRepository<NhanVien>();
        public Form1()
        {
            InitializeComponent();
            _repository = new NhanVienRepository();

            LoadTableNhanVien();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadTableNhanVien()
        {
            _nhanViens = new BindingList<NhanVien>(_NhanVienRepository.LayDSKemCacQuanHe("MaPhongBanNavigation", "MaVaiTroNavigation"));
            dataGridView1.DataSource = _nhanViens;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Columns[nameof(NhanVien.MaVaiTro)].Visible = false;
            dataGridView1.Columns[nameof(NhanVien.MaPhongBan)].Visible = false;

            comboBoxVT.DataSource = _vaiTroRepository.LayList();
            comboBoxVT.DisplayMember = nameof(VaiTro.TenVaiTro);
            comboBoxVT.ValueMember = nameof(VaiTro.MaVaiTro);

            comboBoxPB.DataSource = _phongBanRepository.LayList();
            comboBoxPB.DisplayMember = nameof(PhongBan.TenPhongBan);
            comboBoxPB.ValueMember = nameof(PhongBan.MaPhongBan);

            radioButtonNam.Checked = true;
        }

        private NhanVien BindingToNhanVien()
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNhanVien = textBoxMNV.Text;
            nhanVien.Cccd = textBoxCCCD.Text;
            nhanVien.NgayVaoLamViec = dateTimePickerNVL.Value;
            nhanVien.NgaySinh = dateTimePickerNS.Value;
            nhanVien.MaPhongBan = (string)comboBoxPB.SelectedValue;
            nhanVien.MaVaiTro = (string)comboBoxVT.SelectedValue;
            nhanVien.HoTen = textBoxHoTen.Text;
            nhanVien.HeSoLuong = (int)numericUpDown1.Value;
            return nhanVien;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = BindingToNhanVien();
            _NhanVienRepository.Them(nhanVien);
            LoadTableNhanVien();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = (NhanVien)dataGridView1.SelectedRows[0].DataBoundItem;
            _NhanVienRepository.Delete(nhanvien.MaNhanVien);
            LoadTableNhanVien();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e) // Chuyển mọi thứ về trạng thái ban đầu
        {
            textBoxCCCD.ResetText();
            textBoxHoTen.ResetText();
            textBoxMNV.ResetText();
            textBoxTim.ResetText();
            comboBoxPB.SelectedIndex = 0;
            comboBoxVT.SelectedIndex = 0;
            dateTimePickerNS.ResetText();
            dateTimePickerNVL.Value = DateTime.Now;
            numericUpDown1.Value = default(decimal);
            LoadTableNhanVien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nhanvien = (NhanVien)dataGridView1.SelectedRows[0].DataBoundItem;
            textBoxHoTen.Text = nhanvien.HoTen;
            textBoxCCCD.Text = nhanvien.Cccd;
            textBoxMNV.Text = nhanvien.MaNhanVien;
            comboBoxPB.SelectedValue = nhanvien.MaPhongBan;
            comboBoxVT.SelectedValue = nhanvien.MaVaiTro;
            dateTimePickerNS.Value = nhanvien.NgaySinh.Value;
            dateTimePickerNVL.Value = nhanvien.NgayVaoLamViec.Value;
            numericUpDown1.Value = (decimal)nhanvien.HeSoLuong;

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

            NhanVien nhanVien = (NhanVien)dataGridView1.SelectedRows[0].DataBoundItem;
            nhanVien.MaNhanVien = textBoxMNV.Text;
            nhanVien.Cccd = textBoxCCCD.Text;
            nhanVien.NgayVaoLamViec = dateTimePickerNVL.Value;
            nhanVien.NgaySinh = dateTimePickerNS.Value;
            nhanVien.MaPhongBan = (string)comboBoxPB.SelectedValue;
            nhanVien.MaVaiTro = (string)comboBoxVT.SelectedValue;
            nhanVien.HoTen = textBoxHoTen.Text;
            nhanVien.HeSoLuong = (int)numericUpDown1.Value;
            _NhanVienRepository.Update(nhanVien);

            int index = dataGridView1.CurrentCell.RowIndex;

            LoadTableNhanVien();

            dataGridView1.Rows[index].Selected = true;

        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            List<NhanVien> listTimKiem;
            listTimKiem = _NhanVienRepository.LayList()
                 .Where(nv => nv.MaNhanVien.Contains(textBoxTim.Text,StringComparison.OrdinalIgnoreCase)
                 || nv.HoTen.Contains(textBoxTim.Text, StringComparison.OrdinalIgnoreCase)
                 ).ToList();   
            dataGridView1.DataSource = listTimKiem;

            
        }
    }
}
