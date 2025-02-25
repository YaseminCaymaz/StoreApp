namespace StoreApp.Models
{
    public class OrderDetail
    {
       public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Piece { get; set; }
    public decimal Price { get; set; }
    }
}