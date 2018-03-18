using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Team4.Project.DBUtils;
using Team4.Project.DTOs;

namespace Team4.Project.DAOs
{
    class SinhVienDAO 
    {
        SqlConnection con = null;
        SqlCommand command = null;
        SqlDataReader dataReader = null;

        private void CloseConnection()
        {
            if(dataReader != null)
            {
                dataReader.Close();
            }
            if (con != null)
            {
                con.Close();
            }
        }
        public List<string> GetAllStudentID()
        {
            List<string> list = null;
            try
            {
                con = MyConnection.GetMyConnection();
                con.Open();
                string sql = "Select MASV from SVIEN";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                list = new List<string>();
                while (dataReader.Read())
                {
                    list.Add(dataReader.GetValue(0).ToString().Trim());
                }
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }

        public SinhVienDTO GetInforSV(int maSV)
        {
            SinhVienDTO dto = null;
            try
            {
                con = MyConnection.GetMyConnection();
                con.Open();
                string sql = "Select TEN, MAKH, NGAYSINH, GIOITINH from SVIEN where MASV = @MaSV";
                command = new SqlCommand(sql, con);
                SqlParameter param = new SqlParameter();
                command.Parameters.AddWithValue("@MaSV", maSV);
                dataReader = command.ExecuteReader();                
                if (dataReader.Read())
                {
                    dto = new SinhVienDTO(maSV, dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString(),
                        dataReader.GetValue(3).ToString(), DateTime.Parse(dataReader.GetValue(2).ToString()));
                }
            }
            finally
            {
                CloseConnection();
            }
            return dto;
        }

        public int getFirstMaSV()
        {
            int number = 0;
            try
            {
                con = MyConnection.GetMyConnection();
                con.Open();
                string sql = "select min(MASV) as firstMaSV from SVIEN";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                if(dataReader.Read())
                {
                    number = int.Parse(dataReader.GetValue(0).ToString());
                }
            }
            finally
            {
                CloseConnection();
            }
            return number;
        }

    }
}
