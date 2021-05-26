using Accounting.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IRepositories
{
    public interface IUserRepository
    {
        DataTable GetAllByProcedure();
        User GetById(int id);
        User Login(string username, string password);
        int Insert(User user);
        int Update(User user);
        int Delete(int id);
    }
}
