using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface IUsersRepositories
    {
       Task<List<Users>> GetAllAsync();
        Task<List<Users>> GetByIdAsync(int UserId);
        Task<Users> AddAsync(int UserId ,string UserName,string Mail ,int Telephone, string Password);   
        Task<Users> UpdateAsync(Users user);
        Task DeleteAsync(int UserId);


    }
}
