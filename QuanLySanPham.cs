using GUI.Models;
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
    public partial class QuanLySanPham : Form
    {
        private DA1QLBGContext DA1 = new DA1QLBGContext();
        private DataTable dt = new DataTable();

        private int indexDangChon = -1;
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            var Sanpham = DA1.SanPhams.ToList();
            foreach (var SP in Sanpham)
            {
                DataRow dr = dt.NewRow();
                dr["MaSP"] = SP.MaSp;
                dr["TenSP"] = SP.TenSp;
                dr["SoLuong"] = SP.SoLuong;
                dr["ChatLieu"] = SP.ChatLieu;
                dr["KichCo"] = SP.KichCo;
                dr["MauSac"] = SP.MauSac;
                dr["GiaBan"] = SP.GiaBan;
                dr["TrangThai"] = SP.TrangThai;
                dt.Rows.Add(dr);
            }
            dgvSanPham.DataSource = dt;
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("MaSP", typeof(int));
            dt.Columns.Add("TenSp", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("ChatLieu", typeof(string));
            dt.Columns.Add("KichCo", typeof(int));
            dt.Columns.Add("MauSac", typeof(string));
            dt.Columns.Add("GiaBan", typeof(decimal));
            dt.Columns.Add("TrangThai", typeof(bool));
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dongHienTai = dgvSanPham.Rows[e.RowIndex];
            var MaSP = dongHienTai.Cells[0].Value;
            var TenSP = dongHienTai.Cells[1].Value;
            var SoLuong = dongHienTai.Cells[2].Value;
            var ChatLieu = dongHienTai.Cells[3].Value;
            var KichCo = dongHienTai.Cells[4].Value;
            var MauSac = dongHienTai.Cells[5].Value;
            var GiaBan = dongHienTai.Cells[6].Value;
            var TrangThai = (bool)dongHienTai.Cells[7].Value;

            txtMaSP.Text = MaSP.ToString();
            txtTenSP.Text = TenSP.ToString();
            txtSoLuong.Text = SoLuong.ToString();
            cbbChatLieu.Text = ChatLieu.ToString();
            cbbKichCo.Text = KichCo.ToString();
            cbbMauSac.Text = MauSac.ToString();
            txtGiaBan.Text = GiaBan.ToString();
            if (TrangThai == true)
            {
                rdoCon.Checked = true;
            }
            else
            {
                rdoHet.Checked = true;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xác định giá trị của TrangThai dựa trên RadioButton được chọn
            bool trangThai = rdoCon.Checked; // Giả sử rbConHang là RadioButton cho "Còn hàng"

            SanPham newSanpham = new SanPham
            {
                TenSp = txtTenSP.Text,
                SoLuong = int.Parse(txtSoLuong.Text),
                ChatLieu = cbbChatLieu.Text,
                KichCo = int.Parse(cbbKichCo.Text),
                MauSac = cbbMauSac.Text,
                GiaBan = decimal.Parse(txtGiaBan.Text),
                TrangThai = trangThai // Đặt giá trị TrangThai
            };

            DA1.SanPhams.Add(newSanpham);
            DA1.SaveChanges();

            DataRow dr = dt.NewRow();
            dr["MaSP"] = newSanpham.MaSp; // Đảm bảo MaSp được tự động tạo (auto-increment) trong SQL Server
            dr["TenSp"] = newSanpham.TenSp;
            dr["SoLuong"] = newSanpham.SoLuong;
            dr["ChatLieu"] = newSanpham.ChatLieu;
            dr["KichCo"] = newSanpham.KichCo;
            dr["MauSac"] = newSanpham.MauSac;
            dr["GiaBan"] = newSanpham.GiaBan;
            dr["TrangThai"] = newSanpham.TrangThai; // Thêm trường TrangThai vào DataRow
            dt.Rows.Add(dr);

            dgvSanPham.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có hàng nào được chọn trong DataGridView
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
                return;
            }

            // Lấy mã sản phẩm từ hàng được chọn
            int maSanPhamDuocChon = (int)dgvSanPham.SelectedRows[0].Cells["MaSP"].Value;

            // Tìm sản phẩm trong cơ sở dữ liệu
            var sanPhamCanSua = DA1.SanPhams.FirstOrDefault(p => p.MaSp == maSanPhamDuocChon);
            if (sanPhamCanSua != null)
            {
                // Cập nhật các thuộc tính của sản phẩm với giá trị mới từ các trường nhập liệu
                sanPhamCanSua.TenSp = txtTenSP.Text;
                sanPhamCanSua.SoLuong = int.Parse(txtSoLuong.Text);
                sanPhamCanSua.ChatLieu = cbbChatLieu.Text;
                sanPhamCanSua.KichCo = int.Parse(cbbKichCo.Text);
                sanPhamCanSua.MauSac = cbbMauSac.Text;
                sanPhamCanSua.GiaBan = decimal.Parse(txtGiaBan.Text);

                // Xác định giá trị của TrangThai dựa trên RadioButton được chọn
                sanPhamCanSua.TrangThai = rdoCon.Checked; // Giả sử rdoCon là RadioButton cho "Còn hàng"

                // Lưu các thay đổi vào cơ sở dữ liệu
                DA1.SaveChanges();

                // Cập nhật hàng tương ứng trong DataGridView
                DataGridViewRow row = dgvSanPham.SelectedRows[0];
                row.Cells["TenSp"].Value = sanPhamCanSua.TenSp;
                row.Cells["SoLuong"].Value = sanPhamCanSua.SoLuong;
                row.Cells["ChatLieu"].Value = sanPhamCanSua.ChatLieu;
                row.Cells["KichCo"].Value = sanPhamCanSua.KichCo;
                row.Cells["MauSac"].Value = sanPhamCanSua.MauSac;
                row.Cells["GiaBan"].Value = sanPhamCanSua.GiaBan;
                row.Cells["TrangThai"].Value = sanPhamCanSua.TrangThai;

                // Làm mới DataGridView (có thể không cần thiết nếu DataGridView đã cập nhật)
                dgvSanPham.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm để sửa.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }

            var ketQuaTimKiem = DA1.SanPhams
                .Where(sp => sp.TenSp.Contains(tuKhoa) ||
                             sp.ChatLieu.Contains(tuKhoa) ||
                             sp.KichCo.ToString().Contains(tuKhoa) ||
                             sp.MauSac.Contains(tuKhoa))
                .ToList();

            // Xóa các dòng cũ trong DataTable
            dt.Rows.Clear();

            // Thêm các dòng tìm được vào DataTable
            foreach (var SP in ketQuaTimKiem)
            {
                DataRow dr = dt.NewRow();
                dr["MaSP"] = SP.MaSp;
                dr["TenSp"] = SP.TenSp;
                dr["SoLuong"] = SP.SoLuong;
                dr["ChatLieu"] = SP.ChatLieu;
                dr["KichCo"] = SP.KichCo;
                dr["MauSac"] = SP.MauSac;
                dr["GiaBan"] = SP.GiaBan;
                dr["TrangThai"] = SP.TrangThai;
                dt.Rows.Add(dr);
            }

            // Làm mới DataGridView
            dgvSanPham.DataSource = dt;
        }
    }
}
