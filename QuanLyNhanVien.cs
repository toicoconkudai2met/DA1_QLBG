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
    public partial class QuanLyNhanVien : Form
    {
        private DA1QLBGContext DA1 = new DA1QLBGContext();
        private DataTable dt = new DataTable();
        private int indexDangChon = -1;
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            var Nhanvien = DA1.NhanViens.ToList();
            foreach (var NV in Nhanvien)
            {
                DataRow dr = dt.NewRow();
                dr["MaNV"] = NV.MaNv;
                dr["TenNV"] = NV.TenNv;
                dr["GioiTinh"] = NV.GioiTinh;
                dr["Sdt"] = NV.Sdt;
                dr["Calam"] = NV.Calam;
                dr["Ngaysinh"] = NV.Ngaysinh;
                dr["Dchi"] = NV.Dchi;
                dr["TrangThaiNv"] = NV.TrangThaiNv;
                dt.Rows.Add(dr);
            }
            dgv_nhanvien.DataSource = dt;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("MaNV", typeof(int));
            dt.Columns.Add("TenNV", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(bool));
            dt.Columns.Add("Sdt", typeof(string));
            dt.Columns.Add("Calam", typeof(string));
            dt.Columns.Add("Ngaysinh", typeof(DateTime));
            dt.Columns.Add("Dchi", typeof(string));
            dt.Columns.Add("TrangThaiNv", typeof(bool));
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có dòng nào được chọn không
            {
                var dongHienTai = dgv_nhanvien.Rows[e.RowIndex];
                var MaNV = dongHienTai.Cells[0].Value;
                var TenNV = dongHienTai.Cells[1].Value;
                var Gioitinh = (bool)dongHienTai.Cells[2].Value;
                var Sodt = dongHienTai.Cells[3].Value;
                var Calam = dongHienTai.Cells[4].Value;
                var Ngaysinh = (DateTime)dongHienTai.Cells[5].Value;
                var diachi = dongHienTai.Cells[6].Value;
                var TrangThai = (bool)dongHienTai.Cells[7].Value;

                txt_manv.Text = MaNV.ToString();
                txt_tennv.Text = TenNV.ToString();
                txt_diachi.Text = diachi.ToString(); // Sửa lại để gán giá trị đúng cho địa chỉ

                if (Gioitinh)
                {
                    rb_nam.Checked = true;
                }
                else
                {
                    rb_nu.Checked = true;
                }

                txt_sdtnv.Text = Sodt.ToString();
                cb_calam.Text = Calam.ToString();
                dtp_ngaysinhnv.Value = Ngaysinh; // Sửa lại để gán giá trị đúng cho NgaySinh

                if (TrangThai)
                {
                    rb_danglam.Checked = true;
                }
                else
                {
                    rb_nghiviec.Checked = true;
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Xác định giá trị của TrangThai dựa trên RadioButton được chọn
            bool trangThai = rb_danglam.Checked;

            // Tạo đối tượng NhanVien mới
            NhanVien newNhanVien = new NhanVien
            {
                //MaNv = int.Parse(txt_manv.Text), // Nếu MaNv không phải auto-increment, hãy nhập vào từ người dùng
                TenNv = txt_tennv.Text,
                GioiTinh = rb_nam.Checked ? true : false,
                Sdt = txt_sdtnv.Text,
                Calam = cb_calam.Text,
                Ngaysinh = dtp_ngaysinhnv.Value,
                Dchi = txt_diachi.Text,
                TrangThaiNv = trangThai
            };

            // Thêm nhân viên mới vào cơ sở dữ liệu
            DA1.NhanViens.Add(newNhanVien);
            DA1.SaveChanges();

            // Tạo DataRow mới và thêm dữ liệu vào DataTable
            DataRow dr = dt.NewRow();
            dr["MaNv"] = newNhanVien.MaNv; // Đảm bảo MaNv được tự động tạo (auto-increment) trong SQL Server nếu có
            dr["TenNv"] = newNhanVien.TenNv;
            dr["GioiTinh"] = newNhanVien.GioiTinh;
            dr["Sdt"] = newNhanVien.Sdt;
            dr["CaLam"] = newNhanVien.Calam;
            dr["NgaySinh"] = newNhanVien.Ngaysinh;
            dr["Dchi"] = newNhanVien.Dchi;
            dr["TrangThaiNv"] = newNhanVien.TrangThaiNv;
            dt.Rows.Add(dr);

            // Cập nhật DataGridView
            dgv_nhanvien.DataSource = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgv_nhanvien.SelectedRows.Count > 0)
            {
                // Lấy dòng hiện tại được chọn
                var dongHienTai = dgv_nhanvien.SelectedRows[0];

                // Lấy mã nhân viên từ dòng được chọn
                int maNv = (int)dongHienTai.Cells[0].Value;

                // Tìm nhân viên trong cơ sở dữ liệu dựa trên mã nhân viên
                var nhanVien = DA1.NhanViens.FirstOrDefault(nv => nv.MaNv == maNv);

                if (nhanVien != null)
                {
                    // Cập nhật các thuộc tính của nhân viên
                    nhanVien.TenNv = txt_tennv.Text;
                    nhanVien.GioiTinh = rb_nam.Checked;
                    nhanVien.Sdt = txt_sdtnv.Text;
                    nhanVien.Calam = cb_calam.Text;
                    nhanVien.Ngaysinh = dtp_ngaysinhnv.Value;
                    nhanVien.Dchi = txt_diachi.Text;
                    nhanVien.TrangThaiNv = rb_danglam.Checked;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    DA1.SaveChanges();

                    // Cập nhật DataTable
                    var dr = dt.AsEnumerable().FirstOrDefault(row => (int)row["MaNV"] == maNv);
                    if (dr != null)
                    {
                        dr["TenNV"] = nhanVien.TenNv;
                        dr["GioiTinh"] = nhanVien.GioiTinh;
                        dr["Sdt"] = nhanVien.Sdt;
                        dr["Calam"] = nhanVien.Calam;
                        dr["Ngaysinh"] = nhanVien.Ngaysinh;
                        dr["Dchi"] = nhanVien.Dchi;
                        dr["TrangThaiNv"] = nhanVien.TrangThaiNv;
                    }

                    // Cập nhật DataGridView
                    dgv_nhanvien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.ToLower();

            // Determine selected status
            bool? selectedStatus = null;
            if (rb_danglam.Checked)
            {
                selectedStatus = true;
            }
            else if (rb_nghiviec.Checked)
            {
                selectedStatus = false;
            }

            var filteredData = dt.AsEnumerable()
                .Where(row => (row["TenNV"].ToString().ToLower().Contains(keyword) ||
                               row["Sdt"].ToString().ToLower().Contains(keyword) ||
                               row["Dchi"].ToString().ToLower().Contains(keyword) ||
                               row["CaLam"].ToString().ToLower().Contains(keyword)) &&
                              (!selectedStatus.HasValue || row["TrangThaiNv"].Equals(selectedStatus.Value)));

            DataTable filteredTable = dt.Clone();
            foreach (var row in filteredData)
            {
                filteredTable.ImportRow(row);
            }

            dgv_nhanvien.DataSource = filteredTable;
        }
    }
}
