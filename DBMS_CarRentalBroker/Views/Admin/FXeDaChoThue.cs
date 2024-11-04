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
    public partial class FXeDaChoThue : Form
    {
        DBConnection1 db = new DBConnection1();
        private int selectedXeId = -1;
        public FXeDaChoThue()
        {
            InitializeComponent();
        }

        private void gvXeChuaDuocThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng nào được chọn (tránh trường hợp nhấp vào tiêu đề cột)
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Lấy hàng hiện tại
                    DataGridViewRow selectedRow = gvXeDaThue.Rows[e.RowIndex];
                    int idXe = int.Parse(selectedRow.Cells[0].Value.ToString()); //Cell[0] là cột mã xe
                    selectedXeId = int.Parse(selectedRow.Cells[0].Value.ToString()); //Cell[0] là cột mã xe
                    //FChiTietXe fChiTietXe = new FChiTietXe(idXe);
                    //fChiTietXe.Show();
                    MessageBox.Show("Xe đã chọn: " + idXe);


                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một xe để xem chi tiết!");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }



        }

        private void FXeDaChoThue_Load(object sender, EventArgs e)
        {
            SqlConnection conn = db.layKetNoi();
            using (conn) 
            {
                string query = "SELECT * FROM v_XeDaThue";
                DataTable dataTable = new DataTable();
                dataTable = db.thucThiDataTable(query);

                gvXeDaThue.DataSource = dataTable;
            }
        }
    }
}
