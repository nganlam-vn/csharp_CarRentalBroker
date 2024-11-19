using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Dao
{
    public class NguoiThueDAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable getAllCar()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM v_danhSachXeDaDuyet", dbConn.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable getCarDetails()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM v_chiTietXeDaDuyet", dbConn.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


    }
}
