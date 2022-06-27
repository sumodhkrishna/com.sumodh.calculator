using System.ComponentModel.DataAnnotations;

namespace com.sumodh.calculator.Common
{
    public class ValuesDTO
    {
        [Required]
        public decimal Value1 { get; set; }
        [Required]
        public decimal Value2 { get; set; } 
    }
}
