using Project.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Interfaces
{
    public interface IUsersServices
    {
        Task<List<UsersDTO>> GetAllAsync();
        Task<UsersDTO> GetByIdAsync(string tz);
        Task<UsersDTO> AddAsync(UsersDTO UserDTO);
        Task<UsersDTO> UpdateAsync(UsersDTO UserDTO);
        Task DeleteAsync(string tz);
    }
}
