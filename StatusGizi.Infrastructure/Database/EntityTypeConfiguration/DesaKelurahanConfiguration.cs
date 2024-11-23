using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

internal class DesaKelurahanConfiguration : IEntityTypeConfiguration<DesaKelurahan>
{
    public void Configure(EntityTypeBuilder<DesaKelurahan> builder)
    {
        builder.HasKey(d => d.Id);

        builder.HasMany(d => d.DaftarOrangTua).WithOne(o => o.DesaKelurahan);
        builder.HasMany(d => d.DaftarPosyandu).WithOne(p => p.DesaKelurahan);
    }
}
