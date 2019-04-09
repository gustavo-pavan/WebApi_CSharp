using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppRest.Models;

namespace WebAppRest.Context
{
    public class TypeUserContext : DbContext
    {
        public TypeUserContext(DbContextOptions<TypeUserContext> options) : base(options)
        {
        }

        protected TypeUserContext()
        {
        }
        public DbSet<TypeUser> TypeUsers { get; set; }
    }
}
