using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace kiemtra.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required, StringLength (50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        public string ContactAndAddress { get; set; }
        public string UsernameAndPassword { get; set; }
    }
}
