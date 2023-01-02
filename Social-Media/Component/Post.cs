using Social_Media.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media.Component
{
    public partial class Post : UserControl
    {

        public Post()
        {
            InitializeComponent();
        }

        //tạo rounded cho form
        private int radius = 50;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            //using (var path = GetRoundRectagle(bounds, this.Radius))
            //    this.Region = new Region(path);

            //Better round rectangle
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }
        //set dữ liệu
        private string _username;
        private string _time;
        private Image _avatar;
        private string _content;
        private Image _img;
        private int _sumlike;
        private int _sumcmt;
        private bool _like;
        private bool _save;


        public string Username
        {
            get { return _username; }
            set { _username = value; lb_user.Text = value; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; lb_time.Text = value; }
        }
        public Image Avatar
        {
            get { return _avatar; }
            set { _avatar = value; pic_avt.Image = value; pic_img.SizeMode = PictureBoxSizeMode.StretchImage; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; rtxt_status.Text = value; }
        }

        public Image Img
        {
            get { return _img; }
            set
            {
                _img = value;
                pic_img.Image = value;
                pic_img.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_img.Visible = true;
            }
        }
        public int Sumlike
        {
            get { return _sumlike; }
            set { _sumlike = value; lb_likeCount.Text = value.ToString(); }
        }

        public int Sumcmt
        {
            get { return _sumcmt; }
            set { _sumcmt = value; lb_cmtCount.Text = value.ToString(); }
        }

        public bool Like
        {
            get { return _like; }
            set
            {
                _like = value;
                pic_like.Image = value ? Resources.icon_liked : Resources.icon_like;
                pic_like.Tag = value ? "yes" : "no";
            }
        }

        public bool Save
        {
            get { return _save; }
            set
            {
                _save = value;
                pic_save.Image = value ? Resources.icon_saveClick : Resources.icon_save;
                pic_save.Tag = value ? "yes" : "no";
            }
        }

        //Cài đặt cấu hình và sự kiện các control
        private void Post_Load(object sender, EventArgs e)
        {
            pic_like.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_save.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pic_like_Click(object sender, EventArgs e)
        {
            pic_like.Image = pic_like.Tag == "no" ? Resources.icon_liked : Resources.icon_like;
            pic_like.Tag = pic_like.Tag == "no" ? "yes" : "no";
        }

        private void pic_save_Click(object sender, EventArgs e)
        {
            pic_save.Image = pic_save.Tag == "no" ? Resources.icon_saveClick : Resources.icon_save;
            pic_save.Tag = pic_save.Tag == "no" ? "yes" : "no";
        }

        private void bt_postCmt_Click(object sender, EventArgs e)
        {

        }
    }
}
