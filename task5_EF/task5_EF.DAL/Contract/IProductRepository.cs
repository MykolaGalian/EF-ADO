using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_EF.DAL.View;

namespace task5_EF.DAL.Contract
{
    public interface IProductRepository
    {
        List<ViewProduct> ListViewProductByCatId(int categoryID);
        List<ViewProduct> ListViewProductByPrice(float price);
    }
}
