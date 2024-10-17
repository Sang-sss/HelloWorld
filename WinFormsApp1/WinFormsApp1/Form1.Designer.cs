namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblKinhNghiem;
        private System.Windows.Forms.Label lblKyNang;
        private System.Windows.Forms.Label lblHocVan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox rtbKinhNghiem;
        private System.Windows.Forms.RichTextBox rtbKyNang;
        private System.Windows.Forms.RichTextBox rtbHocVan;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblDiaChi = new Label();
            lblEmail = new Label();
            lblKinhNghiem = new Label();
            lblKyNang = new Label();
            lblHocVan = new Label();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            rtbKinhNghiem = new RichTextBox();
            rtbKyNang = new RichTextBox();
            rtbHocVan = new RichTextBox();
            pictureBox = new PictureBox();
            btnChonAnh = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(4, 282);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(77, 23);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(3, 338);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(78, 23);
            lblNgaySinh.TabIndex = 1;
            lblNgaySinh.Text = "Ngày sinh:";
            lblNgaySinh.Click += lblNgaySinh_Click;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(3, 385);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(78, 23);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.Text = "Giới tính:";
            lblGioiTinh.Click += lblGioiTinh_Click;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(3, 431);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(78, 23);
            lblDiaChi.TabIndex = 3;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(4, 479);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(77, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblKinhNghiem
            // 
            lblKinhNghiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKinhNghiem.Location = new Point(15, 339);
            lblKinhNghiem.Name = "lblKinhNghiem";
            lblKinhNghiem.Size = new Size(134, 35);
            lblKinhNghiem.TabIndex = 5;
            lblKinhNghiem.Text = "Kinh nghiệm";
            // 
            // lblKyNang
            // 
            lblKyNang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKyNang.Location = new Point(15, 158);
            lblKyNang.Name = "lblKyNang";
            lblKyNang.Size = new Size(100, 31);
            lblKyNang.TabIndex = 6;
            lblKyNang.Text = "Kỹ năng";
            lblKyNang.Click += lblKyNang_Click;
            // 
            // lblHocVan
            // 
            lblHocVan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHocVan.Location = new Point(15, 9);
            lblHocVan.Name = "lblHocVan";
            lblHocVan.Size = new Size(184, 30);
            lblHocVan.TabIndex = 7;
            lblHocVan.Text = "Trình độ học vấn";
            lblHocVan.Click += lblHocVan_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(87, 282);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(152, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(87, 334);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(152, 27);
            txtNgaySinh.TabIndex = 9;
            txtNgaySinh.TextChanged += txtNgaySinh_TextChanged;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(87, 385);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(152, 27);
            txtGioiTinh.TabIndex = 10;
            txtGioiTinh.TextChanged += txtGioiTinh_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(87, 431);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(152, 27);
            txtDiaChi.TabIndex = 11;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 476);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 27);
            txtEmail.TabIndex = 12;
            // 
            // rtbKinhNghiem
            // 
            rtbKinhNghiem.Location = new Point(15, 192);
            rtbKinhNghiem.Name = "rtbKinhNghiem";
            rtbKinhNghiem.Size = new Size(403, 126);
            rtbKinhNghiem.TabIndex = 13;
            rtbKinhNghiem.Text = "";
            // 
            // rtbKyNang
            // 
            rtbKyNang.Location = new Point(15, 377);
            rtbKyNang.Name = "rtbKyNang";
            rtbKyNang.Size = new Size(403, 115);
            rtbKyNang.TabIndex = 14;
            rtbKyNang.Text = "";
            // 
            // rtbHocVan
            // 
            rtbHocVan.BackColor = SystemColors.ControlLightLight;
            rtbHocVan.Location = new Point(15, 42);
            rtbHocVan.Name = "rtbHocVan";
            rtbHocVan.Size = new Size(403, 113);
            rtbHocVan.TabIndex = 15;
            rtbHocVan.Text = "";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(245, 184);
            pictureBox.TabIndex = 16;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(74, 190);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(84, 27);
            btnChonAnh.TabIndex = 17;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(331, 553);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 36);
            btnSave.TabIndex = 20;
            btnSave.Text = "Lưu CV";
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNgaySinh);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblDiaChi);
            panel1.Controls.Add(lblGioiTinh);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblHoTen);
            panel1.Controls.Add(txtNgaySinh);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(btnChonAnh);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(txtGioiTinh);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 632);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(33, 223);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 22;
            label1.Text = "Thông tin cá nhân";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(lblKinhNghiem);
            panel2.Controls.Add(lblHocVan);
            panel2.Controls.Add(rtbKyNang);
            panel2.Controls.Add(rtbKinhNghiem);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(lblKyNang);
            panel2.Controls.Add(rtbHocVan);
            panel2.Location = new Point(262, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 604);
            panel2.TabIndex = 22;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            BackColor = SystemColors.Info;
            ClientSize = new Size(713, 640);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}
