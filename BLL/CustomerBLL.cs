using StoreApp.DAL;
using StoreApp.Models;

public class CustomerBLL
{
    private readonly CustomerDAL _customerDAL;

    public CustomerBLL( CustomerDAL customerDAL)
    {
        _customerDAL = customerDAL;
    }

    public void NewCustomer(Customer customer)
    {
       
        if (customer==null)
        {
            throw new Exception("Müşteri bilgileri eksik veya hatalıdır.Lütfen tekrar deneyiniz.");
        }

        _customerDAL.AddCustomer(customer);
    }

    // Diğer BLL metotları buraya eklenebilir.

}