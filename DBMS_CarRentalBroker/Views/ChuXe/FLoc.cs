using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FLoc : Form
    {
        public FLoc()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
        }

        private void KhoiTaoDuLieu()
        {
            clbTheoGia.Items.Add("Dưới 300");
            clbTheoGia.Items.Add("300-700");
            clbTheoGia.Items.Add("Trên 700");


            clbTheoHang.Items.Add("Vinfast");
            clbTheoHang.Items.Add("Toyota");
            clbTheoHang.Items.Add("Honda");

            clbSoGhe.Items.Add("2");
            clbSoGhe.Items.Add("5");
            clbSoGhe.Items.Add("7");
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string giaListStr = clbTheoGia.CheckedItems.Count > 0
                ? string.Join(",", clbTheoGia.CheckedItems.Cast<string>())
                : null;

            string thuongHieuListStr = clbTheoHang.CheckedItems.Count > 0
                ? string.Join(",", clbTheoHang.CheckedItems.Cast<string>())
                : null;

            string soGheListStr = clbSoGhe.CheckedItems.Count > 0
                ? string.Join(",", clbSoGhe.CheckedItems.Cast<string>())
                : null;

            if (this.Owner is FXeChoThue parentForm)
            {
                parentForm.Loc(giaListStr, thuongHieuListStr, soGheListStr);
            }

            this.Close();
        }

    }
}
