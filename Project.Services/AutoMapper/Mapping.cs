using AutoMapper;
using Project.Common.DTOs;
using Project.Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {

            CreateMap<Users, UsersDTO>().ReverseMap();
        }
    }
}
