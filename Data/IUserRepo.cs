using Mal3ab.Models;

namespace Mal3ab.Data
{
    public interface IUserRepo{
        bool SaveChanges();
        void createUser(User usr);
    }
}