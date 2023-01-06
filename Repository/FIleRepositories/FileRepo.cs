using NBA_League_Romania.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.Repository.FIleRepositories
{
    internal abstract class FileRepo<E> : InMemoryRepo<E>
        where E : Entity<Guid>, new()
    {
        public FileRepo(string fileName)
        {
            readFromFile(fileName);
        }

        private void readFromFile(string fileName)
        {
            StreamReader streamReaderreader = new StreamReader(fileName);
            string data;
            do
            {
                data = streamReaderreader.ReadLine();
                Save(entityFromString(data));

            }while(data != null);
        }

        protected abstract E entityFromString(string data);
    }
}
