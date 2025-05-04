using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly IContext context;
        public UserRepository(IContext context)
        {
            this.context = context;
        }
        public User AddItem(User item)
        {
            context.Users.Add(item);
            context.Save();
            return item;
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
           return context.Users.ToList();
        }

        public User GetById(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateItem(int id, User item)
        {
            throw new NotImplementedException();
        }
    }
}
