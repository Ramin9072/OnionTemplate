using Microsoft.EntityFrameworkCore;
using Onion.Domain.AtricleAgg;
using Onion.Infrastracture.EFCore.Mapping;

namespace Onion.Infrastracture.EFCore
{
    public  class OnionContext : DbContext
    {
        public DbSet<ArticleCategory> ArticleCategory { get; set; }
        public OnionContext(DbContextOptions<OnionContext> options) : base(options)
        {

        }
        // for mapping
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly); 
            base.OnModelCreating(modelBuilder);
        }
    }
}
