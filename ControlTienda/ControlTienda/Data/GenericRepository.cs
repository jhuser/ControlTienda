using ControlTienda.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data
{
    using Entities;
    public class GenericRepository<T> : IGenericRepository<T> where T: class,IEntity
    {
        DataContext context = new DataContext();

        public GenericRepository(DataContext context) 
        {
            this.context = context;
        }
        public void Create(T entity)
        {
            var att = context.Set<T>();
            att.Add(entity);
            SaveAll();
        }
        public void Delete(T entity) 
        {
            this.context.Set<T>().Remove(entity);
            SaveAll();
        }
        public bool Exist(int id)
        {
            var att = context.Set<T>();
            return att.Any(e => e.Id == id);
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsNoTracking();
        }
        public T GetById(int id)
        {
            return context.Set<T>().FirstOrDefault(e => e.Id == id);
        }
        private void SaveAll()
        {
            this.context.SaveChanges();
        }

    }
}
