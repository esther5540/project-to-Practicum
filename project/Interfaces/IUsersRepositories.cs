using Project.Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Interfaces
{
    public interface IUsersRepositories
    {
        Task<List<Users>> GetAllAsync();
        Task<Users> GetByIdAsync(string tz);
        Task<Users> AddAsync(Users user);
        Task<Users> UpdateAsync(Users user);
        Task DeleteAsync(string tz);
    }
}
