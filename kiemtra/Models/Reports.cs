using System.ComponentModel.DataAnnotations;

namespace kiemtra.Models
{
    public class Reports
    {
        [Key]
        public int ReportID { get; set; }
       [Required]
        public string Reportname { get; set; }
        public DateTime ReportDate { get; set; }
        public int AccountID { get; set; }
        public Accounts? Account { get; set; }
        public int LogsID { get; set; }
        public Logs? Log { get; set; }
        public int TransactionalID { get; set; }
        public Transactions? Transaction { get; set; }
    }
}
