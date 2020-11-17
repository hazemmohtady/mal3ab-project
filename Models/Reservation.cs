using System;
using System.ComponentModel.DataAnnotations;

namespace Mal3ab.Models
{
    public class Reservation
    {
        [Key]
       public int reservation_id{get;set;}
       [Required]
       public User client_id{get;set;}
       [Required]
       public User creator_id{get;set;}
       [Required]
       public User approver_id{get;set;}
       [Required]
       public decimal price_hour{get;set;}
       
       [Required]
       public DateTime from{get;set;}
       [Required]
       public DateTime to{get;set;}
       [Required]
       public Boolean reservation_type{get;set;}
    }
}
