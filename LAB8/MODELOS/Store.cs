using System;
using System.Collections.Generic;
using System.Text;

namespace MODELOS
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
    }
}
