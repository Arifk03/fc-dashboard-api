using fc_dashboard_api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fc_dashboard_api.Utility
{
    public class FC_db_Context : DbContext
    {
        public FC_db_Context(DbContextOptions<FC_db_Context> options): base(options)
        {

        }
        public DbSet<State_Master> state_Masters { get; set; }
        public DbSet<District_Master> district_Masters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District_Master>().ToTable("District_Master", schema: "dbo");
            modelBuilder.Entity<State_Master>().ToTable("State_Master", schema: "dbo");

            base.OnModelCreating(modelBuilder);
        }
    }
}
//