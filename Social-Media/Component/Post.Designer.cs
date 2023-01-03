
namespace Social_Media.Component
{
    partial class Post
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_save = new System.Windows.Forms.Label();
            this.lb_cmt = new System.Windows.Forms.Label();
            this.lb_like = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_cmtCount = new System.Windows.Forms.Label();
            this.lb_likeCount = new System.Windows.Forms.Label();
            this.pnl_liked = new System.Windows.Forms.Panel();
            this.pnl_like = new System.Windows.Forms.Panel();
            this.pnl_comments = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_postCmt = new CustomControls.RJControls.RJButton();
            this.txt_cmt = new CustomControls.RJControls.RJTextBox();
            this.rtxt_status = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pic_img = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_likeCount = new System.Windows.Forms.PictureBox();
            this.pic_save = new System.Windows.Forms.PictureBox();
            this.pic_cmt = new System.Windows.Forms.PictureBox();
            this.pic_like = new System.Windows.Forms.PictureBox();
            this.pic_cmtA = new CustomControls.RJControls.RJCircularPictureBox();
            this.pic_menu = new System.Windows.Forms.PictureBox();
            this.pic_avt = new CustomControls.RJControls.RJCircularPictureBox();
            this.show = new System.Windows.Forms.ToolStripMenuItem();
            this.Del = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_liked.SuspendLayout();
            this.pnl_like.SuspendLayout();
            this.pnl_comments.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_likeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cmtA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(95, 4);
            this.lb_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(89, 26);
            this.lb_user.TabIndex = 1;
            this.lb_user.Text = "Kien Vo";
            // 
            // lb_save
            // 
            this.lb_save.AutoSize = true;
            this.lb_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_save.Location = new System.Drawing.Point(945, 26);
            this.lb_save.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_save.Name = "lb_save";
            this.lb_save.Size = new System.Drawing.Size(111, 25);
            this.lb_save.TabIndex = 5;
            this.lb_save.Text = "Lưu bài viết";
            // 
            // lb_cmt
            // 
            this.lb_cmt.AutoSize = true;
            this.lb_cmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cmt.Location = new System.Drawing.Point(540, 26);
            this.lb_cmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cmt.Name = "lb_cmt";
            this.lb_cmt.Size = new System.Drawing.Size(93, 25);
            this.lb_cmt.TabIndex = 3;
            this.lb_cmt.Text = "Bình luận";
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_like.Location = new System.Drawing.Point(60, 30);
            this.lb_like.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(61, 25);
            this.lb_like.TabIndex = 1;
            this.lb_like.Text = "Thích";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_time.Location = new System.Drawing.Point(105, 49);
            this.lb_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(71, 16);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "28/12/2022";
            // 
            // lb_cmtCount
            // 
            this.lb_cmtCount.AutoSize = true;
            this.lb_cmtCount.Location = new System.Drawing.Point(871, 15);
            this.lb_cmtCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cmtCount.Name = "lb_cmtCount";
            this.lb_cmtCount.Size = new System.Drawing.Size(129, 25);
            this.lb_cmtCount.TabIndex = 3;
            this.lb_cmtCount.Text = "10 comments";
            // 
            // lb_likeCount
            // 
            this.lb_likeCount.AutoSize = true;
            this.lb_likeCount.Location = new System.Drawing.Point(51, 15);
            this.lb_likeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_likeCount.Name = "lb_likeCount";
            this.lb_likeCount.Size = new System.Drawing.Size(34, 25);
            this.lb_likeCount.TabIndex = 1;
            this.lb_likeCount.Text = "50";
            // 
            // pnl_liked
            // 
            this.pnl_liked.Controls.Add(this.lb_cmtCount);
            this.pnl_liked.Controls.Add(this.pictureBox1);
            this.pnl_liked.Controls.Add(this.lb_likeCount);
            this.pnl_liked.Controls.Add(this.pic_likeCount);
            this.pnl_liked.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_liked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_liked.Location = new System.Drawing.Point(0, 744);
            this.pnl_liked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_liked.Name = "pnl_liked";
            this.pnl_liked.Size = new System.Drawing.Size(1084, 54);
            this.pnl_liked.TabIndex = 18;
            // 
            // pnl_like
            // 
            this.pnl_like.Controls.Add(this.lb_save);
            this.pnl_like.Controls.Add(this.pic_save);
            this.pnl_like.Controls.Add(this.lb_cmt);
            this.pnl_like.Controls.Add(this.pic_cmt);
            this.pnl_like.Controls.Add(this.lb_like);
            this.pnl_like.Controls.Add(this.pic_like);
            this.pnl_like.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_like.Location = new System.Drawing.Point(0, 798);
            this.pnl_like.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_like.Name = "pnl_like";
            this.pnl_like.Size = new System.Drawing.Size(1084, 78);
            this.pnl_like.TabIndex = 17;
            // 
            // pnl_comments
            // 
            this.pnl_comments.Controls.Add(this.panel2);
            this.pnl_comments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_comments.Location = new System.Drawing.Point(0, 876);
            this.pnl_comments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_comments.Name = "pnl_comments";
            this.pnl_comments.Size = new System.Drawing.Size(1084, 197);
            this.pnl_comments.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_postCmt);
            this.panel2.Controls.Add(this.txt_cmt);
            this.panel2.Controls.Add(this.pic_cmtA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 81);
            this.panel2.TabIndex = 0;
            // 
            // bt_postCmt
            // 
            this.bt_postCmt.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_postCmt.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_postCmt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_postCmt.BorderRadius = 15;
            this.bt_postCmt.BorderSize = 0;
            this.bt_postCmt.FlatAppearance.BorderSize = 0;
            this.bt_postCmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_postCmt.ForeColor = System.Drawing.Color.White;
            this.bt_postCmt.Location = new System.Drawing.Point(853, 26);
            this.bt_postCmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_postCmt.Name = "bt_postCmt";
            this.bt_postCmt.Size = new System.Drawing.Size(131, 34);
            this.bt_postCmt.TabIndex = 2;
            this.bt_postCmt.Text = "Đăng bình luận";
            this.bt_postCmt.TextColor = System.Drawing.Color.White;
            this.bt_postCmt.UseVisualStyleBackColor = false;
            this.bt_postCmt.Click += new System.EventHandler(this.bt_postCmt_Click);
            // 
            // txt_cmt
            // 
            this.txt_cmt.AutoScroll = true;
            this.txt_cmt.AutoSize = true;
            this.txt_cmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_cmt.BorderColor = System.Drawing.Color.Transparent;
            this.txt_cmt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_cmt.BorderRadius = 15;
            this.txt_cmt.BorderSize = 2;
            this.txt_cmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmt.ForeColor = System.Drawing.Color.Black;
            this.txt_cmt.Location = new System.Drawing.Point(81, 26);
            this.txt_cmt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_cmt.MaximumSize = new System.Drawing.Size(728, 492);
            this.txt_cmt.MinimumSize = new System.Drawing.Size(728, 38);
            this.txt_cmt.Multiline = false;
            this.txt_cmt.Name = "txt_cmt";
            this.txt_cmt.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txt_cmt.PasswordChar = false;
            this.txt_cmt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_cmt.PlaceholderText = "";
            this.txt_cmt.Size = new System.Drawing.Size(728, 39);
            this.txt_cmt.TabIndex = 1;
            this.txt_cmt.Texts = "Viết bình luận của bạn";
            this.txt_cmt.UnderlinedStyle = false;
            // 
            // rtxt_status
            // 
            this.rtxt_status.BackColor = System.Drawing.Color.White;
            this.rtxt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_status.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxt_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_status.Location = new System.Drawing.Point(0, 84);
            this.rtxt_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_status.MaximumSize = new System.Drawing.Size(1088, 3692);
            this.rtxt_status.MinimumSize = new System.Drawing.Size(1088, 12);
            this.rtxt_status.Name = "rtxt_status";
            this.rtxt_status.ReadOnly = true;
            this.rtxt_status.Size = new System.Drawing.Size(1088, 155);
            this.rtxt_status.TabIndex = 19;
            this.rtxt_status.Text = "Hello every one";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_menu);
            this.panel1.Controls.Add(this.pic_avt);
            this.panel1.Controls.Add(this.lb_time);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 84);
            this.panel1.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show,
            this.Del});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 56);
            // 
            // pic_img
            // 
            this.pic_img.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_img.Location = new System.Drawing.Point(0, 239);
            this.pic_img.Margin = new System.Windows.Forms.Padding(4);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(1084, 438);
            this.pic_img.TabIndex = 22;
            this.pic_img.TabStop = false;
            this.pic_img.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(825, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pic_likeCount
            // 
            this.pic_likeCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_likeCount.BackgroundImage")));
            this.pic_likeCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_likeCount.Location = new System.Drawing.Point(5, 5);
            this.pic_likeCount.Margin = new System.Windows.Forms.Padding(4);
            this.pic_likeCount.Name = "pic_likeCount";
            this.pic_likeCount.Size = new System.Drawing.Size(37, 34);
            this.pic_likeCount.TabIndex = 0;
            this.pic_likeCount.TabStop = false;
            // 
            // pic_save
            // 
            this.pic_save.BackgroundImage = global::Social_Media.Properties.Resources.icon_save;
            this.pic_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_save.Location = new System.Drawing.Point(891, 12);
            this.pic_save.Margin = new System.Windows.Forms.Padding(4);
            this.pic_save.Name = "pic_save";
            this.pic_save.Size = new System.Drawing.Size(47, 43);
            this.pic_save.TabIndex = 4;
            this.pic_save.TabStop = false;
            this.pic_save.Click += new System.EventHandler(this.pic_save_Click);
            // 
            // pic_cmt
            // 
            this.pic_cmt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_cmt.BackgroundImage")));
            this.pic_cmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_cmt.Location = new System.Drawing.Point(485, 12);
            this.pic_cmt.Margin = new System.Windows.Forms.Padding(4);
            this.pic_cmt.Name = "pic_cmt";
            this.pic_cmt.Size = new System.Drawing.Size(47, 43);
            this.pic_cmt.TabIndex = 2;
            this.pic_cmt.TabStop = false;
            // 
            // pic_like
            // 
            this.pic_like.BackgroundImage = global::Social_Media.Properties.Resources.icon_like;
            this.pic_like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_like.Location = new System.Drawing.Point(5, 16);
            this.pic_like.Margin = new System.Windows.Forms.Padding(4);
            this.pic_like.Name = "pic_like";
            this.pic_like.Size = new System.Drawing.Size(47, 43);
            this.pic_like.TabIndex = 0;
            this.pic_like.TabStop = false;
            this.pic_like.Click += new System.EventHandler(this.pic_like_Click);
            // 
            // pic_cmtA
            // 
            this.pic_cmtA.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_cmtA.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_cmtA.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_cmtA.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_cmtA.BorderSize = 2;
            this.pic_cmtA.GradientAngle = 50F;
            this.pic_cmtA.Location = new System.Drawing.Point(5, 7);
            this.pic_cmtA.Margin = new System.Windows.Forms.Padding(4);
            this.pic_cmtA.Name = "pic_cmtA";
            this.pic_cmtA.Size = new System.Drawing.Size(67, 67);
            this.pic_cmtA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cmtA.TabIndex = 0;
            this.pic_cmtA.TabStop = false;
            // 
            // pic_menu
            // 
            this.pic_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_menu.BackgroundImage")));
            this.pic_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_menu.ContextMenuStrip = this.contextMenuStrip1;
            this.pic_menu.Location = new System.Drawing.Point(1024, 4);
            this.pic_menu.Margin = new System.Windows.Forms.Padding(4);
            this.pic_menu.Name = "pic_menu";
            this.pic_menu.Size = new System.Drawing.Size(40, 37);
            this.pic_menu.TabIndex = 3;
            this.pic_menu.TabStop = false;
            this.pic_menu.Click += new System.EventHandler(this.pic_menu_Click);
            // 
            // pic_avt
            // 
            this.pic_avt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_avt.BackgroundImage")));
            this.pic_avt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_avt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avt.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_avt.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_avt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avt.BorderSize = 2;
            this.pic_avt.GradientAngle = 50F;
            this.pic_avt.Location = new System.Drawing.Point(20, 4);
            this.pic_avt.Margin = new System.Windows.Forms.Padding(4);
            this.pic_avt.Name = "pic_avt";
            this.pic_avt.Size = new System.Drawing.Size(67, 67);
            this.pic_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avt.TabIndex = 0;
            this.pic_avt.TabStop = false;
            // 
            // show
            // 
            this.show.Image = global::Social_Media.Properties.Resources.icon_view;
            this.show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(161, 26);
            this.show.Text = "Ẩn bài viết";
            // 
            // Del
            // 
            this.Del.Image = global::Social_Media.Properties.Resources.icon_delete;
            this.Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(161, 26);
            this.Del.Text = "Xóa bài viết";
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pic_img);
            this.Controls.Add(this.pnl_liked);
            this.Controls.Add(this.pnl_like);
            this.Controls.Add(this.pnl_comments);
            this.Controls.Add(this.rtxt_status);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1084, 24615);
            this.MinimumSize = new System.Drawing.Size(1084, 0);
            this.Name = "Post";
            this.Size = new System.Drawing.Size(1084, 1073);
            this.Load += new System.EventHandler(this.Post_Load);
            this.pnl_liked.ResumeLayout(false);
            this.pnl_liked.PerformLayout();
            this.pnl_like.ResumeLayout(false);
            this.pnl_like.PerformLayout();
            this.pnl_comments.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_likeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cmtA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pic_avt;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_save;
        private System.Windows.Forms.PictureBox pic_save;
        private System.Windows.Forms.Label lb_cmt;
        private System.Windows.Forms.PictureBox pic_cmt;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.PictureBox pic_like;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_cmtCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_likeCount;
        private System.Windows.Forms.PictureBox pic_likeCount;
        private System.Windows.Forms.Panel pnl_liked;
        private System.Windows.Forms.Panel pnl_like;
        private System.Windows.Forms.Panel pnl_comments;
        private System.Windows.Forms.RichTextBox rtxt_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem show;
        private System.Windows.Forms.ToolStripMenuItem Del;
        private System.Windows.Forms.PictureBox pic_img;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton bt_postCmt;
        private CustomControls.RJControls.RJTextBox txt_cmt;
        private CustomControls.RJControls.RJCircularPictureBox pic_cmtA;
    }
}
