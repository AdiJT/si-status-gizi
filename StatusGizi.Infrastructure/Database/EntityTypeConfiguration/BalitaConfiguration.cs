using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

public class BalitaConfiguration : IEntityTypeConfiguration<Balita>
{
    public void Configure(EntityTypeBuilder<Balita> builder)
    {
        builder.HasKey(b => b.NIK);

        builder.HasOne(b => b.OrangTua).WithMany(o => o.DaftarBalita);
        builder.HasMany(b => b.DaftarPengecekan).WithOne(p => p.Balita);
    }
}
