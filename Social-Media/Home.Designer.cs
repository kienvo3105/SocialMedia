
namespace Social_Media
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.fLP_home = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_post = new CustomControls.RJControls.RJPanel();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_film = new System.Windows.Forms.PictureBox();
            this.pic_picture = new System.Windows.Forms.PictureBox();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.fLP_home.SuspendLayout();
            this.pnl_post.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_film)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fLP_home
            // 
            this.fLP_home.AutoSize = true;
            this.fLP_home.Controls.Add(this.pnl_post);
            this.fLP_home.Location = new System.Drawing.Point(298, 12);
            this.fLP_home.MaximumSize = new System.Drawing.Size(816, 10000);
            this.fLP_home.Name = "fLP_home";
            this.fLP_home.Size = new System.Drawing.Size(816, 980);
            this.fLP_home.TabIndex = 0;
            // 
            // pnl_post
            // 
            this.pnl_post.BackColor = System.Drawing.Color.White;
            this.pnl_post.BorderRadius = 100;
            this.pnl_post.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_post.Controls.Add(this.rjPanel1);
            this.pnl_post.Controls.Add(this.pic_film);
            this.pnl_post.Controls.Add(this.pic_picture);
            this.pnl_post.Controls.Add(this.rjCircularPictureBox1);
            this.pnl_post.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_post.ForeColor = System.Drawing.Color.Black;
            this.pnl_post.GradientAngle = 90F;
            this.pnl_post.GradientBottomColor = System.Drawing.Color.White;
            this.pnl_post.GradientTopColor = System.Drawing.Color.White;
            this.pnl_post.Location = new System.Drawing.Point(3, 3);
            this.pnl_post.Name = "pnl_post";
            this.pnl_post.Size = new System.Drawing.Size(813, 96);
            this.pnl_post.TabIndex = 0;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 40;
            this.rjPanel1.Controls.Add(this.label1);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjPanel1.Location = new System.Drawing.Point(128, 9);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(648, 41);
            this.rjPanel1.TabIndex = 5;
            this.rjPanel1.Click += new System.EventHandler(this.rjPanel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn đang nghĩ gì thế?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pic_film
            // 
            this.pic_film.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_film.BackgroundImage")));
            this.pic_film.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_film.Location = new System.Drawing.Point(214, 56);
            this.pic_film.Name = "pic_film";
            this.pic_film.Size = new System.Drawing.Size(30, 30);
            this.pic_film.TabIndex = 4;
            this.pic_film.TabStop = false;
            // 
            // pic_picture
            // 
            this.pic_picture.BackColor = System.Drawing.Color.Transparent;
            this.pic_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_picture.BackgroundImage")));
            this.pic_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_picture.Location = new System.Drawing.Point(128, 59);
            this.pic_picture.Name = "pic_picture";
            this.pic_picture.Size = new System.Drawing.Size(30, 30);
            this.pic_picture.TabIndex = 3;
            this.pic_picture.TabStop = false;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.BackgroundImage")));
            this.rjCircularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(37, 3);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(56, 56);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1328, 763);
            this.Controls.Add(this.fLP_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.fLP_home.ResumeLayout(false);
            this.pnl_post.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_film)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLP_home;
        private CustomControls.RJControls.RJPanel pnl_post;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.PictureBox pic_film;
        private System.Windows.Forms.PictureBox pic_picture;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label label1;
    }
}