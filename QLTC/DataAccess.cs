using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace QLTC
{
    public class DataAccess
    {
        public static SqlConnection conn;
        public static SqlDataAdapter adapter;
        public static SqlCommand cmd;

        public static void connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public static void disconnect()
        {
            // check connection is open
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        // GET DATA TO DATAGRIDVIEW
        public static DataTable getDataToTable(string sql)
        {
            adapter = new SqlDataAdapter(sql, conn);// Defines an object of class 
            // construct object table of class DataTable
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }

        // CHECK EXIST
        public static int executeScalar(string sql)
        {
            int i = 0;
            cmd = new SqlCommand(sql, conn);
            i = (int)cmd.ExecuteScalar();
            return i;
        }
    }
}
