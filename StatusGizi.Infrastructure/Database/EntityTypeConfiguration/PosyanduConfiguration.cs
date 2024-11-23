using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

internal class PosyanduConfiguration : IEntityTypeConfiguration<Posyandu>
{
    public void Configure(EntityTypeBuilder<Posyandu> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(p => p.DesaKelurahan).WithMany(d => d.DaftarPosyandu);
        builder.HasMany(p => p.DaftarPengecekan).WithOne(p => p.Posyandu);
    }
}
