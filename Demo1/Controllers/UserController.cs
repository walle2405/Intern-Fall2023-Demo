using AutoMapper;
using Demo1.Model.ResponseModel;
using Demo1.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService; 
            _mapper = mapper;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userService.GetUsers();
            if (!result.Any())
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<UserResponse>>(result));
        }

        //public async Task<IActionResult> CreateNewUser(UserCreateRequest request)
        //{

        //}
    }
}
