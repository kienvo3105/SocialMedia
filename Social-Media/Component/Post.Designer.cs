
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
            this.pic_avt = new CustomControls.RJControls.RJCircularPictureBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_avt
            // 
            this.pic_avt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avt.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_avt.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_avt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avt.BorderSize = 2;
            this.pic_avt.GradientAngle = 50F;
            this.pic_avt.Location = new System.Drawing.Point(0, 3);
            this.pic_avt.Name = "pic_avt";
            this.pic_avt.Size = new System.Drawing.Size(50, 50);
            this.pic_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avt.TabIndex = 0;
            this.pic_avt.TabStop = false;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(56, 3);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(73, 22);
            this.lb_user.TabIndex = 1;
            this.lb_user.Text = "Kien Vo";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_time.Location = new System.Drawing.Point(57, 40);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(65, 13);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "28/12/2022";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_avt);
            this.panel1.Controls.Add(this.lb_time);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 68);
            this.panel1.TabIndex = 3;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 900);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(816, 598);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pic_avt;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Panel panel1;
    }
}
