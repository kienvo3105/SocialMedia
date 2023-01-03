
namespace Social_Media.Component
{
    partial class comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comment));
            this.pic_avar = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.lb_Cmt = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avar)).BeginInit();
            this.panel1.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_avar
            // 
            this.pic_avar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_avar.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_avar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avar.BorderSize = 2;
            this.pic_avar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_avar.GradientAngle = 50F;
            this.pic_avar.Location = new System.Drawing.Point(0, 0);
            this.pic_avar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_avar.Name = "pic_avar";
            this.pic_avar.Size = new System.Drawing.Size(67, 67);
            this.pic_avar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avar.TabIndex = 0;
            this.pic_avar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_avar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 130);
            this.panel1.TabIndex = 1;
            // 
            // rjPanel1
            // 
            this.rjPanel1.AutoSize = true;
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.lb_Cmt);
            this.rjPanel1.Controls.Add(this.lb_name);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.Silver;
            this.rjPanel1.GradientTopColor = System.Drawing.Color.Silver;
            this.rjPanel1.Location = new System.Drawing.Point(72, 0);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjPanel1.MaximumSize = new System.Drawing.Size(1053, 972);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(995, 130);
            this.rjPanel1.TabIndex = 2;
            // 
            // lb_Cmt
            // 
            this.lb_Cmt.AutoSize = true;
            this.lb_Cmt.BackColor = System.Drawing.Color.Transparent;
            this.lb_Cmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cmt.Location = new System.Drawing.Point(0, 30);
            this.lb_Cmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Cmt.MaximumSize = new System.Drawing.Size(1013, 935);
            this.lb_Cmt.Name = "lb_Cmt";
            this.lb_Cmt.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.lb_Cmt.Size = new System.Drawing.Size(1012, 63);
            this.lb_Cmt.TabIndex = 1;
            this.lb_Cmt.Text = resources.GetString("lb_Cmt.Text");
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(0, 0);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.lb_name.Size = new System.Drawing.Size(92, 30);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Kien Vo";
            // 
            // comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1067, 985);
            this.MinimumSize = new System.Drawing.Size(337, 75);
            this.Name = "comment";
            this.Size = new System.Drawing.Size(1067, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pic_avar;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_Cmt;
    }
}
