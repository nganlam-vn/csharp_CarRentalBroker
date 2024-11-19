using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker.Models
{
    internal class PhiBaiDang
    {
        private int maPhi;
        private float soTien;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private int maXe;

        public int MaPhi { get => maPhi; set => maPhi = value; }
        public float SoTien { get => soTien; set => soTien = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int MaXe { get => maXe; set => maXe = value; }
    }
}
