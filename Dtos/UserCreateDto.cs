using System.ComponentModel.DataAnnotations;

namespace Mal3ab.Dtos
{
    public class UserCreateDto{
        [Required]
       public string phone{get;set;}
       [Required]
       public string password{get;set;}
       [Required]
       public string role{get;set;}
       [Required]
       public string user_name{get;set;}
    }
}