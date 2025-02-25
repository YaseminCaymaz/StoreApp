using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Validation için eklendi
namespace StoreApp.Models
{

public class Customer
{
    [Key] // Primary key olduğunu belirtir (EF Core için)
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan Id (EF Core için)
    public int Id { get; set; }

    [Required(ErrorMessage = "Ad alanı zorunludur.")] // Validation
    [StringLength(50, ErrorMessage = "Ad alanı en fazla 50 karakter olabilir.")] // Validation
    public string Name { get; set; }

    [Required(ErrorMessage = "Soyad alanı zorunludur.")] // Validation
    [StringLength(50, ErrorMessage = "Soyad alanı en fazla 50 karakter olabilir.")] // Validation
    public string Surname { get; set; }

    [Required(ErrorMessage = "E-posta alanı zorunludur.")] // Validation
    [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")] // Validation
    public string Email { get; set; }

    [Required(ErrorMessage = "Telefon alanı zorunludur.")] // Validation
    [Phone(ErrorMessage = "Geçerli bir telefon numarası girin.")] // Validation
    public string Phone { get; set; }

    public DateTime RegisterDate { get; set; } = DateTime.Now; // Varsayılan olarak şu anki tarih
}
}