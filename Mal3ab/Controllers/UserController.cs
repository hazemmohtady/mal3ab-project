using AutoMapper;
using Mal3ab.Data;
using Mal3ab.Dtos;
using Mal3ab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mal3ab.Controllers
{
    [ApiController]
    [Route("api/users")]

    public class UserController : ControllerBase{
        private readonly IMapper _mapper;
        private readonly IUserRepo _userRepository;

        public UserController(IMapper mapper,IUserRepo repository)
        {
            _mapper=mapper;
            _userRepository=repository;
            
        }
        [HttpPost]
        public ActionResult<User> addUser(UserCreateDto usr){
            _userRepository.createUser(_mapper.Map<User>(usr));
            _userRepository.SaveChanges();
            return Ok("user created successfully");

    

        }
        
    }
    
}