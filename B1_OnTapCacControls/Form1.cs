using B1_OnTapCacControls.Models;
using System.ComponentModel;

namespace B1_OnTapCacControls
{
    public partial class Form1 : Form
    {
        BindingList<SinhVien> _sinhViens = new BindingList<SinhVien>() {
          new SinhVien(){MaSinhVien="PH123",TenSinhVien="Phúc"
              ,NgaySinh= new DateTime(2006,7,6),GioiTinh="Nam",MonHoc="C#2",Diem=10}
        };

        List<string> MonHoc = new List<string>() { "C#1", "C#2", "CSDL" };
        public Form1()
        {
            InitializeComponent();
            LoadBang();

        }

        private void LoadBang()
        {
            dataGridView1.DataSource = _sinhViens; // Gán nguồn dữ liệu cho datagridview
            //Cách 2 để đổi tên cột trong data gridview
            dataGridView1.Columns[nameof(SinhVien.MaSinhVien)].HeaderText = "Mã Sinh Viên"; // Truy cập vào cột tương ứng với thuộc tính
            dataGridView1.Columns[nameof(SinhVien.TenSinhVien)].HeaderText = "Tên Sinh Viên"; // Truy cập vào cột tương ứng với thuộc tính

            comboBoxMon.DataSource = MonHoc; // Khởi tạo danh sách môn học
            radioButtonNam.Checked = true;

            numericUpDownDiem.DecimalPlaces = 2; // Cho numericupdown hiển thị 2 chữ số sau thập phân
        }

        private SinhVien BindingToModel() // Gán các giá trị từ control chuyển thành models
        {
            SinhVien sinhVien = new SinhVien();
            if (KiemTra())
            {
                sinhVien.MaSinhVien = textBoxMSV.Text;
                sinhVien.TenSinhVien = textBoxTen.Text;
                sinhVien.NgaySinh = dateTimePicker1.Value;
                sinhVien.MonHoc = (string)comboBoxMon.SelectedItem;
                sinhVien.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                sinhVien.Diem = (double)numericUpDownDiem.Value;
                return sinhVien;
            }

            else return null;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = BindingToModel();
           
              if(sinhVien!=null)
                _sinhViens.Add(sinhVien);
                //    _sinhViens = new List<SinhVien>();
               
            
           
        }

        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(textBoxMSV.Text) ||
                string.IsNullOrEmpty(textBoxTen.Text)
                )
            {
                MessageBox.Show("Có trường đang trống",
                    "Cảnh báo lừa đảo",MessageBoxButtons.OK,MessageBoxIcon.Warning);// Hiển thị hộp thoại
              return  false;
            }
            return true;
        }
    }
}
