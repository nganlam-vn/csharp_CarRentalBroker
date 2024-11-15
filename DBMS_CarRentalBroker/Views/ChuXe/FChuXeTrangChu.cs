using CarRentalBroker.Dao;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FChuXeTrangChu : Form
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";
        //int maND = Global.maND;
        int maND = Global.MaND;
        private Form currentFormchild;
        TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
        public FChuXeTrangChu()
        {
            InitializeComponent();
            OpenChildForm(new FXeChoThue());
            LoadSoDu();
        }


        private void OpenChildForm(Form childForm)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }

            currentFormchild = childForm;
            childForm.TopLevel = false; // Đặt TopLevel là false để nó có thể được nhúng vào panel
            childForm.FormBorderStyle = FormBorderStyle.None; // Xóa viền của form
            childForm.Dock = DockStyle.Fill; // Chiếm toàn bộ panel

            pnlChuXeTrangChu.Controls.Add(childForm); // Thêm form vào panel
            pnlChuXeTrangChu.Tag = childForm; // Lưu form vào tag
            childForm.BringToFront(); // Đưa form lên trên cùng
            childForm.Show(); // Hiển thị form
        }

        private void LoadSoDu()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_LaySoDuVi", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaND", maND);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    decimal soDu = Convert.ToDecimal(result);
                    lblSoDu.Text = soDu.ToString("N0") + " VND";
                }
                else
                {
                    lblSoDu.Text = "Không có số dư";
                }

                connection.Close();
            }
        }



        private void btnXeChoThue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FXeChoThue());
        }

        private void btnXeCuaToi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FXeCuaToi());
        }

        private void btnTrangThaiDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTrangThaiDangKy());
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLichSuChoThue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuChoThue());

        }

        private void btnLichSuThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuThanhToan());

        }

        private void UpdateBalanceDisplay()
        {
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();

            FDangNhap fDangNhap = new FDangNhap();
            fDangNhap.ShowDialog();

            Application.Exit();
        }

        private void FChuXeTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            taiKhoanDao.dangXuat();
        }
    }
}
