using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Functions.Connect(); // Kết nối cơ sở dữ liệu
        }

        public static string login_username; // Lưu user đang đăng nhập

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            login_username = txtUsername.Texts;
            Main frm = new Main();
            //Home frm = new Home();
            frm.ShowDialog();
        }
    }
}
