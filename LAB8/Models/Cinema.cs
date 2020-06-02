using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cinema
    {
        private string name;
        private string owner;
        private string id;
        private int rooms;

        public string Name { get => name; set => name = value; }
        public string Owner { get => owner; set => owner = value; }
        public string ID { get => id; set => id = value; }
        public int Rooms { get => rooms; set => rooms = value; }

        public Cinema(string name, string owner, string id, int rooms) 
        {
            this.Name = name;
            this.Owner = owner;
            this.ID = id;
            this.Rooms = rooms;

        
        
        }
    }
}
