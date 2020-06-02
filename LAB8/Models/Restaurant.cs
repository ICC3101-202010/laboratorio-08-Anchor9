using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Restaurant
    {

        private string name;
        private string owner;
        private string id;
        private int exlcusive_table;
        private int tables;

        public string Name { get => name; set => name = value; }
        public string Owner { get => owner; set => owner = value; }
        public string ID { get => id; set => id = value; }
        public int Exlcusive_table { get => exlcusive_table; set => exlcusive_table = value; }
        public int Tables { get => tables; set => tables = value; }

        public Restaurant(string name, string owner, string id, int Exlcusive_tables, int tables)
        {
            this.Name = name;
            this.Owner = owner;
            this.ID = id;
            this.Exlcusive_table = Exlcusive_tables;
            this.Tables = tables;




        }
    }
}
