using System;
using System.Collections.Generic;
using System.Data;
using ASP_DotNetCore_MVC_Exercise1.Models;
using Dapper;

namespace ASP_DotNetCore_MVC_Exercise1
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }
    }
}
