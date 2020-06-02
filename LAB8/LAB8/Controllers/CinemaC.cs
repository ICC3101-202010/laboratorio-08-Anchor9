using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace LAB8.Controllers
{
    public class CinemaC
    {

        private List<Cinema> cinema = new List<Cinema>();

        public CinemaC()
        {

        }

        public List<Cinema> Cinema { get => cinema; set => cinema = value; }

        public void AddCinema (string name, string id, string owner, int rooms) 
        {

            Cinema cinema = new Cinema(name, id, owner, rooms);
            Cinema.Add(cinema);
        
        }
    }
}
