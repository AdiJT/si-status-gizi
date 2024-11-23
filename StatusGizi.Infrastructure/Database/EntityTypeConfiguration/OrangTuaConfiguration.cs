using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

internal class OrangTuaConfiguration : IEntityTypeConfiguration<OrangTua>
{
    public void Configure(EntityTypeBuilder<OrangTua> builder)
    {
        builder.HasKey(o => o.NIK);

        builder.HasMany(o => o.DaftarBalita).WithOne(b => b.OrangTua);
        builder.HasOne(o => o.DesaKelurahan).WithMany(d => d.DaftarOrangTua);
    }
}
