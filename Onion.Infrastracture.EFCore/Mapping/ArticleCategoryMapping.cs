using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.AtricleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Infrastracture.EFCore.Mapping
{
    public class ArticleCategoryMapping : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(255);
            builder.Property(p => p.Id).IsRequired(true);
            builder.Property(p => p.DateTime);
            builder.Property(p => p.IsActive);
            //
            builder.Property(p=>p.Name).IsUnicode(false);
            builder.Property(p => p.Name).HasComment("COMMEND IN DATABASE");
            builder.Property(p => p.Name).HasColumnOrder(1);
            builder.HasKey(p => p.Id).HasName("KEY_ID"); 

        }
    }
}
