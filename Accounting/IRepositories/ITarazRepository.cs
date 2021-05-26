using Accounting.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IRepositories
{
    public interface ITarazRepository
    {
        DataTable GetAllByProcedure();
        DataTable GetAllNameAccount();
        Taraz GetById(int id);
        int Insert(Taraz taraz);
        int Update(Taraz taraz);
        int Delete(int id);
    }
}
