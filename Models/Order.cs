using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models
{
    public class Order
    {
       public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
     [Required] 
    public string DiscountCode { get; set; }
     [Required] 
    public List<OrderDetail> OrderDetails{ get; set; }
    }
}