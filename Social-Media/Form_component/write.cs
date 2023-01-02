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
    }
}
