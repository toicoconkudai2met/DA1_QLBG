using System;
using System.Collections.Generic;

namespace GUI.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaKh { get; set; }
        public string TenKh { get; set; } = null!;
        public bool GioiTinh { get; set; }
        public string Sdt { get; set; } = null!;
        public bool PhanLoaiKh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Dchi { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
