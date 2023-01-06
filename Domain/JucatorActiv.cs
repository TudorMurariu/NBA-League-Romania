using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    enum Tip
    {
        REZERVA,
        JUCATOR
    }
    internal class JucatorActiv : Entity<Guid>
    {
        public JucatorActiv() { }

        private Guid idJucator;
        
        public Guid IdJucator 
        { 
            get { return idJucator; }
            set { idJucator = value; }
        }

        private Guid idMeci;
        public Guid IdMeci
        { 
            get { return idMeci; } 
            set { idMeci = value; } 
        }

        private int nrPuncteInscrise;

        public int NrPuncteInscrise
        {
            get { return nrPuncteInscrise;  }
            set { nrPuncteInscrise = value;}
        }

        private Tip tip;
        public Tip Tip
        { 
            get { return tip; }
            set { tip = value; } 
        }

        public JucatorActiv(Guid id, Guid idJucator, Guid idMeci, int nrPuncteInscrise, Tip tip) : base(id) 
        {
            this.idJucator = idJucator;
            this.idMeci = idMeci;
            this.nrPuncteInscrise = nrPuncteInscrise;
            this.tip = tip;
        }
    }
}
