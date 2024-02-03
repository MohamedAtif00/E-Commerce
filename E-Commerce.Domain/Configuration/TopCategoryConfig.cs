using E_Commerce.Domain.Model.Category;
using E_Commerce.Domain.Model.Category.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Configuration
{
    internal class TopCategoryConfig : IEntityTypeConfiguration<TopCategory>
    {
        public void Configure(EntityTypeBuilder<TopCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasConversion(x => x.Value, x => TopCategoryId.Create(x));

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.CreationDate).IsRequired();

            builder.HasMany(x => x.Categories).WithOne(x => x._topCategory);

        }
    }
}
