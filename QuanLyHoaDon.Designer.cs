namespace GUI
{
    partial class QuanLyHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            btnTaoHoaDon = new Button();
            txtTenKhachHang = new TextBox();
            txtSDT = new TextBox();
            lblTenKhachHang = new Label();
            lblSDT = new Label();
            groupBox4 = new GroupBox();
            btnInHoaDon = new Button();
            btnHuy = new Button();
            btnThanhToan = new Button();
            txtTienKhach = new TextBox();
            lbltienThua = new Label();
            lblTraLai = new Label();
            lblTienKhachDua = new Label();
            lblTongTien = new Label();
            lblTongHoaDon = new Label();
            dgvHoaDonCho = new DataGridView();
            cbbHoaDon = new ComboBox();
            lblChonHoaDon = new Label();
            groupBox7 = new GroupBox();
            btnShowSP = new Button();
            dgvdanhSachSanPham = new DataGridView();
            txtTimKiem1 = new TextBox();
            lblTimKiem = new Label();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonCho).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdanhSachSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTaoHoaDon);
            groupBox3.Controls.Add(txtTenKhachHang);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(lblTenKhachHang);
            groupBox3.Controls.Add(lblSDT);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(283, 583);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông Tin Khách Hàng";
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoHoaDon.Location = new Point(15, 222);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(249, 43);
            btnTaoHoaDon.TabIndex = 4;
            btnTaoHoaDon.Text = "Tạo Hoá Đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(12, 165);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(252, 34);
            txtTenKhachHang.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(12, 79);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(252, 34);
            txtSDT.TabIndex = 2;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenKhachHang.Location = new Point(12, 130);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(141, 22);
            lblTenKhachHang.TabIndex = 1;
            lblTenKhachHang.Text = "Tên Khách Hàng";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.Location = new Point(12, 44);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(125, 22);
            lblSDT.TabIndex = 0;
            lblSDT.Text = "Số Điện Thoại";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnInHoaDon);
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(btnThanhToan);
            groupBox4.Controls.Add(txtTienKhach);
            groupBox4.Controls.Add(lbltienThua);
            groupBox4.Controls.Add(lblTraLai);
            groupBox4.Controls.Add(lblTienKhachDua);
            groupBox4.Controls.Add(lblTongTien);
            groupBox4.Controls.Add(lblTongHoaDon);
            groupBox4.Controls.Add(dgvHoaDonCho);
            groupBox4.Controls.Add(cbbHoaDon);
            groupBox4.Controls.Add(lblChonHoaDon);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(316, 24);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(483, 597);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông Tin Hoá Đơn";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(338, 553);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(130, 38);
            btnInHoaDon.TabIndex = 15;
            btnInHoaDon.Text = "In Hóa Đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(338, 511);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(130, 36);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(338, 469);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(130, 36);
            btnThanhToan.TabIndex = 13;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtTienKhach
            // 
            txtTienKhach.Location = new Point(106, 487);
            txtTienKhach.Name = "txtTienKhach";
            txtTienKhach.Size = new Size(226, 34);
            txtTienKhach.TabIndex = 5;
            // 
            // lbltienThua
            // 
            lbltienThua.AutoSize = true;
            lbltienThua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbltienThua.Location = new Point(8, 545);
            lbltienThua.Name = "lbltienThua";
            lbltienThua.Size = new Size(91, 22);
            lbltienThua.TabIndex = 12;
            lbltienThua.Text = "Tiền Thừa";
            // 
            // lblTraLai
            // 
            lblTraLai.AutoSize = true;
            lblTraLai.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTraLai.Location = new Point(147, 545);
            lblTraLai.Name = "lblTraLai";
            lblTraLai.Size = new Size(24, 25);
            lblTraLai.TabIndex = 11;
            lblTraLai.Text = "0";
            // 
            // lblTienKhachDua
            // 
            lblTienKhachDua.AutoSize = true;
            lblTienKhachDua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTienKhachDua.Location = new Point(8, 496);
            lblTienKhachDua.Name = "lblTienKhachDua";
            lblTienKhachDua.Size = new Size(139, 22);
            lblTienKhachDua.TabIndex = 10;
            lblTienKhachDua.Text = "Tiền Khách Đưa";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(201, 440);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(24, 25);
            lblTongTien.TabIndex = 9;
            lblTongTien.Text = "0";
            // 
            // lblTongHoaDon
            // 
            lblTongHoaDon.AutoSize = true;
            lblTongHoaDon.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongHoaDon.Location = new Point(8, 440);
            lblTongHoaDon.Name = "lblTongHoaDon";
            lblTongHoaDon.Size = new Size(151, 26);
            lblTongHoaDon.TabIndex = 8;
            lblTongHoaDon.Text = "Tổng Hoá Đơn";
            // 
            // dgvHoaDonCho
            // 
            dgvHoaDonCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonCho.Location = new Point(6, 90);
            dgvHoaDonCho.Name = "dgvHoaDonCho";
            dgvHoaDonCho.RowHeadersWidth = 51;
            dgvHoaDonCho.RowTemplate.Height = 29;
            dgvHoaDonCho.Size = new Size(471, 310);
            dgvHoaDonCho.TabIndex = 7;
            dgvHoaDonCho.CellContentClick += dgvHoaDonCho_CellContentClick;
            // 
            // cbbHoaDon
            // 
            cbbHoaDon.FormattingEnabled = true;
            cbbHoaDon.Location = new Point(152, 35);
            cbbHoaDon.Name = "cbbHoaDon";
            cbbHoaDon.Size = new Size(245, 36);
            cbbHoaDon.TabIndex = 6;
            cbbHoaDon.SelectedIndexChanged += cbbHoaDon_SelectedIndexChanged;
            // 
            // lblChonHoaDon
            // 
            lblChonHoaDon.AutoSize = true;
            lblChonHoaDon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChonHoaDon.Location = new Point(18, 44);
            lblChonHoaDon.Name = "lblChonHoaDon";
            lblChonHoaDon.Size = new Size(128, 22);
            lblChonHoaDon.TabIndex = 5;
            lblChonHoaDon.Text = "Chọn Hoá Đơn";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnShowSP);
            groupBox7.Controls.Add(dgvdanhSachSanPham);
            groupBox7.Controls.Add(txtTimKiem1);
            groupBox7.Controls.Add(lblTimKiem);
            groupBox7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(805, 24);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(424, 583);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Danh Sách Sản Phẩm";
            // 
            // btnShowSP
            // 
            btnShowSP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowSP.Location = new Point(6, 535);
            btnShowSP.Name = "btnShowSP";
            btnShowSP.Size = new Size(154, 36);
            btnShowSP.TabIndex = 5;
            btnShowSP.Text = "Hiển thị ";
            btnShowSP.UseVisualStyleBackColor = true;
            btnShowSP.Click += btnShowSP_Click;
            // 
            // dgvdanhSachSanPham
            // 
            dgvdanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhSachSanPham.Location = new Point(6, 77);
            dgvdanhSachSanPham.Name = "dgvdanhSachSanPham";
            dgvdanhSachSanPham.RowHeadersWidth = 51;
            dgvdanhSachSanPham.RowTemplate.Height = 29;
            dgvdanhSachSanPham.Size = new Size(494, 441);
            dgvdanhSachSanPham.TabIndex = 15;
            dgvdanhSachSanPham.CellContentClick += dgvdanhSachSanPham_CellContentClick;
            dgvdanhSachSanPham.CellDoubleClick += dgvdanhSachSanPham_CellDoubleClick;
            // 
            // txtTimKiem1
            // 
            txtTimKiem1.Location = new Point(121, 37);
            txtTimKiem1.Name = "txtTimKiem1";
            txtTimKiem1.Size = new Size(285, 34);
            txtTimKiem1.TabIndex = 5;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimKiem.Location = new Point(19, 49);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(90, 22);
            lblTimKiem.TabIndex = 15;
            lblTimKiem.Text = "Tìm Kiếm";
            // 
            // QuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 622);
            Controls.Add(groupBox7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Name = "QuanLyHoaDon";
            Text = "QuanLyHoaDon";
            Load += QuanLyHoaDon_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonCho).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdanhSachSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnTaoHoaDon;
        private TextBox txtTenKhachHang;
        private TextBox txtSDT;
        private Label lblTenKhachHang;
        private Label lblSDT;
        private GroupBox groupBox4;
        private Button btnHuy;
        private Button btnThanhToan;
        private TextBox txtTienKhach;
        private Label lbltienThua;
        private Label lblTraLai;
        private Label lblTienKhachDua;
        private Label lblTongTien;
        private Label lblTongHoaDon;
        private DataGridView dgvHoaDonCho;
        private ComboBox cbbHoaDon;
        private Label lblChonHoaDon;
        private GroupBox groupBox7;
        private DataGridView dgvdanhSachSanPham;
        private TextBox txtTimKiem1;
        private Label lblTimKiem;
        private Button btnShowSP;
        private Button btnInHoaDon;
    }
}