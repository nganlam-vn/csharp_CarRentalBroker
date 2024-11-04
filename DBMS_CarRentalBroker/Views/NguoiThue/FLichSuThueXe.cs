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

namespace DBMS_CarRentalBroker.Views.NguoiThue
{
    public partial class FLichSuThueXe : Form
    {
        public DBConnection dbConn = new DBConnection();
        int userId = 3;

        public FLichSuThueXe()
        {
            InitializeComponent();
            dtgvLichSuThueXe.AutoGenerateColumns = false;
        }

        private void FLichSuThueXe_Load(object sender, EventArgs e)
        {
            layLichSuThueXe();
        }

        public void layLichSuThueXe()
        {
            string query = "SELECT * FROM func_lichSuThueXe(@UserId)";

            using (SqlCommand command = new SqlCommand(query, dbConn.getConnection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvLichSuThueXe.DataSource = dataTable;

                dbConn.closeConnection();
            }
        }
    }
}
