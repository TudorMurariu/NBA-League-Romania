﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Domain
{
    internal class Jucator : Elev
    {
        public Jucator(string name, string school, Echipa echipa) : base(name, school)
        {
            this.echipa = echipa;
        }

        private Echipa echipa;
        
        public Echipa Echipa 
        { 
            get
            {
                return this.echipa;
            }
            set
            {
                this.echipa = value;
            }
        }
    }
}
