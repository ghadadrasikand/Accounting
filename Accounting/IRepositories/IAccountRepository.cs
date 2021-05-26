using Accounting.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IRepositories
{
    public interface IAccountRepository
    {
        DataTable GetAllByProcedure();
        Account GetById(int id);
        int Insert(Account account);
        int Update(Account account);
    }
}
