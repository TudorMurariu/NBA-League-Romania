using NBA_League_Romania.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Repository.FIleRepositories
{
    internal class EchipaFile : FileRepo<Echipa>
    {
        public EchipaFile(string fileName) : base(fileName) { }

        protected override Echipa entityFromString(string data)
        {
            string[] properties = data.Split(';');
            return new Echipa(Guid.Parse(properties[0]), properties[1]);
        }
    }
}
