using KetNoiDatabase2.Models;
using KetNoiDatabase2.Repositories;
using System.ComponentModel;

namespace KetNoiDatabase2
{
    public partial class Form1 : Form
    {
        GenericRepository<Sach> _sachRepository = new GenericRepository<Sach>();
        BindingList<Sach> _saches;
        GenericRepository<TheLoai> _theLoaiRepository = new GenericRepository<TheLoai>();

        public Form1()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
           _saches = new BindingList<Sach>(_sachRepository.GetAllWithRelationship("MaTheLoaiNavigation"));
            dataGridView1.DataSource = _saches;

            comboBox1.DataSource = _theLoaiRepository.GetAll();
            comboBox1.DisplayMember = nameof(TheLoai.TenTheLoai);
            comboBox1.ValueMember = nameof(TheLoai.MaTheLoai);
        }
    }
}
