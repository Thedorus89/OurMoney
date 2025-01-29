using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OurMoney.Core.Models
{
    public class Category
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // Navigation Property
        public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
