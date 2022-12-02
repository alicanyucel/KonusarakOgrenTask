using KonusarakOgren.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Application.Service
{
    public interface IUserService
    {
        Task CreateUser(RegisterDto registerDto);

    }
}
