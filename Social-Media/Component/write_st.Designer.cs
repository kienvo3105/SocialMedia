
namespace Social_Media.Component
{
    partial class write_st
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(write_st));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_avar = new CustomControls.RJControls.RJCircularPictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.pic_public = new System.Windows.Forms.PictureBox();
            this.rtxt_status = new System.Windows.Forms.RichTextBox();
            this.tbLP_img = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_post = new CustomControls.RJControls.RJButton();
            this.lb_addpic = new System.Windows.Forms.Label();
            this.pic_addpic = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_public)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_public);
            this.panel2.Controls.Add(this.lb_name);
            this.panel2.Controls.Add(this.pic_avar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 72);
            this.panel2.TabIndex = 1;
            // 
            // pic_avar
            // 
            this.pic_avar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_avar.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_avar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avar.BorderSize = 2;
            this.pic_avar.GradientAngle = 50F;
            this.pic_avar.Location = new System.Drawing.Point(3, 3);
            this.pic_avar.Name = "pic_avar";
            this.pic_avar.Size = new System.Drawing.Size(50, 50);
            this.pic_avar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avar.TabIndex = 0;
            this.pic_avar.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(73, 7);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(51, 20);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "label1";
            // 
            // pic_public
            // 
            this.pic_public.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_public.Location = new System.Drawing.Point(59, 39);
            this.pic_public.Name = "pic_public";
            this.pic_public.Size = new System.Drawing.Size(30, 30);
            this.pic_public.TabIndex = 2;
            this.pic_public.TabStop = false;
            this.pic_public.Click += new System.EventHandler(this.pic_public_Click);
            // 
            // rtxt_status
            // 
            this.rtxt_status.BackColor = System.Drawing.Color.White;
            this.rtxt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxt_status.Location = new System.Drawing.Point(0, 112);
            this.rtxt_status.MaximumSize = new System.Drawing.Size(522, 13800);
            this.rtxt_status.Name = "rtxt_status";
            this.rtxt_status.Size = new System.Drawing.Size(522, 138);
            this.rtxt_status.TabIndex = 2;
            this.rtxt_status.Text = "Hãy viết suy nghĩ của bạn!";
            // 
            // tbLP_img
            // 
            this.tbLP_img.ColumnCount = 2;
            this.tbLP_img.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLP_img.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLP_img.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLP_img.Location = new System.Drawing.Point(0, 250);
            this.tbLP_img.Name = "tbLP_img";
            this.tbLP_img.RowCount = 2;
            this.tbLP_img.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLP_img.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLP_img.Size = new System.Drawing.Size(522, 270);
            this.tbLP_img.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pic_addpic);
            this.panel3.Controls.Add(this.lb_addpic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 46);
            this.panel3.TabIndex = 4;
            // 
            // bt_post
            // 
            this.bt_post.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_post.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_post.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_post.BorderRadius = 20;
            this.bt_post.BorderSize = 0;
            this.bt_post.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_post.FlatAppearance.BorderSize = 0;
            this.bt_post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_post.ForeColor = System.Drawing.Color.White;
            this.bt_post.Location = new System.Drawing.Point(0, 566);
            this.bt_post.Name = "bt_post";
            this.bt_post.Size = new System.Drawing.Size(522, 44);
            this.bt_post.TabIndex = 5;
            this.bt_post.Text = "Đăng";
            this.bt_post.TextColor = System.Drawing.Color.White;
            this.bt_post.UseVisualStyleBackColor = false;
            // 
            // lb_addpic
            // 
            this.lb_addpic.AutoSize = true;
            this.lb_addpic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addpic.Location = new System.Drawing.Point(23, 15);
            this.lb_addpic.Name = "lb_addpic";
            this.lb_addpic.Size = new System.Drawing.Size(151, 18);
            this.lb_addpic.TabIndex = 0;
            this.lb_addpic.Text = "Thêm ảnh vào bài viết";
            // 
            // pic_addpic
            // 
            this.pic_addpic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_addpic.BackgroundImage")));
            this.pic_addpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_addpic.Location = new System.Drawing.Point(199, 1);
            this.pic_addpic.Name = "pic_addpic";
            this.pic_addpic.Size = new System.Drawing.Size(42, 42);
            this.pic_addpic.TabIndex = 1;
            this.pic_addpic.TabStop = false;
            // 
            // write_st
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_post);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbLP_img);
            this.Controls.Add(this.rtxt_status);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(522, 900);
            this.MinimumSize = new System.Drawing.Size(522, 674);
            this.Name = "write_st";
            this.Size = new System.Drawing.Size(522, 674);
            this.Load += new System.EventHandler(this.write_st_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_public)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJCircularPictureBox pic_avar;
        private System.Windows.Forms.PictureBox pic_public;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.RichTextBox rtxt_status;
        private System.Windows.Forms.TableLayoutPanel tbLP_img;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJButton bt_post;
        private System.Windows.Forms.PictureBox pic_addpic;
        private System.Windows.Forms.Label lb_addpic;
    }
}
