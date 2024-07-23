namespace DA1_QLBG
{
    partial class dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_dangnhap = new GroupBox();
            txtMatKhau = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtTaiKhoan = new TextBox();
            label1 = new Label();
            gb_dangnhap.SuspendLayout();
            SuspendLayout();
            // 
            // gb_dangnhap
            // 
            gb_dangnhap.Controls.Add(txtMatKhau);
            gb_dangnhap.Controls.Add(label3);
            gb_dangnhap.Controls.Add(label2);
            gb_dangnhap.Controls.Add(button2);
            gb_dangnhap.Controls.Add(button1);
            gb_dangnhap.Controls.Add(txtTaiKhoan);
            gb_dangnhap.Controls.Add(label1);
            gb_dangnhap.Location = new Point(209, 84);
            gb_dangnhap.Name = "gb_dangnhap";
            gb_dangnhap.Size = new Size(456, 285);
            gb_dangnhap.TabIndex = 0;
            gb_dangnhap.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(158, 160);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(267, 27);
            txtMatKhau.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 163);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 12;
            label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 101);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 11;
            label2.Text = "Tài khoản";
            // 
            // button2
            // 
            button2.Location = new Point(279, 216);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(113, 216);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(158, 101);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(267, 27);
            txtTaiKhoan.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(145, 39);
            label1.Name = "label1";
            label1.Size = new Size(203, 33);
            label1.TabIndex = 7;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = GUI.Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(853, 444);
            Controls.Add(gb_dangnhap);
            Name = "dangnhap";
            Text = "Đăng Nhập";
            gb_dangnhap.ResumeLayout(false);
            gb_dangnhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_dangnhap;
        private TextBox txtMatKhau;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox txtTaiKhoan;
        private Label label1;
    }
}
