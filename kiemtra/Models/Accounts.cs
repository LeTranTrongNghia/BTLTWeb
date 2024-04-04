using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace kiemtra.Models
{
    public class Accounts
    {
        [Key]
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
    }
}
