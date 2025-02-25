using Dapper;
using Npgsql;
using StoreApp.Models;

namespace StoreApp.DAL
{
  public class CustomerDAL
{
    private readonly string _connectionString;

    public CustomerDAL(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Customer> GetCustomers()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Query<Customer>("SELECT * FROM Customers").ToList();
        }
    }

        internal void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        // Diğer DAL metotları buraya eklenebilir.
    }
}