using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    internal class Elev : Entity<Guid>
    {
        public Elev() { }
        public Elev(Guid id, string name, string school) : base(id)
        {
            this.name = name;
            this.school = school;
        }

        private string name;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string school;
        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public override string ToString()
        {
            return Id.ToString() + ";" + Name + ";" + School;
        }
    }
}
