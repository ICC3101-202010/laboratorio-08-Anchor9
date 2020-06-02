using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace LAB8.Controllers
{
    public class RestaurantC
    {
        private List<Restaurant> restaurants = new List<Restaurant>();

        public List<Restaurant> Restaurants { get => restaurants; set => restaurants = value; }

        public void AddRest(string name, string id, string owner, int e_t, int t)
        {

            Restaurant restaurant = new Restaurant(name, id, owner, e_t, t);
            Restaurants.Add(restaurant);

        }
    }
}
