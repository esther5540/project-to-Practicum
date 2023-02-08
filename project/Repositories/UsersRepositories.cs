using Microsoft.EntityFrameworkCore;
using Project.Interfaces;
using Project.Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Repositories
{
    public class UsersRepositories: IUsersRepositories
    {
        private readonly IContext _context;

        public UsersRepositories(IContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(string tz)
        {
            _context.AllUsers.Remove(await GetByIdAsync(tz));
            await _context.SaveChangesAsync();
        }

        public async Task<Users> AddAsync(Users user)
        {
            _context.AllUsers.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<Users>> GetAllAsync()
        {
            return await _context.AllUsers.ToListAsync();
        }

        public async Task<Users> GetByIdAsync(string tz)
        {
            Users? user = await _context.AllUsers.Where(i => i.Tz == tz).FirstOrDefaultAsync();
            return user;
        }

        public async Task<Users> UpdateAsync(Users user)
        {
            var newUser = _context.AllUsers.Update(user);
            await _context.SaveChangesAsync();
            return newUser.Entity;
        }
    }
}

