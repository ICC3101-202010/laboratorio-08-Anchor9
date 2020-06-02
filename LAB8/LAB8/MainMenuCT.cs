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
    public partial class MainMenuCT : UserControl
    {
        public MainMenuCT()
        {
            InitializeComponent();
            labelTitle.Parent = pictureBox1;
            labelPowered.Parent = pictureBox1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1.Mainmenu.Hide();
            Form1.Addmenu.Show();
        }

        private void labelPowered_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShopList shopList = new ShopList();
            shopList.Show();
        }
    }
}
