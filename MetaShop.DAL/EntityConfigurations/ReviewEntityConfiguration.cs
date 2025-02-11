﻿using MetaShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetaShop.DAL.EntityConfigurations
{
    internal class ReviewEntityConfiguration : BaseEntityTypeConfiguration<Review>
    {
        public override void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Review");

            builder.HasOne(x => x.Customer).WithMany(x => x.Reviews).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Product).WithMany(x => x.Reviews).HasForeignKey(x => x.ProductId);
        }
    }
}
