using CarRentalBroker.Models;
using DBMS_CarRentalBroker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalBroker.Dao
{
    internal class NguoiDungDao
    {
        DBConnect db = new DBConnect();
       public NguoiDung layNguoiDung(int maND)
       {
            string sqlString = String.Format("SELECT * FROM NguoiDung WHERE MaND = {0}", maND);
            DataTable dataTable = db.thucThiDataTable(sqlString);

            NguoiDung nguoiDung = new NguoiDung();
            nguoiDung.MaND = Convert.ToInt32(dataTable.Rows[0]["MaND"]);
            nguoiDung.MaVT = Convert.ToInt32(dataTable.Rows[0]["MaVT"]);
            nguoiDung.HoTen = dataTable.Rows[0]["HoTen"].ToString();
            nguoiDung.NgaySinh = Convert.ToDateTime(dataTable.Rows[0]["NgaySinh"]);
            nguoiDung.CCCD = dataTable.Rows[0]["CCCD"].ToString();
            nguoiDung.Email = dataTable.Rows[0]["Email"].ToString();
            nguoiDung.DiaChi = dataTable.Rows[0]["DiaChi"].ToString();
            nguoiDung.QuocTich = dataTable.Rows[0]["QuocTich"].ToString();
            nguoiDung.SoDienThoai = dataTable.Rows[0]["SoDienThoai"].ToString();
            nguoiDung.SoGPLX = dataTable.Rows[0]["SoGPLX"].ToString();
            nguoiDung.MaTKNH = !(dataTable.Rows[0]["MaTKNH"] is DBNull) ? Convert.ToInt32(dataTable.Rows[0]["MaTKNH"]) : 0;

            return nguoiDung;
       }

        public void themNguoiDung(NguoiDung nguoiDung, TaiKhoan taiKhoan)
        {
            string sqlString = String.Format("EXEC dbo.pro_ThemNguoiDung '{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}', N'{6}', '{7}', '{8}', '{9}', '{10}'",
                               nguoiDung.MaVT, nguoiDung.HoTen, nguoiDung.NgaySinh.ToString("yyyy-MM-dd"), nguoiDung.CCCD, nguoiDung.Email, nguoiDung.DiaChi, nguoiDung.QuocTich, nguoiDung.SoDienThoai, nguoiDung.SoGPLX, taiKhoan.TenDangNhap, taiKhoan.MatKhau);
            db.thucThi(sqlString);
        }

        public void suaNguoiDung(NguoiDung nguoiDung, TaiKhoan taiKhoan)
        {
            string sqlString = String.Format("EXEC dbo.pro_CapNhatNguoiDung '{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}', N'{6}', '{7}', '{8}', '{9}', '{10}'",
                                                  nguoiDung.MaND, nguoiDung.HoTen, nguoiDung.NgaySinh.ToString("yyyy-MM-dd"), nguoiDung.CCCD, nguoiDung.Email, nguoiDung.DiaChi, nguoiDung.QuocTich, nguoiDung.SoDienThoai, nguoiDung.SoGPLX, taiKhoan.TenDangNhap, taiKhoan.MatKhau);
            db.thucThi(sqlString);
        }

        public void xoaNguoiDung(int maND, int maVT, string tenDangNhap)
        {
            string sqlString = String.Format("EXEC dbo.pro_XoaNguoiDung {0}, {1}, {2}", maND, maVT, tenDangNhap);
            db.thucThi(sqlString);
        }

        public void timKiemNguoiDung(DataGridView dgv, string tuKhoa)
        {
            string sqlString = String.Format("SELECT * FROM func_TimKiemNguoiDung(N'{0}')", tuKhoa);
            dgv.DataSource = db.thucThiDataTable(sqlString);
        }
    }
}
