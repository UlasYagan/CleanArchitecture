using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sum.Domain.Entities;

namespace Sum.Persistence.Configurations;

public class CategoryDetailConfiguration : IEntityTypeConfiguration<CategoryDetail>
{
    public void Configure(EntityTypeBuilder<CategoryDetail> builder)
    {
        builder.Property(t => t.Id).IsRequired(true).UseSequence();

        builder.Property(t => t.Title).IsRequired(true).HasMaxLength(256);
        builder.Property(t => t.Description).IsRequired(false).HasMaxLength(256);
        builder.Property(t => t.CategoryId).IsRequired(true);

        builder.Property(t => t.CreatedBy).IsRequired(false).HasMaxLength(50);
        builder.Property(t => t.Created).IsRequired(true);
        builder.Property(t => t.UpdatedBy).IsRequired(false).HasMaxLength(50);
        builder.Property(t => t.Updated).IsRequired(false);
        builder.Property(t => t.IsActive).IsRequired(true).HasDefaultValue(true);
        builder.Property(t => t.IsDeleted).IsRequired(true).HasDefaultValue(false);
    }
}
