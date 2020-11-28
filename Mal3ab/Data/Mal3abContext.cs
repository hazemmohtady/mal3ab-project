using Mal3ab.Models;
using Microsoft.EntityFrameworkCore;

namespace Mal3ab.Data{
   public class Mal3abContext : DbContext{
       public Mal3abContext(DbContextOptions<Mal3abContext> opt) : base(opt)
       {
           
       }
       public DbSet<User> Users {get;set;}
       public DbSet<Reservation> Reservations {get;set;}
       public DbSet<Weekly_reservation> Weekly_reservations {get;set;}
       public DbSet<Price> Prices {get;set;}

   } 
}