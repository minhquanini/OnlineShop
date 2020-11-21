using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCategory");
            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategory)
                .HasForeignKey(pc => pc.ProductId);
            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategory)
                .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
