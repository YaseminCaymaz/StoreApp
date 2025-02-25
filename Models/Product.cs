using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [StringLength(255, ErrorMessage = "Ürün adı en fazla 255 karakter olabilir.")]
        public string Name { get; set; } 

        public string Description { get; set; } 

        [Required(ErrorMessage = "Ürün fiyatı zorunludur.")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Ürün fiyatı 0.01'den büyük olmalıdır.")] // Fiyat için sınırlandırma
        public decimal Price { get; set; }
    }
}