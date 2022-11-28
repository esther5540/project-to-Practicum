using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface IManagersRepositories
    {
        Task<List<Managers>> GetAllAsync();
        Task<Managers> GetByIdAsync(int managerId);
        Task<Managers> AddAsync(int ManagerId, string ManagerName, string ManagerTelephone, string Mail, string Password);
        Task<Managers> UpdateAsync(Managers manager);
        Task DeleteAsync(int managerId);
    }
}
