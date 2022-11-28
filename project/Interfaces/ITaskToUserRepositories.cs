using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface ITaskOfUser
    {
        Task<List<TaskToUser>> GetAllAsync();
        Task<TaskToUser> GetByIdAsync(int TaskUserId);
        Task<TaskToUser> AddAsync(int TaskUserId, int TaskId, int UserId, int FrequencyId, Task Task, Users Users, TaskFrequency TaskFrequency);
        Task<TaskToUser> UpdateAsync(TaskToUser taskOfUser);
        Task DeleteAsync(int TaskUserId);
    }
}
