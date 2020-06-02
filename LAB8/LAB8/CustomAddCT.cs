using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB8.Controllers;

namespace LAB8
{
    public partial class CustomAddCT : UserControl
    {

        int counter = 0;
        public CustomAddCT()
        {
            
            InitializeComponent();
            labelID.Parent = pictureBox1;
            labelName.Parent = pictureBox1;
            labelOwner.Parent = pictureBox1;
            labelPowered.Parent = pictureBox1;
            labelTitle.Parent = pictureBox1;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxList_MouseClick(object sender, MouseEventArgs e)
        {
            if (counter == 0)
            {
                if (Form1.Option == 1)
                {
                    comboBoxList.Items.Add("Clothes");
                    comboBoxList.Items.Add("Kids");
                    comboBoxList.Items.Add("Home & Deco");
                }
                else if (Form1.Option == 2)
                {
                    comboBoxList.Items.Add("Exlcusive Tables");

                }
                else if (Form1.Option == 3)
                {
                    comboBoxList.Items.Add("Rooms");
                }
                else if (Form1.Option == 4)
                {

                }
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxName.Text != "" && textBoxOwner.Text != "")
            {
                if (Form1.Option == 1) 
                {
                    Form1.StoreC.AddStore(textBoxName.Text, textBoxID.Text, textBoxOwner.Text, comboBoxList.Text);
                    textBoxID.Clear();
                    textBoxName.Clear();
                    textBoxOwner.Clear();
                    comboBoxList.Items.Clear();
                    Form1.Customadd.Hide();
                    Form1.Mainmenu.Show();
                    counter = 0;
                }
                else if (Form1.Option == 2)
                {
                    Form1.RestaurantC.AddRest(textBoxName.Text, textBoxID.Text, textBoxOwner.Text, 4,6);
                    textBoxID.Clear();
                    textBoxName.Clear();
                    textBoxOwner.Clear();
                    Form1.Customadd.Hide();
                    Form1.Mainmenu.Show();
                }
                else if (Form1.Option == 3)
                {
                    Form1.cinemaC.AddCinema(textBoxName.Text, textBoxID.Text, textBoxOwner.Text, 4);
                    textBoxID.Clear();
                    textBoxName.Clear();
                    textBoxOwner.Clear();
                    Form1.Customadd.Hide();
                    Form1.Mainmenu.Show();
                }
                else if (Form1.Option == 4)
                {
                    Form1.recreationalC.AddRecrea(textBoxName.Text, textBoxID.Text, textBoxOwner.Text);
                    textBoxID.Clear();
                    textBoxName.Clear();
                    textBoxOwner.Clear();
                    Form1.Customadd.Hide();
                    Form1.Mainmenu.Show();
                }


            }
        }
    }
}
