using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Data_Access
{
    public static class Reposatory
    {
        static string connection_string = General.connectionString;
        static SqlConnection con = new SqlConnection(connection_string);
        public static DataTable select(SqlCommand _cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_cmd);
                _cmd.Connection = con;
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int DML(SqlCommand _cmd)
        {
            try
            {
                int result = 0;
                _cmd.Connection = con;
                con.Open();
                result = _cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
