using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    internal class Entity
    {
        
        private int id;
        static int id_count = 0;

        public Entity()
        {
            this.id = id_count++;
        }
    }
}
