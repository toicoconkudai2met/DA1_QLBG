namespace GUI
{
    partial class QuanLyNhanVien
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
            gb_danhsach = new GroupBox();
            txt_timkiem = new TextBox();
            btn_hienthi = new Button();
            btn_timkiem = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            dgv_nhanvien = new DataGridView();
            gb_thongtinnv = new GroupBox();
            gb_trangthai = new GroupBox();
            rb_danglam = new RadioButton();
            rb_nghiviec = new RadioButton();
            label14 = new Label();
            label13 = new Label();
            gb_giotinhnv = new GroupBox();
            rb_nam = new RadioButton();
            rb_nu = new RadioButton();
            txt_diachi = new TextBox();
            label11 = new Label();
            txt_tennv = new TextBox();
            label10 = new Label();
            txt_sdtnv = new TextBox();
            label9 = new Label();
            txt_manv = new TextBox();
            cb_calam = new ComboBox();
            label12 = new Label();
            dtp_ngaysinhnv = new DateTimePicker();
            gb_danhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nhanvien).BeginInit();
            gb_thongtinnv.SuspendLayout();
            gb_trangthai.SuspendLayout();
            gb_giotinhnv.SuspendLayout();
            SuspendLayout();
            // 
            // gb_danhsach
            // 
            gb_danhsach.Controls.Add(txt_timkiem);
            gb_danhsach.Controls.Add(btn_hienthi);
            gb_danhsach.Controls.Add(btn_timkiem);
            gb_danhsach.Controls.Add(btn_xoa);
            gb_danhsach.Controls.Add(btn_sua);
            gb_danhsach.Controls.Add(btn_them);
            gb_danhsach.Controls.Add(dgv_nhanvien);
            gb_danhsach.Location = new Point(445, 35);
            gb_danhsach.Name = "gb_danhsach";
            gb_danhsach.Size = new Size(772, 453);
            gb_danhsach.TabIndex = 57;
            gb_danhsach.TabStop = false;
            gb_danhsach.Text = "Danh sách";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(554, 35);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(162, 27);
            txt_timkiem.TabIndex = 47;
            // 
            // btn_hienthi
            // 
            btn_hienthi.Location = new Point(336, 32);
            btn_hienthi.Name = "btn_hienthi";
            btn_hienthi.Size = new Size(83, 31);
            btn_hienthi.TabIndex = 48;
            btn_hienthi.Text = "Hiển Thị";
            btn_hienthi.UseVisualStyleBackColor = true;
            btn_hienthi.Click += btn_hienthi_Click;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(454, 32);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 46;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(234, 33);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(83, 31);
            btn_xoa.TabIndex = 45;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(125, 35);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 44;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(10, 35);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 43;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // dgv_nhanvien
            // 
            dgv_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nhanvien.Location = new Point(21, 79);
            dgv_nhanvien.Name = "dgv_nhanvien";
            dgv_nhanvien.RowHeadersWidth = 51;
            dgv_nhanvien.Size = new Size(745, 363);
            dgv_nhanvien.TabIndex = 42;
            dgv_nhanvien.CellClick += dgv_nhanvien_CellClick;
            // 
            // gb_thongtinnv
            // 
            gb_thongtinnv.Controls.Add(gb_trangthai);
            gb_thongtinnv.Controls.Add(label14);
            gb_thongtinnv.Controls.Add(label13);
            gb_thongtinnv.Controls.Add(gb_giotinhnv);
            gb_thongtinnv.Controls.Add(txt_diachi);
            gb_thongtinnv.Controls.Add(label11);
            gb_thongtinnv.Controls.Add(txt_tennv);
            gb_thongtinnv.Controls.Add(label10);
            gb_thongtinnv.Controls.Add(txt_sdtnv);
            gb_thongtinnv.Controls.Add(label9);
            gb_thongtinnv.Controls.Add(txt_manv);
            gb_thongtinnv.Controls.Add(cb_calam);
            gb_thongtinnv.Controls.Add(label12);
            gb_thongtinnv.Controls.Add(dtp_ngaysinhnv);
            gb_thongtinnv.Location = new Point(30, 35);
            gb_thongtinnv.Name = "gb_thongtinnv";
            gb_thongtinnv.Size = new Size(396, 453);
            gb_thongtinnv.TabIndex = 56;
            gb_thongtinnv.TabStop = false;
            gb_thongtinnv.Text = "Thông Tin Nhân Viên";
            // 
            // gb_trangthai
            // 
            gb_trangthai.Controls.Add(rb_danglam);
            gb_trangthai.Controls.Add(rb_nghiviec);
            gb_trangthai.Location = new Point(26, 376);
            gb_trangthai.Name = "gb_trangthai";
            gb_trangthai.Size = new Size(330, 54);
            gb_trangthai.TabIndex = 49;
            gb_trangthai.TabStop = false;
            gb_trangthai.Text = "Trạng thái";
            // 
            // rb_danglam
            // 
            rb_danglam.AutoSize = true;
            rb_danglam.Location = new Point(37, 24);
            rb_danglam.Name = "rb_danglam";
            rb_danglam.Size = new Size(123, 24);
            rb_danglam.TabIndex = 42;
            rb_danglam.TabStop = true;
            rb_danglam.Text = "đang làm việc";
            rb_danglam.UseVisualStyleBackColor = true;
            // 
            // rb_nghiviec
            // 
            rb_nghiviec.AutoSize = true;
            rb_nghiviec.Location = new Point(175, 24);
            rb_nghiviec.Name = "rb_nghiviec";
            rb_nghiviec.Size = new Size(92, 24);
            rb_nghiviec.TabIndex = 43;
            rb_nghiviec.TabStop = true;
            rb_nghiviec.Text = "Nghỉ việc";
            rb_nghiviec.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(26, 32);
            label14.Name = "label14";
            label14.Size = new Size(97, 20);
            label14.TabIndex = 21;
            label14.Text = "Mã nhân viên";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 70);
            label13.Name = "label13";
            label13.Size = new Size(99, 20);
            label13.TabIndex = 22;
            label13.Text = "Tên nhân viên";
            // 
            // gb_giotinhnv
            // 
            gb_giotinhnv.Controls.Add(rb_nam);
            gb_giotinhnv.Controls.Add(rb_nu);
            gb_giotinhnv.Location = new Point(26, 100);
            gb_giotinhnv.Name = "gb_giotinhnv";
            gb_giotinhnv.Size = new Size(330, 54);
            gb_giotinhnv.TabIndex = 44;
            gb_giotinhnv.TabStop = false;
            gb_giotinhnv.Text = "Giới tính";
            // 
            // rb_nam
            // 
            rb_nam.AutoSize = true;
            rb_nam.Location = new Point(37, 24);
            rb_nam.Name = "rb_nam";
            rb_nam.Size = new Size(62, 24);
            rb_nam.TabIndex = 42;
            rb_nam.TabStop = true;
            rb_nam.Text = "Nam";
            rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            rb_nu.AutoSize = true;
            rb_nu.Location = new Point(157, 24);
            rb_nu.Name = "rb_nu";
            rb_nu.Size = new Size(50, 24);
            rb_nu.TabIndex = 43;
            rb_nu.TabStop = true;
            rb_nu.Text = "Nữ";
            rb_nu.UseVisualStyleBackColor = true;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(131, 329);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(225, 27);
            txt_diachi.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 178);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 24;
            label11.Text = "Số điện thoại";
            // 
            // txt_tennv
            // 
            txt_tennv.Location = new Point(131, 67);
            txt_tennv.Name = "txt_tennv";
            txt_tennv.Size = new Size(225, 27);
            txt_tennv.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 224);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 25;
            label10.Text = "Ca làm";
            // 
            // txt_sdtnv
            // 
            txt_sdtnv.Location = new Point(131, 171);
            txt_sdtnv.Name = "txt_sdtnv";
            txt_sdtnv.Size = new Size(225, 27);
            txt_sdtnv.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 289);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 26;
            label9.Text = "Ngày sinh";
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(131, 29);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(225, 27);
            txt_manv.TabIndex = 27;
            // 
            // cb_calam
            // 
            cb_calam.FormattingEnabled = true;
            cb_calam.Items.AddRange(new object[] { "Ca sáng", "Ca chiều", "Ca tối" });
            cb_calam.Location = new Point(131, 224);
            cb_calam.Name = "cb_calam";
            cb_calam.Size = new Size(225, 28);
            cb_calam.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 332);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 47;
            label12.Text = "Địa chỉ";
            // 
            // dtp_ngaysinhnv
            // 
            dtp_ngaysinhnv.Location = new Point(131, 282);
            dtp_ngaysinhnv.Name = "dtp_ngaysinhnv";
            dtp_ngaysinhnv.Size = new Size(225, 27);
            dtp_ngaysinhnv.TabIndex = 46;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 603);
            Controls.Add(gb_danhsach);
            Controls.Add(gb_thongtinnv);
            Name = "QuanLyNhanVien";
            Text = "QuanLyNhanVien";
            Load += QuanLyNhanVien_Load;
            gb_danhsach.ResumeLayout(false);
            gb_danhsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nhanvien).EndInit();
            gb_thongtinnv.ResumeLayout(false);
            gb_thongtinnv.PerformLayout();
            gb_trangthai.ResumeLayout(false);
            gb_trangthai.PerformLayout();
            gb_giotinhnv.ResumeLayout(false);
            gb_giotinhnv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_danhsach;
        private TextBox txt_timkiem;
        private Button btn_hienthi;
        private Button btn_timkiem;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private DataGridView dgv_nhanvien;
        private GroupBox gb_thongtinnv;
        private GroupBox gb_trangthai;
        private RadioButton rb_danglam;
        private RadioButton rb_nghiviec;
        private Label label14;
        private Label label13;
        private GroupBox gb_giotinhnv;
        private RadioButton rb_nam;
        private RadioButton rb_nu;
        private TextBox txt_diachi;
        private Label label11;
        private TextBox txt_tennv;
        private Label label10;
        private TextBox txt_sdtnv;
        private Label label9;
        private TextBox txt_manv;
        private ComboBox cb_calam;
        private Label label12;
        private DateTimePicker dtp_ngaysinhnv;
    }
}