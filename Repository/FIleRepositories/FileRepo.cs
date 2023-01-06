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
        protected FileRepo() { }
        public FileRepo(string fileName)
        {
            readFromFile(fileName);
        }

        protected void readFromFile(string fileName)
        {
            StreamReader streamReaderreader = new StreamReader(fileName);
            string data;
            while(true)
            {
                data = streamReaderreader.ReadLine();
                if (data == null)
                    break;

                Save(entityFromString(data));

            }
        }

        protected abstract E entityFromString(string data);
    }
}
