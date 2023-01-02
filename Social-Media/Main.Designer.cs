
namespace Social_Media
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pic_avr = new CustomControls.RJControls.RJCircularPictureBox();
            this.pic_bell = new System.Windows.Forms.PictureBox();
            this.pic_person = new System.Windows.Forms.PictureBox();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.txt_seach = new CustomControls.RJControls.RJTextBox();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.White;
            this.pnl_header.Controls.Add(this.pic_search);
            this.pnl_header.Controls.Add(this.txt_seach);
            this.pnl_header.Controls.Add(this.pic_avr);
            this.pnl_header.Controls.Add(this.pic_bell);
            this.pnl_header.Controls.Add(this.pic_person);
            this.pnl_header.Controls.Add(this.pic_home);
            this.pnl_header.Controls.Add(this.pic_logo);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1364, 78);
            this.pnl_header.TabIndex = 0;
            // 
            // pic_avr
            // 
            this.pic_avr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_avr.BackgroundImage")));
            this.pic_avr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_avr.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avr.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_avr.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_avr.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avr.BorderSize = 2;
            this.pic_avr.GradientAngle = 50F;
            this.pic_avr.Location = new System.Drawing.Point(1292, 12);
            this.pic_avr.Name = "pic_avr";
            this.pic_avr.Size = new System.Drawing.Size(60, 60);
            this.pic_avr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avr.TabIndex = 6;
            this.pic_avr.TabStop = false;
            // 
            // pic_bell
            // 
            this.pic_bell.BackgroundImage = global::Social_Media.Properties.Resources.icon_bell;
            this.pic_bell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_bell.Location = new System.Drawing.Point(951, 12);
            this.pic_bell.Name = "pic_bell";
            this.pic_bell.Size = new System.Drawing.Size(50, 50);
            this.pic_bell.TabIndex = 5;
            this.pic_bell.TabStop = false;
            // 
            // pic_person
            // 
            this.pic_person.BackgroundImage = global::Social_Media.Properties.Resources.icon_person;
            this.pic_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_person.Location = new System.Drawing.Point(859, 12);
            this.pic_person.Name = "pic_person";
            this.pic_person.Size = new System.Drawing.Size(50, 50);
            this.pic_person.TabIndex = 4;
            this.pic_person.TabStop = false;
            // 
            // pic_home
            // 
            this.pic_home.BackgroundImage = global::Social_Media.Properties.Resources.icon_homeClick;
            this.pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_home.Location = new System.Drawing.Point(765, 12);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(50, 50);
            this.pic_home.TabIndex = 3;
            this.pic_home.TabStop = false;
            // 
            // pic_search
            // 
            this.pic_search.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_search.BackgroundImage")));
            this.pic_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_search.Location = new System.Drawing.Point(516, 34);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(28, 28);
            this.pic_search.TabIndex = 2;
            this.pic_search.TabStop = false;
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_logo.BackgroundImage")));
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_logo.Location = new System.Drawing.Point(12, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(50, 50);
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // pnl_form
            // 
            this.pnl_form.AutoScroll = true;
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_form.Location = new System.Drawing.Point(0, 78);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(1364, 783);
            this.pnl_form.TabIndex = 1;
            // 
            // txt_seach
            // 
            this.txt_seach.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_seach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txt_seach.BorderColor = System.Drawing.Color.Transparent;
            this.txt_seach.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_seach.BorderRadius = 15;
            this.txt_seach.BorderSize = 2;
            this.txt_seach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seach.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_seach.Location = new System.Drawing.Point(97, 27);
            this.txt_seach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_seach.Multiline = false;
            this.txt_seach.Name = "txt_seach";
            this.txt_seach.Padding = new System.Windows.Forms.Padding(7);
            this.txt_seach.PasswordChar = false;
            this.txt_seach.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_seach.PlaceholderText = "";
            this.txt_seach.Size = new System.Drawing.Size(460, 35);
            this.txt_seach.TabIndex = 7;
            this.txt_seach.Texts = "Tìm kiếm người dùng";
            this.txt_seach.UnderlinedStyle = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 861);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.pnl_header);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.PictureBox pic_home;
        private CustomControls.RJControls.RJCircularPictureBox pic_avr;
        private System.Windows.Forms.PictureBox pic_bell;
        private System.Windows.Forms.PictureBox pic_person;
        private System.Windows.Forms.Panel pnl_form;
        private CustomControls.RJControls.RJTextBox txt_seach;
    }
}

