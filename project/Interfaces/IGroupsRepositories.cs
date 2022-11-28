using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface IGroupsRepositories
    {
        Task<List<Groups>> GetAllAsync();
        Task<Groups> GetByIdAsync(int groupID);
        Task<Groups> AddAsync(int GroupID, string GroupName, int ManagerID, Managers Manager);
        Task<Groups> UpdateAsync(Groups groups);
        Task DeleteAsync(int groupID);
    }
}
