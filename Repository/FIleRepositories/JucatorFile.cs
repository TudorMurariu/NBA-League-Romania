using NBA_League_Romania.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Repository.FIleRepositories
{
    internal class JucatorFile : FileRepo<Jucator>
    {
        IRepository<Guid, Echipa> echipe;
        public JucatorFile(IRepository<Guid, Echipa> echipe, string fileName) 
        {
            this.echipe = echipe;
            readFromFile(fileName);
        }

        protected override Jucator entityFromString(string data)
        {
            string[] properties = data.Split(';');
            Guid idEchipa = Guid.Parse(properties[3]);

            return new Jucator(Guid.Parse(properties[0]), properties[1], properties[2], echipe.FindOne(idEchipa));
        }
    }
}
