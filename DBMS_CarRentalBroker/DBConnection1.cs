using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker
{
    internal class DBConnection1
    {
        public SqlConnection layKetNoi()
        {
            return new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt= False;TrustServerCertificate=True");
        }

        public void thucThi(string query)
        {
            SqlConnection conn = layKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public object thucThiScalar(string sqlString)
        {
            SqlConnection conn = layKetNoi();
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            object result = null;
            try
            {
                conn.Open();
                result = cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public DataTable thucThiDataTable(String sqlString)
        {
            SqlConnection conn = layKetNoi();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
