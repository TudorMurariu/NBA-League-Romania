using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    internal class Echipa : Entity<Guid>
    {
        public Echipa() { }
        public Echipa(Guid id, string name) : base(id)
        {
            this.name = name;
        }

        private string name;
        
        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
