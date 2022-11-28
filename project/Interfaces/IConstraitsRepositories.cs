using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface IConstraitsRepositories
    {
        Task<List<Constraits>> GetAllAsync();
        Task<List<Constraits>> GetByIdAsync(int constraitId);
        Task<Constraits> AddAsync(int ConstraitId, int UserId, Users User, string Constrait, eDays DayOfWeek, TimeOnly TimeStart, TimeOnly TimeEnd, bool IsPermanent);
        Task<Constraits> UpdateAsync(Constraits constraits);
        Task DeleteAsync(int constraitId);
    }
}
