using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DataLayer
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
        public SqlConnection con = new SqlConnection(connectionString);
        public void DbConn(string Query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DataReturn(string Query)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
