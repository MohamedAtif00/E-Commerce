using E_Commerce.Domain.Model.SubCategory;
using E_Commerce.Domain.Model.SubCategory.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Configuration.SubCategoryConfiguration
{
    internal class SubCategoryConfig : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasConversion(x => x.value, value => SubCategoryId.Create(value));

            builder.Property(x => x._name).IsRequired();
            builder.Property(x => x._description).IsRequired();

            builder.HasMany(x => x._childsSubCategories).WithOne(x => x._parentSubCategory);
        }
    }
}
