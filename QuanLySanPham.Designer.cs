namespace GUI
{
    partial class QuanLySanPham
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
            txtMaSP = new TextBox();
            label2 = new Label();
            cbbMauSac = new ComboBox();
            cbbKichCo = new ComboBox();
            txtGiaBan = new TextBox();
            lblGiaBan = new Label();
            ptbHien = new PictureBox();
            btnHien = new Button();
            txtAnh = new TextBox();
            lblAnh = new Label();
            cbbChatLieu = new ComboBox();
            txtSoLuong = new TextBox();
            txtTenSP = new TextBox();
            lblMauSac = new Label();
            label5 = new Label();
            lblChatLieu = new Label();
            lblSoLuong = new Label();
            lblTenSP = new Label();
            groupBox5 = new GroupBox();
            dgvSanPham = new DataGridView();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbHien).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(147, 45);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(240, 27);
            txtMaSP.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 52);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 62;
            label2.Text = "Mã Sản Phẩm";
            // 
            // cbbMauSac
            // 
            cbbMauSac.FormattingEnabled = true;
            cbbMauSac.Items.AddRange(new object[] { "Xanh", "Đỏ", "Trắng" });
            cbbMauSac.Location = new Point(148, 270);
            cbbMauSac.Name = "cbbMauSac";
            cbbMauSac.Size = new Size(240, 28);
            cbbMauSac.TabIndex = 61;
            // 
            // cbbKichCo
            // 
            cbbKichCo.FormattingEnabled = true;
            cbbKichCo.Items.AddRange(new object[] { "37", "38", "39", "40", "41", "42", "43" });
            cbbKichCo.Location = new Point(147, 226);
            cbbKichCo.Name = "cbbKichCo";
            cbbKichCo.Size = new Size(240, 28);
            cbbKichCo.TabIndex = 60;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(147, 315);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(240, 27);
            txtGiaBan.TabIndex = 59;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(40, 318);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(60, 20);
            lblGiaBan.TabIndex = 58;
            lblGiaBan.Text = "Giá Bán";
            // 
            // ptbHien
            // 
            ptbHien.Location = new Point(150, 472);
            ptbHien.Name = "ptbHien";
            ptbHien.Size = new Size(240, 140);
            ptbHien.TabIndex = 57;
            ptbHien.TabStop = false;
            // 
            // btnHien
            // 
            btnHien.Location = new Point(47, 472);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(59, 29);
            btnHien.TabIndex = 56;
            btnHien.Text = "Hiện";
            btnHien.UseVisualStyleBackColor = true;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(148, 371);
            txtAnh.Multiline = true;
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(242, 82);
            txtAnh.TabIndex = 55;
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.Location = new Point(41, 371);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(35, 20);
            lblAnh.TabIndex = 54;
            lblAnh.Text = "Ảnh";
            // 
            // cbbChatLieu
            // 
            cbbChatLieu.FormattingEnabled = true;
            cbbChatLieu.Items.AddRange(new object[] { "Vải", "Da" });
            cbbChatLieu.Location = new Point(147, 180);
            cbbChatLieu.Name = "cbbChatLieu";
            cbbChatLieu.Size = new Size(240, 28);
            cbbChatLieu.TabIndex = 53;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(147, 137);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(241, 27);
            txtSoLuong.TabIndex = 52;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(147, 92);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(241, 27);
            txtTenSP.TabIndex = 51;
            // 
            // lblMauSac
            // 
            lblMauSac.AutoSize = true;
            lblMauSac.Location = new Point(40, 273);
            lblMauSac.Name = "lblMauSac";
            lblMauSac.Size = new Size(65, 20);
            lblMauSac.TabIndex = 50;
            lblMauSac.Text = "Màu Sắc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 229);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 49;
            label5.Text = "Kích Cỡ";
            // 
            // lblChatLieu
            // 
            lblChatLieu.AutoSize = true;
            lblChatLieu.Location = new Point(40, 183);
            lblChatLieu.Name = "lblChatLieu";
            lblChatLieu.Size = new Size(70, 20);
            lblChatLieu.TabIndex = 48;
            lblChatLieu.Text = "Chất Liệu";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(41, 140);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.TabIndex = 47;
            lblSoLuong.Text = "Số Lượng";
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(41, 99);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(101, 20);
            lblTenSP.TabIndex = 46;
            lblTenSP.Text = "Tên Sản Phẩm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvSanPham);
            groupBox5.Controls.Add(txtTimKiem);
            groupBox5.Controls.Add(btnTimKiem);
            groupBox5.Controls.Add(btnHienThi);
            groupBox5.Controls.Add(btnXoa);
            groupBox5.Controls.Add(btnSua);
            groupBox5.Controls.Add(btnThem);
            groupBox5.Location = new Point(410, 52);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(810, 567);
            groupBox5.TabIndex = 64;
            groupBox5.TabStop = false;
            groupBox5.Text = "Bản Chi Tiết Sản phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(10, 74);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(774, 487);
            dgvSanPham.TabIndex = 6;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(603, 36);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(181, 27);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(491, 36);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(370, 36);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 3;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(258, 36);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(134, 36);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 655);
            Controls.Add(groupBox5);
            Controls.Add(txtMaSP);
            Controls.Add(label2);
            Controls.Add(cbbMauSac);
            Controls.Add(cbbKichCo);
            Controls.Add(txtGiaBan);
            Controls.Add(lblGiaBan);
            Controls.Add(ptbHien);
            Controls.Add(btnHien);
            Controls.Add(txtAnh);
            Controls.Add(lblAnh);
            Controls.Add(cbbChatLieu);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTenSP);
            Controls.Add(lblMauSac);
            Controls.Add(label5);
            Controls.Add(lblChatLieu);
            Controls.Add(lblSoLuong);
            Controls.Add(lblTenSP);
            Name = "QuanLySanPham";
            Text = "QuanLySanPham";
            ((System.ComponentModel.ISupportInitialize)ptbHien).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private Label label2;
        private ComboBox cbbMauSac;
        private ComboBox cbbKichCo;
        private TextBox txtGiaBan;
        private Label lblGiaBan;
        private PictureBox ptbHien;
        private Button btnHien;
        private TextBox txtAnh;
        private Label lblAnh;
        private ComboBox cbbChatLieu;
        private TextBox txtSoLuong;
        private TextBox txtTenSP;
        private Label lblMauSac;
        private Label label5;
        private Label lblChatLieu;
        private Label lblSoLuong;
        private Label lblTenSP;
        private GroupBox groupBox5;
        private DataGridView dgvSanPham;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnHienThi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}