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
    public class SupplierRepository
    {
        private Connection _con;

        public SupplierRepository(IConnection con)
        {
            _con = con as Connection;
        }


        
        public IEnumerable<Supplier> List_Supplier()
        {
            using (var cmd = _con.CreateCommand())
            {
                cmd.CommandText = "SELECT SupplierId, SupplierName, SupplierICity FROM Supplier";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Supplier cat = new Supplier();

                        cat.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                        cat.SupplierName = reader["SupplierName"].ToString();
                        cat.SupplierICity = reader["SupplierICity"].ToString();

                        yield return cat;
                    }
                }
            }
        }

        public IEnumerable<ViewProduct> ListViewProductByIdSup(int supplierID)
        {

            using (var cmd = _con.CreateCommand())
            {
                cmd.CommandText =
                    "select pr.ProductName, pr.ProductPrice, ca.CategoryName, su.SupplierName from Product pr " +
                    "join Category ca on pr.CategoryId = ca.CategoryId " +
                    "join Supplier su on pr.SupplierId = su.SupplierId " +
                    "where su.SupplierId = @supplierID";

                SqlParameter parameter = new SqlParameter()
                {
                    Value = supplierID,
                    ParameterName = "@supplierID"
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

        public IEnumerable<ViewSupplier> ListViewSupByCityName(string cityName)
        {
            using (var cmd = _con.CreateCommand())
            {
                cmd.CommandText = "select SupplierName, SupplierICity  from Supplier where SupplierICity like @cityName";

                SqlParameter parameter = new SqlParameter()
                {
                    Value = cityName,
                    ParameterName = "@cityName"
                };


                cmd.Parameters.Add(parameter);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewSupplier sprod = new ViewSupplier();


                        sprod.SupplierName = reader["SupplierName"].ToString();
                        sprod.SupplierCity = reader["SupplierICity"].ToString();

                        yield return sprod;
                    }

                }
            }

        }
    }
}
