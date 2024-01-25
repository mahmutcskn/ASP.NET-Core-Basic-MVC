using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDApp.Model;

namespace CRUDApp.Data
{
    public class CRUDAppContext : DbContext
    {
        public CRUDAppContext (DbContextOptions<CRUDAppContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDApp.Model.User> User { get; set; } = default!;
    }
}
