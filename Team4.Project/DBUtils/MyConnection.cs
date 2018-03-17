using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Team4.Project.DBUtils
{
    class MyConnection
    {
        public static SqlConnection GetMyConnection()
        {
            //SqlConnection con = null;
            //SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            //stringBuilder.UserID = "sa";
            //stringBuilder.Password = "12345678";
            //stringBuilder.DataSource = "localhost";
            //stringBuilder.InitialCatalog = "QLSVien";
            //con = new SqlConnection(stringBuilder.ConnectionString);
            SqlConnection con = new SqlConnection("Server=localhost;Database=QLSVien;Integrated Security=SSPI");
            return con;
        }
    }
}
