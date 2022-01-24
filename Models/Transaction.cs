using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Everything.Models
{
    public class Transaction
    {
        public int id {get; set;}
        public string Article {get; set;} = string.Empty;
        public int Quantity {get; set;}
        [Column(TypeName = "double(18, 2)")]
        public double Price {get; set;}
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}
    }
}