using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_EF.DAL.Model
{
    
        //public class BDInitializer : IDatabaseInitializer<ProdDbContext>
        //{
        //    public void InitializeDatabase(ProdDbContext context) // метод для кастомной инициализации БД - Code First
        //    {

        //        //if (context.Database.Exists()) context.Database.Delete();
        //        //context.Database.Create();

        //        if (context.Database.CreateIfNotExists()) // создать БД если её нет, и записать в БД начальные данные
        //        {

        //            // начальные данные для новых таблиц БД
        //            using (ProdDbContext db = new ProdDbContext())
        //            {
        //                Supplier sup1 = new Supplier()
        //                {
        //                     SupplierName = "Asus",
        //                     SupplierICity = "Stockholm"
        //                };
        //                Supplier sup2 = new Supplier()
        //                {
        //                    SupplierName = "Lenovo",
        //                    SupplierICity = "Beijing"
        //                };
                        
        //                db.Supplier_.AddRange(new[] { sup1, sup2 });
        //                db.SaveChanges();

        //                Category cat1 = new Category()
        //                {
        //                    CategoryName = "Mobile Phones"
        //                };
        //                Category cat2 = new Category()
        //                {
        //                    CategoryName = "Laptops"
        //                };
        //                db.Category_.AddRange(new[] { cat1, cat2 });
        //                db.SaveChanges();

        //                Product pr1 = new Product()
        //                {
        //                    ProductName = "FCV-123",
        //                    ProductPrice = 122.21f,
        //                    CategoryId = 1,
        //                    SupplierId = 1
        //                };
        //                Product pr2 = new Product()
        //                {
        //                    ProductName = "CVB-1763",
        //                    ProductPrice = 100.10f,
        //                    CategoryId = 1,
        //                    SupplierId = 2
        //                };
        //                Product pr3 = new Product()
        //                {
        //                    ProductName = "CFHB-17EB",
        //                    ProductPrice = 10000.10f,
        //                    CategoryId = 2,
        //                    SupplierId = 1
        //                };
        //                Product pr4 = new Product()
        //                {
        //                    ProductName = "CFDFC-43E",
        //                    ProductPrice = 12000.10f,
        //                    CategoryId = 2,
        //                    SupplierId = 2
        //                };
        //                db.Product_.AddRange(new[] { pr1, pr2, pr3, pr4 });
        //                db.SaveChanges();

        //            }
        //        }
        //    }
        //}
    
}
