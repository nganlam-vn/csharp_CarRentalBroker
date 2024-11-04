using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker.Models
{
    internal class BangGiaThue
    {
        private int maBG;
        private int maXe;
        private float theoGio;
        private float theoNgay;
        private float theoThang;

        public int MaBG { get => maBG; set => maBG = value; }
        public int MaXe { get => maXe; set => maXe = value; }
        public float TheoGio { get => theoGio; set => theoGio = value; }
        public float TheoNgay { get => theoNgay; set => theoNgay = value; }
        public float TheoThang { get => theoThang; set => theoThang = value; }
    }
}
