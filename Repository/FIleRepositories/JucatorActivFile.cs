using NBA_League_Romania.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Repository.FIleRepositories
{
    internal class JucatorActivFile : FileRepo<JucatorActiv>
    {
        public JucatorActivFile(string fileName) : base(fileName) { }

        protected override JucatorActiv entityFromString(string data)
        {
            string[] properties = data.Split(';');
            return new JucatorActiv(Guid.Parse(properties[0]), Guid.Parse(properties[1]), Guid.Parse(properties[2]), int.Parse(properties[3]), Tip.REZERVA);
        }
    }
}
