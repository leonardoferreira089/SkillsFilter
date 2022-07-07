using Microsoft.EntityFrameworkCore;
using SkillsFilter.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsFilter.Infrastructure.Persistence
{
    public class SkillsFilterDbContext : DbContext
    {
        public SkillsFilterDbContext(DbContextOptions<SkillsFilterDbContext> options) : base(options)
        {

        }

        public DbSet<Skill> MyProperty { get; set; }
    }
}
