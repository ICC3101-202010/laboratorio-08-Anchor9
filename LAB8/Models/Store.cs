using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Store
    {
        private string name;
        private string owner;
        private string id;
        private string category;

        public string Name { get => name; set => name = value; }
        public string Owner { get => owner; set => owner = value; }
        public string ID { get => id; set => id = value; }
        public string Category { get => category; set => category = value; }
        public Store(string name, string owner, string id, string category)
        {
            this.Name = name;
            this.Owner = owner;
            this.ID = id;
            this.Category = category;



        }
    }
}
