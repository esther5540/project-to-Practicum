using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface IPerformanceRepositories
    {
        Task<List<Performance>> GetAllAsync();
        Task<Performance> GetByIdAsync(int performanceId);
        Task<Performance> AddAsync(int PerformanceId, int TaskUserID, TaskToUser TaskOfUser, DateOnly PerformanceDate, TimeOnly PerformanceTime, int Mark, string Note);
        Task<Performance> UpdateAsync(Performance performance);
        Task DeleteAsync(int performanceId);
    }
}
