/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoFoods.DomainEntities;

namespace EcoFoods.Infrastructure.DataAccess
{
    class UnitOfWork : IDisposable
    {
        private ProductDBContext context = new ProductDBContext();
        private GenericRepository<Product> productRepository;
        public GenericRepository<Product> productRepository
        {
            get
            {
                return this.productRepository ?? new GenericRepository<Product>(context);
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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
*/