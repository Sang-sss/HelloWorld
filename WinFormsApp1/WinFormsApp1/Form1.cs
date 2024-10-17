using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();

        }

        // Sự kiện chọn ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(selectedImagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        // Sự kiện lưu CV
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                System.IO.File.WriteAllText(path, CreateCVText());
                MessageBox.Show("CV đã được lưu thành công!");
            }
        }

        // Tạo nội dung CV dạng text
        private string CreateCVText()
        {
            return $"Họ tên: {txtHoTen.Text}\n" +
                   $"Ngày sinh: {txtNgaySinh.Text}\n" +
                   $"Giới tính: {txtGioiTinh.Text}\n" +
                   $"Địa chỉ: {txtDiaChi.Text}\n" +
                   $"Email: {txtEmail.Text}\n" +
                   $"Kinh nghiệm:\n{rtbKinhNghiem.Text}\n" +
                   $"Kỹ năng:\n{rtbKyNang.Text}\n" +
                   $"Học vấn:\n{rtbHocVan.Text}\n";
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void lblHocVan_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblKyNang_Click(object sender, EventArgs e)
        {

        }
    }
}
