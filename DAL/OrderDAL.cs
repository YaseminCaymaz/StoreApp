using Dapper;
using Npgsql;
using StoreApp.Models;

namespace StoreApp.DAL
{
  public class OrderDAL
{
    private readonly string _connectionString;

    public OrderDAL(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Order> GetOrders()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Query<Order>("SELECT * FROM Orders").ToList();
        }
    }

        internal void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        internal int GetSon24SaatSiparisSayisi(int customerId)
        {
            throw new NotImplementedException();
        }

        // Diğer DAL metotları buraya eklenebilir.
    }
}