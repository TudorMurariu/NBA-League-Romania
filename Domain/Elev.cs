using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    internal class Elev : Entity<Guid>
    {
        public Elev(string name, string school)
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
    }
}
