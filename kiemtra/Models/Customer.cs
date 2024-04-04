using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace kiemtra.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        public string ContactAndAddress { get; set; }
        [Required]

        public string Username { get; set; }
        [Required]  
        public string Password { get; set; }
        public ICollection<Accounts> Accounts { get; set; }
    }
}
