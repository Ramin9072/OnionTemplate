using Microsoft.EntityFrameworkCore;
using Onion.Domain.AtricleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Infrastracture.EFCore
{
    public  class OnionContext : DbContext
    {
        public DbSet<ArticleCategory> ArticleCategory { get; set; };
        public OnionContext(DbContextOptions<OnionContext> options) : base(options)
        {

        }
        // for mapping
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleCategory).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly); 
            base.OnModelCreating(modelBuilder);
        }
    }
}
