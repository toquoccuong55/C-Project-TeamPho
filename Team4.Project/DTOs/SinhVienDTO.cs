using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.Project.DTOs
{
    class SinhVienDTO
    {
        private int maSV;
        private String tenSV, maKH, gioiTinh;
        private DateTime ngaySinh;

        public int MaSV
        {
            get
            {
                return maSV;
            }

            set
            {
                maSV = value;
            }
        }

        public string TenSV
        {
            get
            {
                return tenSV;
            }

            set
            {
                tenSV = value;
            }
        }

        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public SinhVienDTO(int maSV, string tenSV, string maKH, string gioiTinh, DateTime ngaySinh)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.maKH = maKH;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
        }





        //public SinhVienDTO(int maSV, string tenSV, string maKH)
        //{
        //    this.maSV = maSV;
        //    this.tenSV = tenSV;
        //    this.maKH = maKH;
        //}
        //public int MaSV { get => maSV; set => maSV = value; }
        //public string TenSV { get => tenSV; set => tenSV = value; }
        //public string MaKH { get => maKH; set => maKH = value; }
        //get set and contructor fit with visual 2017 but not visual 2014



    }
}
