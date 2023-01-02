
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
            this.pic_avar.Name = "pic_avar";
            this.pic_avar.Size = new System.Drawing.Size(50, 50);
            this.pic_avar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avar.TabIndex = 0;
            this.pic_avar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_avar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 74);
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
            this.rjPanel1.Location = new System.Drawing.Point(54, 0);
            this.rjPanel1.MaximumSize = new System.Drawing.Size(790, 790);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(746, 74);
            this.rjPanel1.TabIndex = 2;
            // 
            // lb_Cmt
            // 
            this.lb_Cmt.AutoSize = true;
            this.lb_Cmt.BackColor = System.Drawing.Color.Transparent;
            this.lb_Cmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cmt.Location = new System.Drawing.Point(0, 25);
            this.lb_Cmt.MaximumSize = new System.Drawing.Size(760, 760);
            this.lb_Cmt.Name = "lb_Cmt";
            this.lb_Cmt.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lb_Cmt.Size = new System.Drawing.Size(760, 49);
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
            this.lb_name.Name = "lb_name";
            this.lb_name.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lb_name.Size = new System.Drawing.Size(76, 25);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Kien Vo";
            // 
            // comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(253, 61);
            this.Name = "comment";
            this.Size = new System.Drawing.Size(800, 74);
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
