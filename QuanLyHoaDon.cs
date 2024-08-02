using GUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLyHoaDon : Form
    {
        private DA1QLBGContext context = new DA1QLBGContext();
        private DataTable dt = new DataTable();
        private ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
        private HoaDon hoaDon = new HoaDon();
        private KhachHang khachHang = new KhachHang();
        private NhanVien nhanVien = new NhanVien();
        private SanPham sanPham = new SanPham();
        private Voucher voucher = new Voucher();


        public QuanLyHoaDon()
        {
            InitializeComponent();

        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("MaSp", typeof(int));
            dt.Columns.Add("TenSp", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("ChatLieu", typeof(string));
            dt.Columns.Add("KichCo", typeof(int));
            dt.Columns.Add("MauSac", typeof(string));
            dt.Columns.Add("GiaBan", typeof(decimal));
            dt.Columns.Add("TrangThai", typeof(bool));
        }

        private void btnShowSP_Click(object sender, EventArgs e)
        {
            var sanPhams = context.SanPhams.ToList();
            foreach (var sp in sanPhams)
            {
                DataRow dr = dt.NewRow();
                dr["MaSp"] = sp.MaSp;
                dr["TenSp"] = sp.TenSp;
                dr["SoLuong"] = sp.SoLuong;
                dr["ChatLieu"] = sp.ChatLieu;
                dr["KichCo"] = sp.KichCo;
                dr["MauSac"] = sp.MauSac;
                dr["GiaBan"] = sp.GiaBan;
                dr["TrangThai"] = sp.TrangThai;
                dt.Rows.Add(dr);
            }
            dgvdanhSachSanPham.DataSource = dt;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            if (!string.IsNullOrEmpty(sdt))
            {
                var khachHang = context.KhachHangs.FirstOrDefault(kh => kh.Sdt == sdt);
                if (khachHang != null)
                {
                    txtTenKhachHang.Text = khachHang.TenKh;
                }
                else
                {
                    txtTenKhachHang.Clear();

                }
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            string tenKhachHang = txtTenKhachHang.Text;

            var hoaDon = new HoaDon
            {
                NgayBan = DateTime.Now,
                MaKh = context.KhachHangs.FirstOrDefault(kh => kh.Sdt == sdt).MaKh,
                TenKh = tenKhachHang,
                DchiKh = "...",
                Sdtkh = sdt,

            };

            context.HoaDons.Add(hoaDon);
            context.SaveChanges();

            cbbHoaDon.Items.Add(hoaDon);

        }

        private void dgvHoaDonCho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvdanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvdanhSachSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the row that was double-clicked
                DataGridViewRow row = dgvdanhSachSanPham.Rows[e.RowIndex];

                // Get the product information
                int maSp = Convert.ToInt32(row.Cells["MaSp"].Value);
                string tenSp = row.Cells["TenSp"].Value.ToString();
                int availableQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);

                // Show the input dialog for quantity
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Nhập số lượng {tenSp}:",
                    "Thông báo",
                    "0", // Default value
                    -1,  // X position of the input box
                    -1   // Y position of the input box
                );

                // Validate the input
                if (int.TryParse(input, out int quantity) && quantity > 0)
                {
                    if (quantity <= availableQuantity)
                    {
                        // Add the product to the invoice DataGridView
                        AddProductToInvoice(row, quantity);

                        // Decrement the quantity in the products DataGridView
                        row.Cells["SoLuong"].Value = availableQuantity - quantity;

                        // Optionally, you might want to refresh the DataGridView to show updated data
                        dgvdanhSachSanPham.Refresh();

                        MessageBox.Show($"Thêm thành công: {quantity}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không đủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddProductToInvoice(DataGridViewRow row, int quantity)
        {
            DataTable dt = (DataTable)dgvHoaDonCho.DataSource ?? InitializeHoaDonDataTable();

            // Kiểm tra nếu sản phẩm đã tồn tại trong DataTable
            DataRow existingRow = dt.AsEnumerable()
                .FirstOrDefault(r => r.Field<int>("MaSp") == Convert.ToInt32(row.Cells["MaSp"].Value));

            if (existingRow != null)
            {
                // Nếu đã tồn tại, cập nhật số lượng
                existingRow["SoLuong"] = Convert.ToInt32(existingRow["SoLuong"]) + quantity;
            }
            else
            {
                // Tạo một hàng mới
                DataRow dr = dt.NewRow();
                dr["MaSp"] = Convert.ToInt32(row.Cells["MaSp"].Value);
                dr["TenSp"] = row.Cells["TenSp"].Value.ToString();
                dr["SoLuong"] = quantity;
                dr["ChatLieu"] = row.Cells["ChatLieu"].Value.ToString();
                dr["KichCo"] = Convert.ToInt32(row.Cells["KichCo"].Value);
                dr["MauSac"] = row.Cells["MauSac"].Value.ToString();
                dr["GiaBan"] = Convert.ToDecimal(row.Cells["GiaBan"].Value);
                dr["TrangThai"] = Convert.ToBoolean(row.Cells["TrangThai"].Value);

                // Thêm hàng mới vào DataTable
                dt.Rows.Add(dr);
            }

            // Cập nhật DataGridView với DataTable
            dgvHoaDonCho.DataSource = dt;

            // Cập nhật tổng tiền
            UpdateTotalAmount();
        }

        private void cbbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            // Lấy DataTable từ DataGridView
            DataTable dt = (DataTable)dgvHoaDonCho.DataSource;

            if (dt != null)
            {
                // Duyệt qua các hàng để tính tổng tiền
                foreach (DataRow row in dt.Rows)
                {
                    int quantity = Convert.ToInt32(row["SoLuong"]);
                    decimal price = Convert.ToDecimal(row["GiaBan"]);
                    totalAmount += quantity * price;
                }
            }

            // Cập nhật lblTongTien với tổng tiền tính được
            lblTongTien.Text = $"Tổng Tiền: {totalAmount}"; // Sử dụng định dạng tiền tệ
        }
        private DataTable InitializeHoaDonDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSp", typeof(int));
            dt.Columns.Add("TenSp", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("ChatLieu", typeof(string));
            dt.Columns.Add("KichCo", typeof(int));
            dt.Columns.Add("MauSac", typeof(string));
            dt.Columns.Add("GiaBan", typeof(decimal));
            dt.Columns.Add("TrangThai", typeof(bool));
            return dt;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu tổng tiền đã được tính
            if (string.IsNullOrEmpty(lblTongTien.Text) || lblTongTien.Text == "Tổng Tiền: 0")
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tổng tiền từ lblTongTien
            string totalAmountText = lblTongTien.Text.Replace("Tổng Tiền: ", "").Replace("C", "").Trim();
            if (!decimal.TryParse(totalAmountText, out decimal totalAmount))
            {
                MessageBox.Show("Không thể đọc tổng tiền. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy số tiền khách đưa vào
            if (!decimal.TryParse(txtTienKhach.Text, out decimal amountGiven))
            {
                MessageBox.Show("Số tiền khách đưa vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính số tiền thừa
            decimal amountToReturn = amountGiven - totalAmount;

            if (amountToReturn < 0)
            {
                MessageBox.Show("Số tiền khách đưa vào không đủ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTraLai.Text = "Số Tiền Trả Lại: 0";
            }
            else
            {
                // Cập nhật lblTraLai với số tiền thừa
                lblTraLai.Text = $"{amountToReturn:C}";
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong DataGridView dgvHoaDonCho
            dgvHoaDonCho.DataSource = null;

            // Xóa nội dung của lblTongTien
            lblTongTien.Text = "0";

            // Xóa nội dung của txtTienKhach
            txtTienKhach.Clear();

            // Xóa nội dung của lblTraLai
            lblTraLai.Text = "0";

            // Hiển thị thông báo hoàn tất
            MessageBox.Show("Hoàn Tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong DataGridView dgvHoaDonCho
            dgvHoaDonCho.DataSource = null;

            // Xóa nội dung của lblTongTien
            lblTongTien.Text = "0";

            // Xóa nội dung của txtTienKhach
            txtTienKhach.Clear();

            // Xóa nội dung của lblTraLai
            lblTraLai.Text = "0D";

            // Cập nhật lại số lượng sản phẩm trong dgvdanhSachSanPham
            UpdateProductQuantities();

            // Hiển thị thông báo hoàn tác thành công
            MessageBox.Show("Hoàn tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateProductQuantities()
        {
            // Lấy DataTable từ dgvHoaDonCho
            DataTable dtHoaDon = (DataTable)dgvHoaDonCho.DataSource;

            if (dtHoaDon != null)
            {
                // Lặp qua từng dòng của DataTable hóa đơn
                foreach (DataRow row in dtHoaDon.Rows)
                {
                    int maSp = row.Field<int>("MaSp");
                    int quantity = row.Field<int>("SoLuong");

                    // Tìm sản phẩm trong dgvdanhSachSanPham
                    foreach (DataGridViewRow productRow in dgvdanhSachSanPham.Rows)
                    {
                        if (Convert.ToInt32(productRow.Cells["MaSp"].Value) == maSp)
                        {
                            // Cập nhật lại số lượng sản phẩm
                            int availableQuantity = Convert.ToInt32(productRow.Cells["SoLuong"].Value);
                            productRow.Cells["SoLuong"].Value = availableQuantity + quantity;
                            break;
                        }
                    }
                }
            }
            RefreshProductList();
        }
        private void RefreshProductList()
        {
            // Tải lại danh sách sản phẩm từ cơ sở dữ liệu hoặc từ nguồn dữ liệu gốc
            var sanPhams = context.SanPhams.ToList();
            dt.Clear(); // Xóa dữ liệu hiện tại trong DataTable dt

            foreach (var sp in sanPhams)
            {
                DataRow dr = dt.NewRow();
                dr["MaSp"] = sp.MaSp;
                dr["TenSp"] = sp.TenSp;
                dr["SoLuong"] = sp.SoLuong;
                dr["ChatLieu"] = sp.ChatLieu;
                dr["KichCo"] = sp.KichCo;
                dr["MauSac"] = sp.MauSac;
                dr["GiaBan"] = sp.GiaBan;
                dr["TrangThai"] = sp.TrangThai;
                dt.Rows.Add(dr);
            }

            // Cập nhật lại DataGridView dgvdanhSachSanPham
            dgvdanhSachSanPham.DataSource = dt;
        }
    }
}
        
