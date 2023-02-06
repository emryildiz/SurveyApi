using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApi.Common.Dtos;
using SurveyApi.Common.Entities;
using SurveyApi.Services;

namespace SurveyApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;
        private readonly IMapper mapper;

        public UserController(UserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        [HttpGet("GetById")]
        public async Task<UserDto> GetUserById(int id)
        {
            return this.mapper.Map<UserDto>(await this.userService.GetById(id));
        }

        [HttpGet("GetAll")]
        public IEnumerable<UserDto> GetUsers()
        {
            return this.mapper.Map<List<UserDto>>(this.userService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserCreateDto userDto)
        {
            try
            {
                User newUser = this.mapper.Map<User>(userDto);

                newUser.CreatedDate = DateTime.Now;

                await this.userService.Add(newUser);

                return Ok();
            }
            catch (Exception ex)
            {
                //TODO : Exceptionları belirleyip özel kontroller ekle

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            try
            {
                await this.userService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                //TODO : Exceptionları belirleyip özel kontroller ekle

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserById(int id, [FromBody]UserCreateDto userDto)
        {
            try
            {
                User user = this.mapper.Map<User>(userDto);

                await this.userService.Update(id, user);

                return Ok();
            }
            catch (Exception ex)
            {
                //TODO : Exceptionları belirleyip özel kontroller ekle

                return BadRequest(ex.Message);
            }
        }
    }
}
