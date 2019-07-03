using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task5_ADO.DAL.Model;
using task5_ADO.DAL.UOW;

namespace task5_ADO.DAL.Repository
{
    public class CategoryRepository
    {

        private Connection _con;

        public CategoryRepository(IConnection con)
        {
            _con = con as Connection;
        }



        public IEnumerable<Category> List_Category()
        {
            using (var cmd = _con.CreateCommand())
            {
                cmd.CommandText = "SELECT CategoryId, CategoryName FROM Category";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category cat = new Category();

                        cat.CategoryId = Convert.ToInt32(reader["CategoryId"]); ;
                        cat.CategoryName = reader["CategoryName"].ToString();


                        yield return cat;
                    }
                }
            }
        }
    }
}
