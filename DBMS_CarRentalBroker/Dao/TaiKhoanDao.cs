using DBMS_CarRentalBroker.Common;
using DBMS_CarRentalBroker.Models;
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
        public bool dangNhap(TaiKhoan taiKhoan)
        {
            DBConnect db = new DBConnect();
            String sqlString = String.Format("EXEC dbo.pro_ThemLichSuDangNhap '{0}', '{1}'", taiKhoan.TenDangNhap, taiKhoan.MatKhau);
            DataTable result;
            try
            {
                db.thucThi(sqlString);
                sqlString = String.Format("SELECT * FROM dbo.func_KiemTraDangNhap('{0}', '{1}')", taiKhoan.TenDangNhap, taiKhoan.MatKhau);
                result = db.thucThiDataTable(sqlString);
                if (result.Rows.Count > 0)
                {
                    Global.TenDangNhap = taiKhoan.TenDangNhap;
                    Global.MatKhau = taiKhoan.MatKhau;
                    Global.MaND = int.Parse(result.Rows[0]["MaND"].ToString());
                    Global.MaVT = int.Parse(result.Rows[0]["MaVT"].ToString());
                    return true;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return false;
        }
    }
}
