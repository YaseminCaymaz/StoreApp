using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // ForeignKey için eklendi

namespace StoreApp.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")] // İlişkiyi belirtir (EF Core için)
        public Customer Customer { get; set; } // İlişkili Customer nesnesi

        public DateTime OrderDate { get; set; } = DateTime.Now; // Varsayılan olarak sipariş tarihi

        [Column(TypeName = "decimal(18,2)")] // Decimal için hassasiyet belirtme
        public decimal TotalPrice { get; set; }

        [StringLength(50)] // İndirim kodu uzunluğu sınırlama
        public string DiscountCode { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}