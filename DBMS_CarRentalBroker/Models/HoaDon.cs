using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker.Models
{
    internal class HoaDon
    {
        private int maHoaDon;
        private int? maHopDong;
        private int? maPhi;
        private float soTien;
        private DateTime ngayChuyen;
        private string noiDung;

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int? MaHopDong { get => maHopDong; set => maHopDong = value; }
        public int? MaPhi { get => maPhi; set => maPhi = value; }
        public float SoTien { get => soTien; set => soTien = value; }
        public DateTime NgayChuyen { get => ngayChuyen; set => ngayChuyen = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
    }
}
