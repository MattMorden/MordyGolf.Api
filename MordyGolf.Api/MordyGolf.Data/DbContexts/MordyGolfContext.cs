using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordyGolf.Data.DbContexts
{
    public class MordyGolfContext : DbContext
    {
        public MordyGolfContext(DbContextOptions<MordyGolfContext> options) 
            : base(options) 
        { }

        // public DbSet<x> PropName { get; set; }
    }
}
