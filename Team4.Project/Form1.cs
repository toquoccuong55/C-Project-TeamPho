using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MaSV = int.Parse(cbMaSV.Text);
            SinhVienDAO dao = new SinhVienDAO();
            SinhVienDTO dto = dao.GetInforSV(MaSV);
            string hoTenSinh = dto.TenSV;
            string[] chuoitach = hoTenSinh.Split(' ' );
            string firstName = chuoitach[0];
            txtTenSV.Text = firstName;
            string lastName = "";
            for (int i = 1; i < chuoitach.Length; i++)
            {
                lastName = lastName + " " + chuoitach[i];
            }
            txtHoSV.Text = lastName;
            txtMaKhoa.Text = dto.MaKH;


        }
    }
}
