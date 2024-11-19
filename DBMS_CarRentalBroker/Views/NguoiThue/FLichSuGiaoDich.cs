using DBMS_CarRentalBroker.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.NguoiThue
{
    public partial class FLichSuGiaoDich : Form
    {
        public DBConnection dbConn = new DBConnection();
        int userId = Global.MaND;
        public FLichSuGiaoDich()
        {
            InitializeComponent();
            dtgvLichSuGiaoDich.AutoGenerateColumns = false;
        }

        private void FLichSuGiaoDich_Load(object sender, EventArgs e)
        {
            layLichSuGiaoDich();
        }

        public void layLichSuGiaoDich()
        {
            string query = "SELECT * FROM func_lichSuGiaoDich(@UserId)";

            using (SqlCommand command = new SqlCommand(query, dbConn.getConnection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvLichSuGiaoDich.DataSource = dataTable;

                dbConn.closeConnection();
            }
        }
    }
}
