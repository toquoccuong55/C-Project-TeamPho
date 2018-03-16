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
        public List<KetQuaDTO> GetScores()
        {
            List<KetQuaDTO> list = null;
            try
            {
                con = MyConnection.GetMyConnection();
                string sql = "";
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }
    }
}
