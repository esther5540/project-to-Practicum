using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface ITaskRepositories
    {
        Task<List<Tasks>> GetAllAsync();
        Task<Tasks> AddAsync( int TaskId,string TaskName,int Difficulty,int GroupId,Groups Groups);
        Task<Tasks> GetById(int TaskId);
        Task<Tasks> UpdateAsync(Tasks task);
        Task DeleteAsync(int TaskId);

    }
}
