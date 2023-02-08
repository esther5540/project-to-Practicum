using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Common.DTOs;
using Project.Services.Services;

namespace Project.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly TaskToUserServices _taskToUserServices;
        public RolesController(TaskToUserServices taskToUserServices)
        {
            taskToUserServices = _taskToUserServices;
        }
        [HttpGet]
        public async Task<IEnumerable<TaskToUserDTO>> Get()
        {
            return await _taskToUserServices.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<TaskToUserDTO> Get(int id)
        {
            return await _taskToUserServices.GetByIdAsync(id);
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
           await _taskToUserServices.DeleteAsync(id);
        }

    }
}
