using B6_ChuaDeMau2.Models;
using B6_ChuaDeMau2.Repository;
using System.ComponentModel;
using System.Data.SqlTypes;

namespace B6_ChuaDeMau2
{
    public partial class Form1 : Form
    {
        BindingList<Sach> _saches;
        SachRepository _sachRepository = new SachRepository();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _saches = new BindingList<Sach>(_sachRepository.LayDSSach());
            dataGridView1.DataSource = _saches;
            radioButton100.Checked = true;
        }

        private void BindingToCotrol(Sach sach)
        {
            textBoxMaSach.Text = sach.MaSach;
            textBoxTenSach.Text = sach.TenSach;
            textBoxDonGia.Text = sach.DonGia.ToString();
            radioButton100.Checked = sach.SoTrang == 100;
            radioButton1000.Checked = sach.SoTrang == 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            if (_saches.Any(s=>s.MaSach.Equals(textBoxMaSach.Text.Trim())))
            {
                MessageBox.Show("Trùng mã sách");
                return;
            }
            
                sach.MaSach = textBoxMaSach.Text.Trim();
                sach.DonGia = float.Parse(textBoxDonGia.Text.Trim());
                sach.TenSach = textBoxTenSach.Text.Trim();
                sach.SoTrang = radioButton100.Checked ? 100 : 1000;
                _sachRepository.ThemSach(sach);
                LoadData();
            MessageBox.Show("Thêm thành công");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_saches.Any())
            {
                BindingToCotrol(_saches.Last());
                dataGridView1.Rows[_saches.Count - 1].Selected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             Sach sach = dataGridView1.SelectedRows[0].DataBoundItem as Sach;
            BindingToCotrol(sach);
        }
    }
}
