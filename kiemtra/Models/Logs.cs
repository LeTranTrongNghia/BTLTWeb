using System.ComponentModel.DataAnnotations;

namespace kiemtra.Models
{
    public class Logs
    {
        [Key]
        public int LogID { get; set; }
        public int TransactionalID { get; set; }
        public TimeOnly LoginDate { get; set; }
        public DateOnly LoginTime { get; set; }
    }
}
