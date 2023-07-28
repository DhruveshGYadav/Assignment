using Common.Models;
using Common.Services.Interfaces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly IUserSerice _userSerice;
        public UserAPIController(IUserSerice userSerice)
        {
            _userSerice = userSerice;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_userSerice.GetUsers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(User usermodel)
        {
            try
            {
                return Ok(_userSerice.AddUser(usermodel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{userId}")]
        public IActionResult GetExperienceByUser(int userId)
        {
            try
            {
                return Ok(_userSerice.GetExperiences(userId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddExperience")]
        public IActionResult AddExperience(UserExperience userExperience)
        {
            try
            {
                return Ok(_userSerice.AddUserExperience(userExperience));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(User data)
        {
            try
            {
                return Ok(_userSerice.UpdateUser(data));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("UpdateUserExperience")]
        public IActionResult UpdateUserExperience(UserExperience data)
        {
            try
            {
                return Ok(_userSerice.UpdateUserExperience(data));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int userId)
        {
            try
            {
                return Ok(_userSerice.DeleteUser(userId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("DeleteUserExperience")]
        public IActionResult DeleteUserExperience(int Id)
        {
            try
            {
                return Ok(_userSerice.DeleteUserExperience(Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
