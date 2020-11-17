using System;
using System.ComponentModel.DataAnnotations;

namespace Mal3ab.Models
{
    public class Price
    {
        [Key]
       public int price_id{get;set;}
       [Required]
       public decimal price_hour{get;set;}

       [DataType(DataType.Date)]
       public DateTime end_date{get;set;}
       
    }
}
