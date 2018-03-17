using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.Project.DTOs
{
    class KetQuaDTO
    {
        private int diemMH;
        private string maMH, tenMH;

        public KetQuaDTO(int diemMH, string maMH, string tenMH)
        {
            this.diemMH = diemMH;
            this.maMH = maMH;
            this.tenMH = tenMH;
        }

        public int DiemMH
        {
            get
            {
                return diemMH;
            }

            set
            {
                diemMH = value;
            }
        }

        public string MaMH
        {
            get
            {
                return maMH;
            }

            set
            {
                maMH = value;
            }
        }

        public string TenMH
        {
            get
            {
                return tenMH;
            }

            set
            {
                tenMH = value;
            }
        }



        //public KetQuaDTO(int maMH, int tenMH, int diemMH)
        //{
        //    this.maMH = maMH;
        //    this.tenMH = tenMH;
        //    this.diemMH = diemMH;
        //}

        //public int MaMH { get => maMH; set => maMH = value; }
        //public int TenMH { get => tenMH; set => tenMH = value; }
        //public int DiemMH { get => diemMH; set => diemMH = value; }
        //visual 2014 don't understand
    }
}
