using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker
{
    public class DBConnection
    {
        public static string strCon = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public SqlConnection getConnection
        {
            get
            {
                return sqlCon;
            }
        }

        // Constructor
        public DBConnection()
        {
            sqlCon = new SqlConnection(strCon);
        }

        public void openConnection()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
    }

}
