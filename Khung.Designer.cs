namespace GUI
{
    partial class Khung
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
            panel1 = new Panel();
            btn_khachhang = new Button();
            btn_nhanvien = new Button();
            btn_thanhtoan = new Button();
            btn_qlsp = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lb_Open = new Label();
            panel_body = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(btn_khachhang);
            panel1.Controls.Add(btn_nhanvien);
            panel1.Controls.Add(btn_thanhtoan);
            panel1.Controls.Add(btn_qlsp);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 722);
            panel1.TabIndex = 1;
            // 
            // btn_khachhang
            // 
            btn_khachhang.Dock = DockStyle.Top;
            btn_khachhang.Location = new Point(0, 419);
            btn_khachhang.Name = "btn_khachhang";
            btn_khachhang.Size = new Size(199, 92);
            btn_khachhang.TabIndex = 4;
            btn_khachhang.Text = "Khách hàng";
            btn_khachhang.UseVisualStyleBackColor = true;
            btn_khachhang.Click += btn_khachhang_Click_1;
            // 
            // btn_nhanvien
            // 
            btn_nhanvien.Dock = DockStyle.Top;
            btn_nhanvien.Location = new Point(0, 327);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Size = new Size(199, 92);
            btn_nhanvien.TabIndex = 3;
            btn_nhanvien.Text = "Nhân viên";
            btn_nhanvien.UseVisualStyleBackColor = true;
            btn_nhanvien.Click += btn_nhanvien_Click_1;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Dock = DockStyle.Top;
            btn_thanhtoan.Location = new Point(0, 235);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(199, 92);
            btn_thanhtoan.TabIndex = 2;
            btn_thanhtoan.Text = "Thanh toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click_1;
            // 
            // btn_qlsp
            // 
            btn_qlsp.Dock = DockStyle.Top;
            btn_qlsp.Location = new Point(0, 143);
            btn_qlsp.Name = "btn_qlsp";
            btn_qlsp.Size = new Size(199, 92);
            btn_qlsp.TabIndex = 1;
            btn_qlsp.Text = "Sản phẩm";
            btn_qlsp.UseVisualStyleBackColor = true;
            btn_qlsp.Click += btn_qlsp_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 143);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Coral;
            panel3.Controls.Add(lb_Open);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(199, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1222, 73);
            panel3.TabIndex = 2;
            // 
            // lb_Open
            // 
            lb_Open.AutoSize = true;
            lb_Open.Font = new Font("Segoe Script", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            lb_Open.Location = new Point(23, 9);
            lb_Open.Name = "lb_Open";
            lb_Open.Size = new Size(102, 44);
            lb_Open.TabIndex = 0;
            lb_Open.Text = "Home";
            lb_Open.Click += lb_Open_Click;
            // 
            // panel_body
            // 
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(199, 73);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1222, 649);
            panel_body.TabIndex = 3;
            // 
            // Khung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 722);
            Controls.Add(panel_body);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Khung";
            Text = "Khung";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_khachhang;
        private Button btn_nhanvien;
        private Button btn_thanhtoan;
        private Button btn_qlsp;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label lb_Open;
        private Panel panel_body;
    }
}