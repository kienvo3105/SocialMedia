﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Social_Media.Form_component;
namespace Social_Media
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            write write = new write();
            write.ShowDialog();
        }

        private void rjPanel1_Click(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }
    }
}
