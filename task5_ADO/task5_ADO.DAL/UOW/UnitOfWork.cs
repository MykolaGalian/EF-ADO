using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_ADO.DAL.Model;
using task5_ADO.DAL.Repository;

namespace task5_ADO.DAL.UOW
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed = false;

        private Connection _con = new Connection();
        //private ProdDbContext db = new ProdDbContext();
        
        private ProductRepository productRepository;
        private SupplierRepository supplierRepository;
        private CategoryRepository categoryRepository;


       

        public CategoryRepository CategoryRepository
        {
            get
            {

                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new CategoryRepository(_con);
                }
                return categoryRepository;
            }
        }

        public ProductRepository ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new ProductRepository(_con);
                }
                return productRepository;
            }
        }

        public SupplierRepository SupplierRepository
        {
            get
            {

                if (this.supplierRepository == null)
                {
                    this.supplierRepository = new SupplierRepository(_con);
                }
                return supplierRepository;
            }
        }




        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _con.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
