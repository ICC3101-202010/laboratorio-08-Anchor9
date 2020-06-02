using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace LAB8.Controllers
{
    public class StoreC
    {
        private List<Store>stores = new List<Store>();

        public List<Store> Stores { get => stores; set => stores = value; }

        public void AddStore(string name, string id, string owner, string category)
        {

            Store n_store = new Store(name, id, owner, category);
            Stores.Add(n_store);

        }

    }
}
