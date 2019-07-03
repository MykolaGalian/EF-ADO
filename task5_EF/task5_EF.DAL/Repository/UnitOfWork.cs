using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_EF.DAL.Model;
using task5_EF.DAL.Repository;

namespace task5_EF.DAL.Repository
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed = false;

        private ProdDbContext db = new ProdDbContext();
        private CategoryRepository categoryRepository;
        private ProductRepository productRepository;
        private SupplierRepository supplierRepository;


        public CategoryRepository CategoryRepository
        {
            get
            {

                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new CategoryRepository(db);
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
                    this.productRepository = new ProductRepository(db);
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
                    this.supplierRepository = new SupplierRepository(db);
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
                    db.Dispose();
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
