using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task5_ADO.DAL.Model;
using task5_ADO.DAL.UOW;
using task5_ADO.DAL.View;

namespace task5_ADO.DAL.Repository
{
    public class ProductRepository
    {
        private Connection _con;

        public ProductRepository(IConnection con)
        {
            _con = con as Connection;
        }

       
        public IEnumerable<ViewProduct> ListViewProductByCatId(int categoryID)
        {
            using (var cmd = _con.CreateCommand())
            {
                cmd.CommandText =
                    "select pr.ProductName, pr.ProductPrice, ca.CategoryName, su.SupplierName " +
                    "from Product pr " +
                    "join Category ca on pr.CategoryId = ca.CategoryId " +
                    "join Supplier su on pr.SupplierId = su.SupplierId " +
                     "where pr.CategoryId = @categoryID";


                SqlParameter parameter = new SqlParameter()
                {
                    Value = categoryID,
                    ParameterName = "@categoryID"
                };


                cmd.Parameters.Add(parameter);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewProduct vprod = new ViewProduct();


                        vprod.ProductName = reader["ProductName"].ToString();
                        vprod.ProductPrice = (float)Convert.ToDouble(reader["ProductPrice"]);
                        vprod.CategoryName = reader["CategoryName"].ToString();
                        vprod.SupplierName = reader["SupplierName"].ToString();

                        yield return vprod;
                    }

                }
            }

        }

        public IEnumerable<ViewProduct> ListViewProductByPrice(float price)
        {
            using (var cmd = _con.CreateCommand())
            {
                cmd.CommandText =
                    "select pr.ProductName, pr.ProductPrice, ca.CategoryName, su.SupplierName " +
                    "from Product pr " +
                    "join Category ca on pr.CategoryId = ca.CategoryId " +
                    "join Supplier su on pr.SupplierId = su.SupplierId " +
                     "where pr.ProductPrice = @price";


                SqlParameter parameter = new SqlParameter()
                {
                    Value = price,
                    ParameterName = "@price"
                };


                cmd.Parameters.Add(parameter);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewProduct vprod = new ViewProduct();


                        vprod.ProductName = reader["ProductName"].ToString();
                        vprod.ProductPrice = (float)Convert.ToDouble(reader["ProductPrice"]);
                        vprod.CategoryName = reader["CategoryName"].ToString();
                        vprod.SupplierName = reader["SupplierName"].ToString();

                        yield return vprod;
                    }

                }
            }

        }
    }
}
