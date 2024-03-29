﻿using Core.Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserServices
    {
        void Register(RegisterDTO user);
        UserDTO Login(LoginDTO user);
        List<User> GetAllUser();
        User GetUserByEmail(string email);
    }
}
