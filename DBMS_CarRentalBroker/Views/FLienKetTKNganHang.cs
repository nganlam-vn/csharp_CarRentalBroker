using CarRentalBroker;
using DBMS_CarRentalBroker.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views
{
    public partial class FLienKetTKNganHang : Form
    {
        DBConnect db = new DBConnect();
        public FLienKetTKNganHang()
        {
            InitializeComponent();
            loadNganHang();
        }


        private void loadNganHang()
        {
            string sqlString = "SELECT * FROM NganHang";
            DataTable dt = db.thucThiDataTable(sqlString);
            cbNganHang.DataSource = dt;
            cbNganHang.DisplayMember = "Ten";
            cbNganHang.ValueMember = "MaNH";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int maNH = Convert.ToInt32(cbNganHang.SelectedValue);
            string soTK = tbSTK.Text;
            string tenTK = tbTenTK.Text;
            int soDu = Convert.ToInt32(tbSoTien.Text);

            string sqlString = String.Format("EXEC pro_LienKetNganHang '{0}', '{1}', '{2}', '{3}', '{4}'", Global.maND, maNH, soTK, tenTK, soDu);
            db.thucThi(sqlString);
            MessageBox.Show("Liên kết tài khoản ngân hàng thành công");
            this.Close();
        }
    }
}
