using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team4.Project.DAOs;
using Team4.Project.DTOs;

namespace Team4.Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SinhVienDAO sinhVienDAO = new SinhVienDAO();
            cbMaSV.DataSource = sinhVienDAO.GetAllStudentID();
            loadData();

        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            int MaSV = 2;

            try
            {
                MaSV = int.Parse(cbMaSV.Text);
            }
            catch (Exception)
            {
                return;
            }
             
            
            SinhVienDAO dao = new SinhVienDAO();
            SinhVienDTO dto = dao.GetInforSV(MaSV);
            if(dto == null)
            {
                MaSV = 2;
                dto = dao.GetInforSV(MaSV);
                cbMaSV.Text = "2";
            }
            //tách họ tên của sinh viên
            string hoTenSinh = dto.TenSV;
            string[] chuoitach = hoTenSinh.Split(' ');
            string firstName = chuoitach[0];
            txtTenSV.Text = firstName;
            string lastName = "";
            for (int i = 1; i < chuoitach.Length; i++)
            {
                lastName = lastName + " " + chuoitach[i];
            }
            txtHoSV.Text = lastName;
            txtMaKhoa.Text = dto.MaKH;
            txtGioiTinh.Text = dto.GioiTinh;

            //Convert datetime to date 
            DateTime ngaySinhTime = dto.NgaySinh;
            string ngaySinh = ngaySinhTime.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            txtNgaySinh.Text = ngaySinh;

            // đẩy kết quả điểm
            KetQuaDAO daoKQ = new KetQuaDAO();
            List<KetQuaDTO> listKQ = daoKQ.GetScores(MaSV);

            dgKetQua.DataSource = listKQ;
        }
    }
}
