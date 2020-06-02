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
    
    
    public partial class Form1 : Form
    {
        private static UserControl mainmenu;
        private static UserControl customadd;
        private static UserControl addmenu;
        private static int option;



        public Form1()
        {
            InitializeComponent();
            Mainmenu = mainMenuCT1;
            Addmenu = addMenuCT1;
            Customadd = customAddCT1;


        }

        public static UserControl Mainmenu { get => mainmenu; set => mainmenu = value; }
        public static UserControl Customadd { get => customadd; set => customadd = value; }
        public static UserControl Addmenu { get => addmenu; set => addmenu = value; }
        public static int Option { get => option; set => option = value; }
        public static CinemaC CinemaC { get => cinemaC; set => cinemaC = value; }
        public static RestaurantC RestaurantC { get => restaurantC; set => restaurantC = value; }
        public static RecreationalC RecreationalC { get => recreationalC; set => recreationalC = value; }
        public static StoreC StoreC { get => storeC; set => storeC = value; }

        public static CinemaC cinemaC = new CinemaC();
        public static RestaurantC restaurantC = new RestaurantC();
        public static RecreationalC recreationalC = new RecreationalC();
        public static StoreC storeC = new StoreC();
        private void Form1_Load(object sender, EventArgs e)
        {
            addMenuCT1.Hide();
            customAddCT1.Hide();
            



        }
    }
}
