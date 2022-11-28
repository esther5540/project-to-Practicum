using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface IUserToGroupRepositories
    {
        Task<List<UserToGroup>> GetAllAsync();
        Task<UserToGroup> AddAsync(int UserToGroupID,int UserID,Users User,int GroupID,Groups Group,DateOnly JoinDate,DateOnly LeftDate);
        Task<UserToGroup> GetByIdAsync(int userToGroupID);
        Task<UserToGroup> UpdateAsync(UserToGroup userToGroup);
        Task DeleteAsync(int userToGroupID);
    }
}
