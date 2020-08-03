using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoceNet.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<CART> CARTS { get { return context.CARTS; } }
        public IEnumerable<CATEGORY> CATEGORYES { get { return context.CATEGORYES; } }
        public IEnumerable<LOGIN> LOGINS { get { return context.LOGINS; } }
        public IEnumerable<PASSWORD> PASSWORDS { get { return context.PASSWORDS; } }
        public IEnumerable<USER> USERS { get { return context.USERS; } }
        public IEnumerable<MESSAGE> MESSAGES { get { return context.MESSAGES; } }

    }
}