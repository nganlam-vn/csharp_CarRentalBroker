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

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FLichSuChoThue : Form
    {
        int maND = 4;
        String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FLichSuChoThue()
        {
            InitializeComponent();
            LoadDataLichSuChoThue();
            AddButtonsToDataGridView();
        }

        private void LoadDataLichSuChoThue()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ProceduresViewHopDongBangMaND", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaND", maND);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvLichSuChoThue.DataSource = dataTable;
                        dgvLichSuChoThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No contracts found for this user.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading contracts: " + ex.Message);
                }
            }

        }
        private void AddButtonsToDataGridView()
        {
            DataGridViewButtonColumn buttonColumnInHopDong = new DataGridViewButtonColumn();
            buttonColumnInHopDong.HeaderText = ""; // Tiêu đề cột
            buttonColumnInHopDong.Text = "In hợp đồng"; // Văn bản hiển thị trên nút
            buttonColumnInHopDong.UseColumnTextForButtonValue = true; // Sử dụng văn bản cột cho tất cả các nút
            buttonColumnInHopDong.Name = "InHopDong"; // Đặt tên cho cột
            dgvLichSuChoThue.Columns.Add(buttonColumnInHopDong);
        }
        private void dgvLichSuChoThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvLichSuChoThue.Columns["InHopDong"].Index)
                {
                    int maHopDong = Convert.ToInt32(dgvLichSuChoThue.Rows[e.RowIndex].Cells["MaHopDong"].Value);
                    FHopDong hopDongForm = new FHopDong(maHopDong);
                    hopDongForm.ShowDialog();
                }
            }
        }


    }
}
