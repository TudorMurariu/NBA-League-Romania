using NBA_League_Romania.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NBA_League_Romania.Repository
{
    internal class InMemoryRepo<E> : IRepository<Guid, E>
        where E : Entity<Guid>, new()
    {
        private Dictionary<Guid, E> entities;

        public InMemoryRepo() => entities = new Dictionary<Guid, E>();

        public IEnumerable<E> FindAll() => entities.Values;


        public E? FindOne(Guid id)
        {
            E? entity = null;
            try
            {
                entity = entities[id];
            }
            catch(Exception ex) { }

            return entity;
        }

        public E Save(E entity)
        {
            entity.Id = Guid.NewGuid();
            entities[entity.Id] = entity;
            return entity;
        }

        public bool Delete(Guid id)
        {
            return entities.Remove(id);
        }

        public void ReadFromFile(string file)
        {

        }
    }
}
