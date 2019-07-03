using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_EF.DAL.Model;
using task5_EF.DAL.View;

namespace task5_EF.DAL.Contract
{
    public interface ISupplierRepository
    {
        List<Supplier> Supplier_List();
        List<ViewProduct> ListViewProductByIdSup(int supplierID);
        List<ViewSupplier> ListViewSupByCityName(string cityName);
    }
}
