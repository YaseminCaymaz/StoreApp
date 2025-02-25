using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }
         [Required] 
        public string Surname { get; set; }
         [Required] 
        public string Email { get; set; }
         [Required] 
        public string Phone { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}