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

        // FUNCTION CHANGE DATA WHEN RUN SQL COMMAND( INSERT, UPDATE, DELETE)
        // Done All
        public static void runSQL(string sql, string[] name = null, object[] value = null)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            if (value != null)
            {
                for (int i = 0; i < value.Length; i++)
                    cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        // CHECK EXIST
        public static int executeScalar(string sql)
        {
            int i = 0;
            cmd = new SqlCommand(sql, conn);
            i = (int)cmd.ExecuteScalar();
            return i;
        }

        //CHECK KEY IF EXIST
        public static bool checkKey(string sql)
        {
            adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // FUNCTION GET A VALUE FROM A SQL COMMAND AND FILL INTO COMBOBOX
        public static void fillDataCombo(string sql, ComboBox cbx, string id, string name)
        {
            adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.ValueMember = id;
            cbx.DisplayMember = name;
        }

        // FUNCTION GET FIELD VALUE
        public static string getFieldValues(string sql)
        {
            string id = "";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetValue(0).ToString();
            }
            reader.Close();
            return id;
        }

        public static int GetLastIdentity()
        {
            // Assuming "YourTableName" is the name of the table with an identity column
            string query = "SELECT SCOPE_IDENTITY() AS LastIdentity";
                object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }

                    // If no identity value is found (e.g., no insert has occurred), you can handle it accordingly.
                    return -1; // Or throw an exception, return a default value, etc.
            }
    }
}
