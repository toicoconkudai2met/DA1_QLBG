using System;
using System.Collections.Generic;

namespace GUI.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaSp { get; set; }
        public string TenSp { get; set; } = null!;
        public int SoLuong { get; set; }
        public string ChatLieu { get; set; } = null!;
        public int KichCo { get; set; }
        public string MauSac { get; set; } = null!;
        public decimal GiaBan { get; set; }
        public bool TrangThai { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
