using LMIS.DataAccess.Data;
using LMIS.DataAccess.Repository.IRepository;
using LMIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext _db;
        public IApplicationUserRepository User { get; private set; }

        public IApplicationUserRepository applicationUser { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            User = new UserRepository(db);            
        }

        public void save()
        {
            _db.SaveChanges();
        }
    }
}
