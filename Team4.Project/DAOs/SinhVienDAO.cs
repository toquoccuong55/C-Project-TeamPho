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
                string sql = "Select TEN, MAKH from SVIEN where MASV = @MaSV";
                command = new SqlCommand(sql, con);
                SqlParameter param = new SqlParameter();
                command.Parameters.AddWithValue("@MaSV", maSV);
                dataReader = command.ExecuteReader();                
                if (dataReader.Read())
                {
                    dto = new SinhVienDTO(maSV, dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString());
                }
            }
            finally
            {
                CloseConnection();
            }
            return dto;
        }

        

    }
}
