using CarRentalBroker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalBroker.Dao
{
    internal class NguoiDungDao
    {
        public void dangKy(String tenDangNhap, String matKhau, NguoiDung nguoiDung)
        {
            DBConnect db = new DBConnect();
            String sqlString = String.Format("EXEC dbo.themNguoiDung '{0}', '{1}', '{2}', N'{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}'", tenDangNhap, matKhau, nguoiDung.MaVT, nguoiDung.HoTen, nguoiDung.NgaySinh, nguoiDung.CCCD, nguoiDung.Email, nguoiDung.DiaChi, nguoiDung.QuocTich, nguoiDung.SoDienThoai, nguoiDung.SoGPLX);
            try
            {
                db.thucThi(sqlString);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
