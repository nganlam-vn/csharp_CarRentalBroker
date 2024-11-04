using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker.Models
{
    internal class HopDong
    {
        private int maHopDong;
        private DateTime ngayLap;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private float tongTien;
        private float phiDatXe;

        public int MaHopDong { get => maHopDong; set => maHopDong = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float PhiDatXe { get => phiDatXe; set => phiDatXe = value; }
    }
}
