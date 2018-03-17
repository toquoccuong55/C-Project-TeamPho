using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4.Project.DTOs;
using System.Data.SqlClient;
using Team4.Project.DBUtils;

namespace Team4.Project.DAOs
{
    class KetQuaDAO
    {
        SqlConnection con = null;
        SqlCommand command = null;
        SqlDataReader dataReader = null;

        private void CloseConnection()
        {
            if (dataReader != null)
            {
                dataReader.Close();
            }
            if (con != null)
            {
                con.Close();
            }
        }
        public List<KetQuaDTO> GetScores(int maSV)
        {
            List<KetQuaDTO> list = null;
            try
            {
                con = MyConnection.GetMyConnection();
                con.Open();
                string sql = "select kq.DIEM, a.TENMH, a.MAMH "
                    + "from KQUA kq, (select hp.MAHP, a.TENMH, a.MAMH" 
                    + " from HPHAN hp, (select TENMH, MAMH from MHOC where MAKH = (select MAKH from SVIEN where MASV = @MASV)) a" +
                    " where hp.MAMH = a.MAMH ) a" 
                    + " where kq.MASV = @MASV and kq.MAHP = a.MAHP";
                // câu query mẫu
                //    select kq.DIEM, a.TENMH, a.MAMH
                //    from KQUA kq, (select hp.MAHP, a.TENMH, a.MAMH
                //    from HPHAN hp, (select TENMH, MAMH from MHOC where MAKH = (select MAKH from SVIEN where MASV = 2)) a
                //    where hp.MAMH = a.MAMH ) a
                //where kq.MASV = 2 and kq.MAHP = a.MAHP
                command = new SqlCommand(sql, con);
                SqlParameter param = new SqlParameter();
                command.Parameters.AddWithValue("@MaSV", maSV);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int diem = int.Parse(dataReader.GetValue(0).ToString());
                    string tenMH = dataReader.GetValue(1).ToString();
                    string maMH = dataReader.GetValue(0).ToString();
                    if (list == null)
                        list = new List<KetQuaDTO>();
                    list.Add(new KetQuaDTO(diem, maMH, tenMH));
                }
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }
    }
}
