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
        DBConnect db = new DBConnect();
        public TaiKhoan layTaiKhoan(int maND)
        {
            String sqlString = String.Format("SELECT * FROM TaiKhoan WHERE MaND = {0}", maND);
            DataTable dataTable = db.thucThiDataTable(sqlString);

            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TenDangNhap = dataTable.Rows[0]["TenDangNhap"].ToString();
            taiKhoan.MatKhau = dataTable.Rows[0]["MatKhau"].ToString();
            taiKhoan.MaND = Convert.ToInt32(dataTable.Rows[0]["MaND"]);
            taiKhoan.MaVT = Convert.ToInt32(dataTable.Rows[0]["MaVT"]);

            return taiKhoan;
        }

        public bool dangNhap(TaiKhoan taiKhoan)
        {
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

        public void dangXuat()
        {
            string stringSQL = String.Format("EXEC dbo.pro_CapNhatDangXuat");
            db.thucThi(stringSQL);
        }
    }
}
