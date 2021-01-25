using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picturebox_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picTakumi.Visible = false;
        }
        
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            picTakumi.Visible = true;
        }

        private void picTakumi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
