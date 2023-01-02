
namespace Social_Media.Form_component
{
    partial class write
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(write));
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_public = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.pic_avar = new CustomControls.RJControls.RJCircularPictureBox();
            this.rtxt_status = new System.Windows.Forms.RichTextBox();
            this.pic_img = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_public)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_close
            // 
            this.pic_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_close.BackgroundImage")));
            this.pic_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_close.Location = new System.Drawing.Point(479, 0);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(40, 40);
            this.pic_close.TabIndex = 0;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_close);
            this.panel2.Controls.Add(this.pic_public);
            this.panel2.Controls.Add(this.lb_name);
            this.panel2.Controls.Add(this.pic_avar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 62);
            this.panel2.TabIndex = 1;
            // 
            // pic_public
            // 
            this.pic_public.Location = new System.Drawing.Point(72, 28);
            this.pic_public.Name = "pic_public";
            this.pic_public.Size = new System.Drawing.Size(30, 30);
            this.pic_public.TabIndex = 2;
            this.pic_public.TabStop = false;
            this.pic_public.Click += new System.EventHandler(this.pic_public_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(69, 6);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(52, 18);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "label1";
            // 
            // pic_avar
            // 
            this.pic_avar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_avar.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_avar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avar.BorderSize = 2;
            this.pic_avar.GradientAngle = 50F;
            this.pic_avar.Location = new System.Drawing.Point(3, 6);
            this.pic_avar.Name = "pic_avar";
            this.pic_avar.Size = new System.Drawing.Size(50, 50);
            this.pic_avar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avar.TabIndex = 0;
            this.pic_avar.TabStop = false;
            // 
            // rtxt_status
            // 
            this.rtxt_status.BackColor = System.Drawing.Color.Linen;
            this.rtxt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxt_status.Location = new System.Drawing.Point(0, 62);
            this.rtxt_status.MaximumSize = new System.Drawing.Size(522, 13800);
            this.rtxt_status.Name = "rtxt_status";
            this.rtxt_status.Size = new System.Drawing.Size(522, 76);
            this.rtxt_status.TabIndex = 3;
            this.rtxt_status.Text = "Hãy viết suy nghĩ của bạn!";
            // 
            // pic_img
            // 
            this.pic_img.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_img.Location = new System.Drawing.Point(0, 138);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(522, 252);
            this.pic_img.TabIndex = 9;
            this.pic_img.TabStop = false;
            this.pic_img.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 46);
            this.panel4.TabIndex = 10;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(199, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm ảnh vào bài viết";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(0, 436);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(522, 44);
            this.rjButton1.TabIndex = 11;
            this.rjButton1.Text = "Đăng";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(522, 594);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pic_img);
            this.Controls.Add(this.rtxt_status);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(522, 900);
            this.MinimumSize = new System.Drawing.Size(522, 200);
            this.Name = "write";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "write";
            this.Load += new System.EventHandler(this.write_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_public)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_public;
        private System.Windows.Forms.Label lb_name;
        private CustomControls.RJControls.RJCircularPictureBox pic_avar;
        private System.Windows.Forms.RichTextBox rtxt_status;
        private System.Windows.Forms.PictureBox pic_img;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}