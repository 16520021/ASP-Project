using AutoMapper;
using MyFirstProject.Data_Transfer_Objects.Role;
using MyFirstProject.Data_Transfer_Objects.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Models.Data_Transfer_Objects
{
    public class ObjectMapper: Profile
    {
        public ObjectMapper()
        {
            CreateMap<RoleDTO, Role>();
            CreateMap<UserDTO, User>();
        }
    }
}
