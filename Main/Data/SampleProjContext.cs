using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calculator.Models;

namespace SampleProj.Data
{
    public class SampleProjContext : DbContext
    {
        public SampleProjContext (DbContextOptions<SampleProjContext> options)
            : base(options)
        {
        }

        public DbSet<Calculator.Models.Account> Account { get; set; } = default!;
    }
}
