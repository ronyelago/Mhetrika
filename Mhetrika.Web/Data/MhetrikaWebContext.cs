using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mhetrika.core.Entities;

namespace Mhetrika.Web.Models
{
    public class MhetrikaWebContext : DbContext
    {
        public MhetrikaWebContext (DbContextOptions<MhetrikaWebContext> options)
            : base(options)
        {
        }

        public DbSet<mhetrika.core.Entities.Laboratory> Laboratory { get; set; }
    }
}
