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
        private String tenSV, maKH;

        public SinhVienDTO(int maSV, string tenSV, string maKH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.maKH = maKH;
        }

        public int MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
    }
}
