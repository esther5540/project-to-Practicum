using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Project.API.Models;
using Project.Common.DTOs;
using Project.Services.Interfaces;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUsersServices _UsersServices;
        public UsersController(IUsersServices UsersServices)
        {
            _UsersServices = UsersServices;
        }
        
        [HttpGet]
        public async Task<IEnumerable<UsersDTO>> Get()
        {
            return await _UsersServices.GetAllAsync();
        }
        
        [HttpGet("{tz}")]
        public async Task<UsersDTO> Get(string tz)
        {
            return await _UsersServices.GetByIdAsync(tz);
        }
        [HttpPost]
        public async Task<UsersDTO> Post([FromBody] UserModel UserModel)//add
        {
            UsersDTO UsersDTO = new UsersDTO()
            {
                FirstName = UserModel.FirstName,
                SecondName = UserModel.SecondName,
                Tz = UserModel.Tz,
                Birthday= UserModel.Birthday,
                Gender = UserModel.Gender,
                healthFund = UserModel.healthFund,
                Children = UserModel.Children,
                FatherTz = UserModel.FatherTz,
                MotherTz= UserModel.MotherTz

            };
            return await _UsersServices.AddAsync(UsersDTO);
        }
        [HttpPut("{tz}")]
        public async Task<UsersDTO> Put(string tz, [FromBody] UserModel UserModel)//update
        {
            UsersDTO UsersDTO = new UsersDTO()
            {
                FirstName = UserModel.FirstName,
                SecondName = UserModel.SecondName,
                Tz = tz,
                Birthday= UserModel.Birthday,
                Gender = UserModel.Gender,
                healthFund = UserModel.healthFund,
                Children = UserModel.Children,
                FatherTz = UserModel.FatherTz,
                MotherTz= UserModel.MotherTz,
                UserId = UserModel.UserId

            };
            return await _UsersServices.UpdateAsync(UsersDTO);
        }
        [HttpDelete("{tz}")]
        public async Task Delete(string tz)
        {
            await _UsersServices.DeleteAsync(tz);
        }
    }

}
