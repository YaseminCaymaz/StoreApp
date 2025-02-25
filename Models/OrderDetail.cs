using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; } // İlişkili Order nesnesi

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; } // İlişkili Product nesnesi

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Adet 1 veya daha büyük olmalıdır.")] // Adet için sınırlandırma
        public int Piece { get; set; }

        [Column(TypeName = "decimal(18,2)")] // Fiyat için hassasiyet belirtme
        public decimal Price { get; set; } // Birim fiyat
    }
}