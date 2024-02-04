using E_Commerce.Domain.Model.Product.ValueObject;
using E_Commerce.Domain.Model.SubCategory.Entity;
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
    internal class SubCategoryProductConfig : IEntityTypeConfiguration<SubCategoryProduct>
    {
        public void Configure(EntityTypeBuilder<SubCategoryProduct> builder)
        {
            builder.HasKey(x => new { x.ProductId ,x.SubCategoryId});
            builder.Property(x => x.Id)
                .HasConversion(
                x => new { ProductId = x.Item1.value, SubCategoryId = x.Item2.value }, 
                value =>new (ProductId.Create(value.ProductId), SubCategoryId.Create(value.SubCategoryId))
                );

            builder.Property(x => x._name).IsRequired();


        }
    }
}
