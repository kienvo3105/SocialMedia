using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media.Component
{
    public partial class comment : UserControl
    {
        public comment()
        {
            InitializeComponent();
        }

        private string _name;
        private Image _avatar;
        private string _comment;

        public string User
        {
            get { return _name; }
            set { _name = value;lb_name.Text = value; }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; lb_Cmt.Text = value; }
        }

        public Image Img
        {
            get { return _avatar; }
            set { _avatar = value; pic_avar.Image = value; pic_avar.SizeMode = PictureBoxSizeMode.StretchImage; }
        }
    }
}
