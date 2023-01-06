using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    internal class Meci : Entity
    {
        public Meci(Echipa echipa1, Echipa echipa2, DateTime date)
        { 
            this.echipa1 = echipa1;
            this.echipa2 = echipa2;
            this.date = date;
        }

        private Echipa echipa1;
        
        public Echipa Echipa1 
        { 
            get { 
                return this.echipa1;
            } 
            set {
                this.echipa1 = value;
            } 
        }

        private Echipa echipa2;

        public Echipa Echipa2 
        { 
            get { 
                return this.echipa2;
            } 
            set 
            { 
                this.echipa2 = value; 
            }
        }
        private DateTime date;

        public DateTime Date 
        { 
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
    }
}
