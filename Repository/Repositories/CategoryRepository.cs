using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IContext context;
        
        public CategoryRepository(IContext context) { 

        this.context = context;
        }
       
        public Category AddItem(Category item)
        {
           this.context.Categories.Add(item);
            this.context.Save();
            return item;
        }

        public void DeleteItem(int id)
        {
            this.context.Categories.Remove(GetById(id));
            this.context.Save();
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateItem(int id, Category item)
        {
            var category = GetById(id);
            category.Name = item.Name;
            context.Save();
        }
    }
}
