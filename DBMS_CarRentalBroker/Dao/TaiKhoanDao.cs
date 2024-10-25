using CarRentalBroker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalBroker.Dao
{
    internal class TaiKhoanDao
    {
        public bool kiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            DBConnect db = new DBConnect();
            String sqlString = String.Format("SELECT * FROM dbo.kiemTraDangNhap('{0}', '{1}')", TaiKhoan.tenDangNhap, TaiKhoan.matKhau);
            DataTable result;
            try
            {
                result = db.thucThiDataTable(sqlString);
                if (result.Rows.Count > 0)
                {
                    TaiKhoan.maND = Convert.ToInt32(result.Rows[0]["MaND"]);
                    TaiKhoan.maVT = Convert.ToInt32(result.Rows[0]["MaVT"]);
                    return true;
                }
            }
            catch 
            {
                throw new Exception("Sai tên đăng nhập hoặc mật khẩu!");
            }
            return false;
        }
    }
}
