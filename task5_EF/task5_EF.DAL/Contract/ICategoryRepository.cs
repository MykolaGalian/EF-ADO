using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_EF.DAL.Model;

namespace task5_EF.DAL.Contract
{
    public interface ICategoryRepository
    {
        List<Category> Category_List();
    }
       
}
