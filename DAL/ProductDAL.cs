using Dapper;
using Npgsql;
using StoreApp.Models;

namespace StoreApp.DAL
{
  public class ProductDAL
{
    private readonly string _connectionString;

    public ProductDAL(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Product> GetProducts()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Query<Product>("SELECT * FROM Products").ToList();
        }
    }

        internal void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        // Diğer DAL metotları buraya eklenebilir.
    }
}