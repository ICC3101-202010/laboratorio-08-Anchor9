using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class AddMenuCT : UserControl
    {
        public AddMenuCT()
        {
            InitializeComponent();
            labelPowered.Parent = pictureBox1;
            labelTitle.Parent = pictureBox1;
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            Form1.Option = 1;
            Form1.Addmenu.Hide();
            Form1.Customadd.Show();
        }

        private void btnCinema_Click(object sender, EventArgs e)
        {
            Form1.Option = 2;
            Form1.Addmenu.Hide();
            Form1.Customadd.Show();
        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            Form1.Option = 3;
            Form1.Addmenu.Hide();
            Form1.Customadd.Show();
        }

        private void btnRecreational_Click(object sender, EventArgs e)
        {
            Form1.Option = 4;
            Form1.Addmenu.Hide();
            Form1.Customadd.Show();
        }
    }
}
