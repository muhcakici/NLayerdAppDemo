using Northwind.DataAccess.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernite
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            
        }

        public void Delete(Product product)
        {
            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return new List<Product>()
            {
                new Product(){ CategoryId=1, ProductId=3, ProductName="PC", UnitPrice=3000, UnitsInStock=7, QuantityPerUnit="36 Boxes"}
            };
        }

        public void Update(Product product)
        {
            
        }
    }
}
