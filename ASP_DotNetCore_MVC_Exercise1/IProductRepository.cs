using System;
using System.Collections.Generic;
using ASP_DotNetCore_MVC_Exercise1.Models;

namespace ASP_DotNetCore_MVC_Exercise1
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);

    }
}
