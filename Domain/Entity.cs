using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    internal class Entity<ID>
    {
        public Entity() { }
        public Entity(ID id) 
        { 
            this.id = id;   
        }

        private ID id;
        
        public ID Id 
        { 
            get
            {
                return id;
            }
            set
            {
                id = value;
            } 
        }
    }
}
