using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models.Classes
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string title { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string icon { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string type { get; set; } = "Expense";

    }
}
