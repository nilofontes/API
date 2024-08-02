using APITreino.Core.Models;
using APITreino.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITreino.Repository
{
    public class BaseRepository<T> where T : BaseModel
    {
        public T Create(T model)
        {
            model.CreatedAt = DateTime.Now;
            model.UpdatedAt = DateTime.Now;
            using (ApiContext context = new ApiContext())
            {
                context.Add(model);
                context.SaveChanges();
            }
            return model;
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> list = new List<T>();
            using(ApiContext context = new ApiContext())
            {
                list = context.Set<T>().ToList();
            }
            return list;
        }

        public void Update()
        {

        }

        public void Delete() { }

   
    }
}
