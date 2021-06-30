using EmptyAspCore.DAL;
using EmptyAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Services.Repository
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
