using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipApi.Models.Database
{
    public class MentorDbContext : DbContext
    {
        public MentorDbContext(DbContextOptions<MentorDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=172.20.90.230;Database=Compliance;User Id=sa; Password=leadway!los1;");
            }
        }
    }
}
