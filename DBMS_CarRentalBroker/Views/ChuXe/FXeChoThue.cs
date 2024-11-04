using DBMS_CarRentalBroker.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FXeChoThue : Form
    {
        String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";
        private Form currentFormchild;

        public FXeChoThue()
        {
            InitializeComponent();
            pnlLoc.Visible = false;
            LoadDataXeChoThue();
            AddButtonsToDataGridView();
        }

        private void LoadDataXeChoThue()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_XeChoThue", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();

                dgvXeChoThue.DataSource = dataTable;
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM func_TimKiemXe(@SearchTerm)";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@SearchTerm", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();

                dgvXeChoThue.DataSource = dataTable;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (!pnlLoc.Visible)
            {
                FLoc fLoc = new FLoc();
                fLoc.Owner = this;
                currentFormchild = fLoc;
                pnlLoc.Visible = true;
                fLoc.TopLevel = false;
                fLoc.FormBorderStyle = FormBorderStyle.None;
                fLoc.Dock = DockStyle.Fill;
                pnlLoc.Controls.Add(fLoc);
                pnlLoc.Tag = fLoc;
                fLoc.Show();
            }
            else
            {
                pnlLoc.Visible = false;
                if (currentFormchild != null)
                {
                    currentFormchild.Close();
                    currentFormchild = null;
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }

            currentFormchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlLoc.Controls.Add(childForm);
            pnlLoc.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void Loc(string giaListStr, string thuongHieuListStr, string soGheListStr)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("p_LocXe", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@GiaList", (object)giaListStr ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ThuongHieuList", (object)thuongHieuListStr ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SoGheList", (object)soGheListStr ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                dgvXeChoThue.DataSource = dt;
            }

            // Ẩn pnlLoc
            pnlLoc.Visible = false;
            if (currentFormchild != null)
            {
                currentFormchild.Close();
                currentFormchild = null;
            }
        }

        private void AddButtonsToDataGridView()
        {
            DataGridViewButtonColumn buttonColumnChiTietXe = new DataGridViewButtonColumn();
            buttonColumnChiTietXe.HeaderText = ""; // Tiêu đề cột
            buttonColumnChiTietXe.Text = "Chi tiết xe"; // Văn bản hiển thị trên nút
            buttonColumnChiTietXe.UseColumnTextForButtonValue = true; // Sử dụng văn bản cột cho tất cả các nút
            buttonColumnChiTietXe.Name = "ChiTietXe"; // Đặt tên cho cột
            dgvXeChoThue.Columns.Add(buttonColumnChiTietXe);
            buttonColumnChiTietXe.DisplayIndex = dgvXeChoThue.Columns.Count - 1;
        }

        private void dgvXeChoThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvXeChoThue.Columns["ChiTietXe"].Index)
            {
                int maXe = Convert.ToInt32(dgvXeChoThue.Rows[e.RowIndex].Cells["MaXe"].Value);

                if (maXe != null)
                {
                    FChiTietXe chiTietXeForm = new FChiTietXe(maXe);
                    chiTietXeForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
