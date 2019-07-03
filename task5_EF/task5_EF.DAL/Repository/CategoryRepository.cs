using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_EF.DAL.Contract;
using task5_EF.DAL.Model;

namespace task5_EF.DAL.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        ProdDbContext db;  //контекст

        public CategoryRepository(ProdDbContext _db)
        {
            db = _db;
        }

        public  List<Category> Category_List() //список Product
        {            
                return db.Category_.ToList();            
        }
    }
}
