using System.ComponentModel.DataAnnotations;

namespace DeshanSLIIT.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CategoryType { get; set; }
    }
}
