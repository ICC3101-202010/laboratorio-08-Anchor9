using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Recreational
    {
        private string name;
        private string owner;
        private string id;

        public string Name { get => name; set => name = value; }
        public string Owner { get => owner; set => owner = value; }
        public string ID { get => id; set => id = value; }

        public Recreational(string name, string owner, string id)
        {
            this.Name = name;
            this.Owner = owner;
            this.ID = id;
            



        }
       
    }
}
