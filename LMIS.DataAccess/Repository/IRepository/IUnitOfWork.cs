using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IApplicationUserRepository applicationUser { get; }
        void save();
    }
}
