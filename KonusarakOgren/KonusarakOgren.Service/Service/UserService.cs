using KonusarakOgren.Application.Service;
using KonusarakOgren.Entities;
using KonusarakOgren.Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Service.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _usermanager;
        public UserService(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }
        //
        //
        public async Task CreateOrder(RegisterDto registerDto)
        {
            AppUser user = new AppUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = registerDto.UserName,
                Email = registerDto.Email

            };
            await _usermanager.CreateAsync(user,registerDto.Password);
        }
   
        public async Task CreateUser(RegisterDto registerDto)
        {
            AppUser user = new AppUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = registerDto.UserName,
                Email=registerDto.Email
            };
            await _usermanager.CreateAsync(user,registerDto.Password);
        }
    }
}
