using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace LAB8.Controllers
{
    public class RecreationalC
    {

        private List<Recreational> recreational = new List<Recreational>();

        public List<Recreational> Recreational { get => recreational; set => recreational = value; }

        public void AddRecrea(string name, string id, string owner)
        {

            Recreational recrea= new Recreational(name, id, owner);
            Recreational.Add(recrea);

        }
    }
}
