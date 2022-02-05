using System.ComponentModel.DataAnnotations;

namespace DeshanSLIIT.Models
{
    public class Transfer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TID { get; set; }
        [Required]
        public int CartID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
