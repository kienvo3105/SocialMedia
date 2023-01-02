using Social_Media.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media.Form_component
{
    public partial class write : Form
    {
        public write()
        {
            InitializeComponent();
        }

        private void write_Load(object sender, EventArgs e)
        {
            pic_public.Tag = "public";
            pic_public.Image = Resources.icon_public;
            pic_public.SizeMode = PictureBoxSizeMode.Zoom;

            pic_img.SizeMode = PictureBoxSizeMode.Zoom;
            // Cài đặt thuộc tính OFD
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|All Files|*.*";
        }

        private void pic_public_Click(object sender, EventArgs e)
        {
            pic_public.Image.Dispose();
            pic_public.Image = pic_public.Tag == "public" ? Resources.icon_private : Resources.icon_public;
            pic_public.Tag = pic_public.Tag == "public" ? "private" : "public";
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_post_Click(object sender, EventArgs e)
        {

        }

       //thêm ảnh vào bài viết
        private void panel4_Click(object sender, EventArgs e)
        {
            // Show hộp thoại open file ra
            // Nhận kết quả trả về qua biến kiểu DialogResult
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);

                // Gán ảnh
                pic_img.Image = img;
                pic_img.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel4_Click(sender, e);
        }
    }
}
