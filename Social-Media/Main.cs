using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            home.TopLevel = false;
            pnl_form.Controls.Add(home);
            home.Show();
        }
    }
}
