using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    internal class Echipa : Entity
    {
        static int id_count = 0;
        public Echipa(string name) {
            
            this.name = name;
        }

        private string name { get; set; }
    }
}
