using GUI;

namespace DA1_QLBG
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Khung khung = new Khung();
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "123456")
                {
                    khung.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tai Khoan cua ban khong ton tai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Moi ban nhap thong tin", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
