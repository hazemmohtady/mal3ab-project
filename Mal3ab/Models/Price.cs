using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mal3ab.Models
{
    public class Price
    {
        [Key]
       public int price_id{get;set;}
       [Required]
       [Column(TypeName = "decimal(5,1)")]
       public decimal price_hour{get;set;}

       [DataType(DataType.Date)]
       public DateTime end_date{get;set;}
       
    }
}
