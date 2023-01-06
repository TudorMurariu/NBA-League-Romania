using NBA_League_Romania.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Repository.FIleRepositories
{
    internal class ElevFile : FileRepo<Elev>
    {
        public ElevFile(string fileName) : base(fileName) { }

        protected override Elev entityFromString(string data)
        {
            string[] properties = data.Split(';');
            return new Elev(Guid.Parse(properties[0]), properties[1], properties[2]);
        }
    }
}
