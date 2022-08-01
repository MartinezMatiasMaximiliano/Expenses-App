using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models.Classes
{
    public class Transaction
    {
        [Key]
        public int transactionId { get; set; }

        [Required]
        public int categoryId { get; set; }
        public Category category { get; set; }


        [Column(TypeName = "varchar(50)")]
        public int amount { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? notes { get; set; }


        public DateTime date { get; set; } = DateTime.Now;

    }
}
