using GUI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
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
    public partial class QuanLyKhachHang : Form
    {
        private DA1QLBGContext context = new DA1QLBGContext();
        private DataTable dt = new DataTable();
        private int indexdangchon = -1;
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnhienthikh_Click(object sender, EventArgs e)
        {

            var khachhang = context.KhachHangs.ToList();
            foreach (var kh in khachhang)
            {
                DataRow dr = dt.NewRow();
                dr["MaKh"] = kh.MaKh;
                dr["TenKh"] = kh.TenKh;
                dr["GioiTinh"] = kh.GioiTinh;
                dr["Sdt"] = kh.Sdt;
                dr["PhanLoaiKh"] = kh.PhanLoaiKh;
                dr["Ngaysinh"] = kh.Ngaysinh;
                dr["Dchi"] = kh.Dchi;
                dt.Rows.Add(dr);
            }
            dgvkh.DataSource = dt;
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("MaKh", typeof(int));
            dt.Columns.Add("TenKh", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(bool));
            dt.Columns.Add("Sdt", typeof(string));
            dt.Columns.Add("PhanLoaiKh", typeof(bool));
            dt.Columns.Add("Ngaysinh", typeof(DateTime));
            dt.Columns.Add("Dchi", typeof(string));
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang
            {
                // MaKh sẽ tự động tăng, không cần nhập từ người dùng
                TenKh = txttkh.Text,
                GioiTinh = rdonam.Checked, // Giả sử bạn có hai RadioButtons cho giới tính: rdonam và rdonu
                Sdt = txtsdtkh.Text,
                PhanLoaiKh = rdokhvip.Checked, // Giả sử bạn có hai RadioButtons cho phân loại khách hàng
                Ngaysinh = dtpkh.Value,
                Dchi = txtdckh.Text
            };

            // Thêm đối tượng KhachHang vào context và lưu thay đổi
            context.KhachHangs.Add(kh);
            context.SaveChanges();

            // Thêm một hàng mới vào DataTable
            DataRow dr = dt.NewRow();
            dr["MaKh"] = kh.MaKh; // MaKh sẽ được tự động cập nhật sau khi lưu vào cơ sở dữ liệu
            dr["TenKh"] = kh.TenKh;
            dr["GioiTinh"] = kh.GioiTinh;
            dr["Sdt"] = kh.Sdt;
            dr["PhanLoaiKh"] = kh.PhanLoaiKh;
            dr["Ngaysinh"] = kh.Ngaysinh;
            dr["Dchi"] = kh.Dchi;
            dt.Rows.Add(dr);

            // Cập nhật DataGridView
            dgvkh.DataSource = dt;


        }

        private void btnsuakh_Click(object sender, EventArgs e)
        {
            if (dgvkh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
                return;
            }

            // Lấy mã kh từ hàng được chọn
            int makhachhangduocchon = (int)dgvkh.SelectedRows[0].Cells["MaKh"].Value;

            // Tìm kh trong cơ sở dữ liệu
            var khachhangcansua = context.KhachHangs.FirstOrDefault(p => p.MaKh == makhachhangduocchon);
            if (khachhangcansua != null)
            {
                // Cập nhật các thuộc tính của sản phẩm với giá trị mới từ các trường nhập liệu
                khachhangcansua.TenKh = txttkh.Text;
                khachhangcansua.GioiTinh = rdonam.Checked;
                khachhangcansua.Sdt = txtsdtkh.Text;
                khachhangcansua.PhanLoaiKh = rdokhvip.Checked;
                khachhangcansua.Ngaysinh = dtpkh.Value;
                khachhangcansua.Dchi = txtdckh.Text;

                

                // Lưu các thay đổi vào cơ sở dữ liệu
                context.SaveChanges();

                // Cập nhật kh tương ứng trong DataGridView
                DataGridViewRow row = dgvkh.SelectedRows[0];
                row.Cells["MaKh"].Value = khachhangcansua.MaKh;
                row.Cells["TenKh"].Value = khachhangcansua.TenKh;
                row.Cells["GioiTinh"].Value = khachhangcansua.GioiTinh;
                row.Cells["Sdt"].Value = khachhangcansua.Sdt;
                row.Cells["PhanLoaiKh"].Value = khachhangcansua.PhanLoaiKh;
                row.Cells["Ngaysinh"].Value = khachhangcansua.Ngaysinh;
                row.Cells["Dchi"].Value = khachhangcansua.Dchi;

                // Làm mới DataGridView (có thể không cần thiết nếu DataGridView đã cập nhật)
                dgvkh.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm để sửa.");
            }
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvkh.Rows[e.RowIndex];

                // Retrieve values from the selected row
                var MaKh = row.Cells["MaKh"].Value.ToString();
                var TenKh = row.Cells["TenKh"].Value.ToString();
                var GioiTinh = (bool)row.Cells["GioiTinh"].Value;
                var Sdt = row.Cells["Sdt"].Value.ToString();
                var PhanLoaiKh = (bool)row.Cells["PhanLoaiKh"].Value;
                var Ngaysinh = (DateTime)row.Cells["Ngaysinh"].Value;
                var Dchi = row.Cells["Dchi"].Value.ToString();

                // Populate the text boxes and other controls
                txtmkh.Text = MaKh;
                txttkh.Text = TenKh;
                txtsdtkh.Text = Sdt;
                txtdckh.Text = Dchi;
                dtpkh.Value = Ngaysinh; // Set DateTimePicker value directly

                // Set radio buttons based on GioiTinh value
                if (GioiTinh)
                {
                    rdonam.Checked = true;
                }
                else
                {
                    rdonu.Checked = true;
                }
                if (PhanLoaiKh)
                {
                    rdokhvip.Checked = true;
                }
                else
                {
                    rdokht.Checked = true;
                }

                // Set ComboBox selection based on PhanLoaiKh value

            }
        }

        private void btntimkiemkh_Click(object sender, EventArgs e)
        {
            string keyword = txttimkiemkh.Text.ToLower();
            var filteredData = dt.AsEnumerable()
                .Where(row => row["TenKh"].ToString().ToLower().Contains(keyword) ||
                              row["Sdt"].ToString().ToLower().Contains(keyword) ||
                              row["Dchi"].ToString().ToLower().Contains(keyword));

            DataTable filteredTable = dt.Clone();
            foreach (var row in filteredData)
            {
                filteredTable.ImportRow(row);
            }

            dgvkh.DataSource = filteredTable;
        }
    }
}
    

