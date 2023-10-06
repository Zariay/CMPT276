using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleProj.Models;

namespace SampleProj.Data
{
    public class SampleProjContext : DbContext
    {
        public SampleProjContext (DbContextOptions<SampleProjContext> options)
            : base(options)
        {
        }

        public DbSet<SampleProj.Models.Account> Account { get; set; } = default!;
    }
}
