using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.General.Models;

namespace Database.Repository.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
    }
}
