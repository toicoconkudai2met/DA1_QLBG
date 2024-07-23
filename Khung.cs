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
    public partial class Khung : Form
    {
        public Khung()
        {
            InitializeComponent();
        }
        private Form currenFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            currenFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_qlsp_Click(object sender, EventArgs e)
        {

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {

        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currenFormChild == null)
            {
                currenFormChild.Close();
            }
        }

        private void btn_qlsp_Click_1(object sender, EventArgs e)
        {
            //sản phẩm
            OpenChildForm(new QuanLySanPham());
            lb_Open.Text = btn_qlsp.Text;

        }

        private void btn_thanhtoan_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyHoaDon());
            lb_Open.Text = btn_thanhtoan.Text;
        }

        private void btn_nhanvien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
            lb_Open.Text = btn_nhanvien.Text;
        }

        private void btn_khachhang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
            lb_Open.Text = btn_khachhang.Text;
        }

        private void lb_Open_Click(object sender, EventArgs e)
        {

        }
    }
}
