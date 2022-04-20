using Fingers10.ExcelExport.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DeshanSLIIT.Models
{
    public class Asset
    {
        [Key]
        [IncludeInReport(Order = 1)]
        public int Id { get; set; }
        [Required]
        [IncludeInReport(Order = 2)]
        public string Name { get; set; }
        [Required]
        [IncludeInReport(Order = 3)]
        public string ISBN { get; set; }
    }
}
