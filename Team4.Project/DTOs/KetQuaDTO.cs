using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.Project.DTOs
{
    class KetQuaDTO
    {
        private int maMH, tenMH, diemMH;

        public KetQuaDTO(int maMH, int tenMH, int diemMH)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.diemMH = diemMH;
        }

        public int MaMH { get => maMH; set => maMH = value; }
        public int TenMH { get => tenMH; set => tenMH = value; }
        public int DiemMH { get => diemMH; set => diemMH = value; }
    }
}
