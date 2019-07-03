using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_EF.DAL.Contract;
using task5_EF.DAL.Model;
using task5_EF.DAL.View;

namespace task5_EF.DAL.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        ProdDbContext db;  //контекст
        public SupplierRepository(ProdDbContext _db)
        {
            db = _db;
        }

        public  List<Supplier> Supplier_List() //список Supplier
        {            
                return db.Supplier_.ToList();            
        }

        public  List<ViewProduct> ListViewProductByIdSup(int supplierID) // запрос списка продуктов по выбранному поставщику
        {   
                var r1 = from pr in db.Product_
                         join ca in db.Category_ on pr.CategoryId equals ca.CategoryId
                         join su in db.Supplier_ on pr.SupplierId equals su.SupplierId
                         where su.SupplierId == supplierID
                         select new ViewProduct
                         {
                             ProductName = pr.ProductName,
                             ProductPrice = pr.ProductPrice,
                             CategoryName = ca.CategoryName,
                             SupplierName = su.SupplierName
                         };
                r1.Load();
                return r1.ToList();
        }

        public  List<ViewSupplier> ListViewSupByCityName(string cityName) // запрос списка поставщиков по выбранному городу
        {
                var r1 = from sp in db.Supplier_
                         where sp.SupplierICity == cityName
                         select new ViewSupplier
                         {
                             SupplierName = sp.SupplierName,
                             SupplierCity = sp.SupplierICity
                         };
                r1.Load();

                return r1.ToList();            
        }
    }
}
