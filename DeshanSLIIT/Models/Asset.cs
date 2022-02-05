using System.ComponentModel.DataAnnotations;

namespace DeshanSLIIT.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ISBN { get; set; }
    }
}
