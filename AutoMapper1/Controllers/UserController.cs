using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserController> _logger;

        public UserController(IMapper mapper, IUserRepository userRepository ,ILogger<UserController> logger)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public ActionResult<UserDTO> Get()
        {
            var user = _userRepository.GetUser();
            return Ok(_mapper.Map<UserDTO>(user));
        }
    }
}