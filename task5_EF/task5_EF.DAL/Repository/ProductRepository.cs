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
    public class ProductRepository : IProductRepository
    {
        ProdDbContext db;  //контекст
        public ProductRepository(ProdDbContext _db)
        {
            db = _db;
        }

        public  List<ViewProduct> ListViewProductByCatId(int categoryID) // запрос списка продуктов по выбранной категории
        {
                var r1 = from pr in db.Product_
                         join ca in db.Category_ on pr.CategoryId equals ca.CategoryId
                         join su in db.Supplier_ on pr.SupplierId equals su.SupplierId
                         where pr.CategoryId == categoryID
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

        public  List<ViewProduct> ListViewProductByPrice(float price) // запрос  продукта по выбранной цене
        {
                var r1 = from pr in db.Product_
                         join ca in db.Category_ on pr.CategoryId equals ca.CategoryId
                         join su in db.Supplier_ on pr.SupplierId equals su.SupplierId
                         where pr.ProductPrice == price
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
    }
}
