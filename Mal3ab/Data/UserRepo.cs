using System;
using Mal3ab.Models;

namespace Mal3ab.Data
{
    public class UserRepo : IUserRepo{
        private readonly Mal3abContext _context;

        public UserRepo(Mal3abContext context)
        {
            _context=context;   
        }

        public void createUser(User usr){

           /* if (usr == null)
            {
                throw new ArgumentNullException(nameof(usr));
            }
            */
            _context.Users.Add(usr);
            
        } 
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        
    } 
}