using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Lop { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }

        public SinhVien()
        {

        }

        public SinhVien(string maso, string ht, DateTime ns, bool gt, string sdt, string lop, string email, string diachi, string hinh)
        {
            this.MaSo = MaSo;
            this.HoTen = ht;
            this.NgaySinh = ns;
            this.GioiTinh = gt;
            this.SoDienThoai = sdt;
            this.Lop = lop;
            this.Email = email;
            this.DiaChi = diachi;
            this.Hinh = hinh;
        }

    }
}

