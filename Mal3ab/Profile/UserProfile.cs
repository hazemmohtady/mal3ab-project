using AutoMapper;
using Mal3ab.Dtos;
using Mal3ab.Models;

namespace Mal3ab.Profiles
{
    public class UserProfile:Profile{
        public UserProfile(){
            CreateMap<UserCreateDto,User>();
        }
    }
}



