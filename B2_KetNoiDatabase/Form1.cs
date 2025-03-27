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
            _nhanViens = new BindingList<NhanVien>(_repository.LayListNhanVien());
            dataGridView1.DataSource = _nhanViens;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            comboBoxVT.DataSource = _vaiTroRepository.LayList();
            comboBoxVT.DisplayMember = nameof(VaiTro.TenVaiTro);
            comboBoxVT.ValueMember = nameof(VaiTro.MaVaiTro);

            comboBoxPB.DataSource = _phongBanRepository.LayList();
            comboBoxPB.DisplayMember = nameof(PhongBan.TenPhongBan);
            comboBoxPB.ValueMember = nameof(PhongBan.MaPhongBan);

        }
    }
}
