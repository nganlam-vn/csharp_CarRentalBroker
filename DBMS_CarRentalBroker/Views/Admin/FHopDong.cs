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
    public partial class FHopDong : Form
    {
        DBConnection1 db = new DBConnection1();
        public FHopDong()
        {
            InitializeComponent();
        }

        private void FHopDong_Load(object sender, EventArgs e)
        {
            SqlConnection conn = db.layKetNoi();
            using (conn)
            {
                string query = "SELECT * FROM v_LayHopDongAdmin";
                DataTable dataTable = new DataTable();
                dataTable = db.thucThiDataTable(query);

                gvHopDong.DataSource = dataTable;
            }
        }
    }
}
