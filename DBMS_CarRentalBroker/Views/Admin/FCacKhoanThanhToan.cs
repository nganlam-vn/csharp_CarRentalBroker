using DBMS_CarRentalBroker.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.Admin
{

    public partial class FCacKhoanThanhToan : Form
    {
        public DBConnection dbConn = new DBConnection();
        DBConnection1 db = new DBConnection1();
        int userId = Global.MaND;
        public FCacKhoanThanhToan()
        {
            InitializeComponent();
            laySoDu(userId);
        }

        private void laySoDu(int userId)
        {
            string query = "SELECT * FROM func_layThongTinTaiKhoan(@UserId)";
            using (SqlCommand cmd = new SqlCommand(query, dbConn.getConnection))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);

                dbConn.openConnection();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.txtSoDu.Text = reader["SoDu"].ToString() + "     VND";
                    }
                }

                dbConn.closeConnection();
            }
        }

        private void FCacKhoanThanhToan_Load(object sender, EventArgs e)
        {
            SqlConnection conn = db.layKetNoi();
            using (conn)
            {
                string query = "SELECT * FROM v_LayThanhToanNguoiThue";
                gvThanhToan.DataSource = db.thucThiDataTable(query);
            }

        }
    }
}
