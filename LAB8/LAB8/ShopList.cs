using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB8.Controllers;
using Models;

namespace LAB8
{
    public partial class ShopList : Form
    {
        public ShopList()
        {
            InitializeComponent();
        }

        private void ShopList_Load(object sender, EventArgs e)
        {
            foreach (Store store in Form1.StoreC.Stores)
            {
                Panel panel_contain = new Panel();
                Label label_name = new Label();
                Label label_category= new Label();
                Label label_id = new Label();
                Label label_owner = new Label();
                label_name.Text = "Name: " + store.Name;
                label_id.Text = "ID: " + store.ID;
                label_owner.Text = "Owner: " + store.Owner;
                label_category.Text = "Category" + store.Category;

                label_name.ForeColor = Color.DarkOrange;
                //label_name.Font.Size = Convert.ToUInt32(11.0);
                label_name.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_name);

                label_id.ForeColor = Color.DarkOrange;
                label_id.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_id);

                label_owner.ForeColor = Color.DarkOrange;
                label_owner.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_owner);

                panel_contain.Dock = DockStyle.Top;
                panel_contain.BackColor = Color.FromArgb(0, 0, 0, 0);

                pictureBox1.Controls.Add(panel_contain);

            }

            foreach (Cinema cine in Form1.cinemaC.Cinema)
            {
                Panel panel_contain = new Panel();
                Label label_name = new Label();

                Label label_id = new Label();
                Label label_owner = new Label();
                label_name.Text = "Name: " + cine.Name;
                label_id.Text = "ID: " + cine.ID;
                label_owner.Text = "Owner: " + cine.Owner;

                label_name.ForeColor = Color.DarkOrange;
                //label_name.Font.Size = Convert.ToUInt32(11.0);
                label_name.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_name);

                label_id.ForeColor = Color.DarkOrange;
                label_id.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_id);

                label_owner.ForeColor = Color.DarkOrange;
                label_owner.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_owner);

                panel_contain.Dock = DockStyle.Top;
                panel_contain.BackColor = Color.FromArgb(0, 0, 0, 0);

                pictureBox1.Controls.Add(panel_contain);


            }
            foreach (Restaurant restoran in Form1.RestaurantC.Restaurants)
            {
                Panel panel_contain = new Panel();
                Label label_name = new Label();

                Label label_id = new Label();
                Label label_owner = new Label();

                label_name.Text = "Name: " + restoran.Name;
                label_id.Text = "ID: " + restoran.ID;
                label_owner.Text = "Owner: " + restoran.Owner;

                label_name.ForeColor = Color.DarkOrange;
                //label_name.Font.Size = Convert.ToUInt32(11.0);
                label_name.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_name);

                label_id.ForeColor = Color.DarkOrange;
                label_id.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_id);

                label_owner.ForeColor = Color.DarkOrange;
                label_owner.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_owner);

                panel_contain.Dock = DockStyle.Top;
                panel_contain.BackColor = Color.FromArgb(0, 0, 0, 0);

                pictureBox1.Controls.Add(panel_contain);


            }
            foreach (Recreational rec in Form1.RecreationalC.Recreational)
            {
                Panel panel_contain = new Panel();
                Label label_name = new Label();

                Label label_id = new Label();
                Label label_owner = new Label();
                label_name.Text = "Name: " + rec.Name;
                label_id.Text = "ID: " + rec.ID;
                label_owner.Text = "Owner: " + rec.Owner;

                label_name.ForeColor = Color.DarkOrange;
                //label_name.Font.Size = Convert.ToUInt32(11.0);
                label_name.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_name);

                label_id.ForeColor = Color.DarkOrange;
                label_id.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_id);

                label_owner.ForeColor = Color.DarkOrange;
                label_owner.Dock = DockStyle.Left;
                panel_contain.Controls.Add(label_owner);

                panel_contain.Dock = DockStyle.Top;
                panel_contain.BackColor = Color.FromArgb(0, 0, 0, 0);

                pictureBox1.Controls.Add(panel_contain);
            }
        }
    }
}
