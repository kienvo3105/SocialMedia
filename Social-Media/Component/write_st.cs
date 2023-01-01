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

namespace Social_Media.Component
{
    public partial class write_st : UserControl
    {
        public write_st()
        {
            InitializeComponent();
        }

        private void pic_public_Click(object sender, EventArgs e)
        {
            //if (pic_public.Image == Resources.icon_public)
            //{
            //    pic_public.Image = Resources.icon_private;
            //}
            //else
            //    pic_public.Image = Resources.icon_public;
            pic_public.Image.Dispose();
            pic_public.Image = pic_public.Tag == "public" ? Resources.icon_private : Resources.icon_public;
            pic_public.Tag = pic_public.Tag == "public" ? "private": "public";
        }

        private void write_st_Load(object sender, EventArgs e)
        {
            pic_public.Tag = "public";
            pic_public.Image = Resources.icon_public;
            pic_public.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
