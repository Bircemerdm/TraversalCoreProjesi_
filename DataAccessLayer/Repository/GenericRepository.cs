using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class GenericRepositor<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList(); //Entity Framework Core'un DbSet<T> koleksiyonunu döndürür.

        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);

        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
        }
    }
}
