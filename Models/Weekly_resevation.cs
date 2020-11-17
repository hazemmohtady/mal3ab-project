using System;
using System.ComponentModel.DataAnnotations;

namespace Mal3ab.Models
{
    public class Weekly_reservation
    {
        [Key]
       public int reservation_id{get;set;}
       [Required]
       public User client_id{get;set;}
       [Required]
       public User creator_id{get;set;}
       [Required]
       [DataType(DataType.Time)]
       public DateTime from{get;set;}
       [Required]
       [DataType(DataType.Time)]
       public DateTime to{get;set;}
       [Required]
       public int day{get;set;}
    }
}
