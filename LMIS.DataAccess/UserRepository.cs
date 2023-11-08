using LMIS.DataAccess.Data;
using LMIS.DataAccess.Repository;
using LMIS.DataAccess.Repository.IRepository;
using LMIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.DataAccess
{

    public class UserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _context = db;
        }

        public void Update(ApplicationUser user)
        {
            _context.applicationUsers.Update(user);
        }
    }
}
