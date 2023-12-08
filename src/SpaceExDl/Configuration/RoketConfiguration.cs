
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Space.Data;
public sealed class RoketConfiguration : IEntityTypeConfiguration<Roket>
{
    public void Configure(EntityTypeBuilder<Roket> builder)
    {
        builder
            .HasKey(p => p.Id)
            .HasName("id");
        builder
            .Property(p => p.Id)
            .IsRequired();
        
         builder
             .HasMany(r => r.employees)
             .WithOne(e => e.roket);
    }
}
