using NBA_League_Romania.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Repository.FIleRepositories
{
    internal class MeciFile : FileRepo<Meci>
    {
        IRepository<Guid, Echipa> echipe;
        public MeciFile(IRepository<Guid, Echipa> echipe ,string fileName)
        {
            this.echipe = echipe;
            readFromFile(fileName);
        }

        protected override Meci entityFromString(string data)
        {
            string[] properties = data.Split(';');
            Guid idEchipa1 = Guid.Parse(properties[1]);
            Guid idEchipa2 = Guid.Parse(properties[2]);

            return new Meci(Guid.Parse(properties[0]), echipe.FindOne(idEchipa1), echipe.FindOne(idEchipa2), DateTime.Parse(properties[3]));
        }
    }
}
