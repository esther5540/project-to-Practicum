using AutoMapper;
using Project.Common.DTOs;
using Project.Interfaces;
using Project.Repository.Entites;
using Project.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Services
{
    public class UsersServices: IUsersServices
    {
        private readonly IUsersRepositories _UsersRepository;
        private readonly IMapper _mapper;
        public UsersServices(IUsersRepositories UsersRepositories, IMapper mapper)
        {
            _UsersRepository = UsersRepositories;
            _mapper = mapper;
        }
        public async Task<UsersDTO> AddAsync(UsersDTO UsersDTO)
        {
            var x = _mapper.Map<Users>(UsersDTO);
            Users a = await _UsersRepository.AddAsync(x);
            return _mapper.Map<UsersDTO>(a);

        }

        public async Task DeleteAsync(string tz)
        {
            await _UsersRepository.DeleteAsync(tz);
        }

        public async Task<List<UsersDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UsersDTO>>(await _UsersRepository.GetAllAsync());
        }

        public async Task<UsersDTO> GetByIdAsync(string tz)
        {
            return _mapper.Map<UsersDTO>(await _UsersRepository.GetByIdAsync(tz));
        }

        public async Task<UsersDTO> UpdateAsync(UsersDTO UserDTO)
        {
            return _mapper.Map<UsersDTO>(await _UsersRepository.UpdateAsync(_mapper.Map<Users>(UserDTO)));
        }
    }
}
