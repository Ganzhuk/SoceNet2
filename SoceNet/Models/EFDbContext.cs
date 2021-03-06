﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SoceNet.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<CART> CARTS { get; set; }
        public DbSet<CATEGORY> CATEGORYES { get; set; }
        public DbSet<LOGIN> LOGINS { get; set; }
        public DbSet<MESSAGE> MESSAGES { get; set; }
        public DbSet<PASSWORD> PASSWORDS { get; set; }
        public DbSet<USER> USERS { get; set; }

    }
}