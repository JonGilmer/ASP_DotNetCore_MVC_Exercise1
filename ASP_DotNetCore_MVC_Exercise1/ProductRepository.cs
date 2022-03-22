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

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM products WHERE productID = @id;",
                new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name = @Name, Price = @price WHERE productID = @id;",
                new { name = product.Name, price = product.Price, id = product.ProductID });
        }
    }
}
