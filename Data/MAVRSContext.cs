using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MAVRS.Models;

namespace MAVRS.Data
{
    public class MAVRSContext : DbContext
    {
        public MAVRSContext (DbContextOptions<MAVRSContext> options)
            : base(options)
        {
        }

        public DbSet<MAVRS.Models.Mothers> Mothers { get; set; }

        public DbSet<MAVRS.Models.Mother_status> Mother_status { get; set; }

        public DbSet<MAVRS.Models.Nextvisit> Nextvisit { get; set; }

        public DbSet<MAVRS.Models.Admin> Admin { get; set; }
    }
}
