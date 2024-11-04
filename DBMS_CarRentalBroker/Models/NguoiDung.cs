using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBroker.Models
{
    internal class NguoiDung
    {
        private int maND;
        private int maVT;
        private string hoTen;
        private DateTime ngaySinh;
        private string cccd;
        private string email;
        private string diaChi;
        private string quocTich;
        private string soDienThoai;
        private string soGPLX;
        private int? maTKNH;

        public int MaND { get => maND; set => maND = value; }
        public int MaVT { get => maVT; set => maVT = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string CCCD { get => cccd; set => cccd = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string SoGPLX { get => soGPLX; set => soGPLX = value; }
        public int? MaTKNH { get => maTKNH; set => maTKNH = value; }
    }
}
