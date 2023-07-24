using Dapper;
using MySqlConnector;
using SimpleDapper.Entities;
using SimpleDapper.Repositories.Interfaces;

namespace SimpleDapper.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlConnection _connection;

        public ProductRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public Task<Product> Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAll()
        {
            string sql = @"SELECT * FROM products p INNER JOIN categories c ON p.category_id = c.id";
            var result = await _connection.QueryAsync<Product, Category, Product>(sql, (product, category) =>
            {
                product.Category = category;
                product.CategoryId = category.Id;
                return  product;
            });
            return result.ToList();
        }

        public Task<List<Product>> GetAllLinqQuery()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllRawQuery()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdLinqQuery(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdRawQuery(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product product, int id)
        {
            throw new NotImplementedException();
        }
    }
}
