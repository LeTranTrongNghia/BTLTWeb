using System.ComponentModel.DataAnnotations; 
using System.Security.Principal; 

namespace kiemtra.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionalID { get; set; }

        public int EmployeeID { get; set; }
        public Employees? Employee { get; set; }

        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
