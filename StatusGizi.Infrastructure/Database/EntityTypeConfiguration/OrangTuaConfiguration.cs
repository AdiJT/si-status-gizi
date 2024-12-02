using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

internal class OrangTuaConfiguration : IEntityTypeConfiguration<OrangTua>
{
    public void Configure(EntityTypeBuilder<OrangTua> builder)
    {
        builder.HasKey(o => o.Id);

        builder.HasMany(o => o.DaftarBalita).WithOne(b => b.OrangTua);
        builder.HasOne(o => o.DesaKelurahan).WithMany(d => d.DaftarOrangTua);
        builder.HasOne(o => o.AppUser).WithOne(a => a.OrangTua).HasForeignKey<AppUser>(a => a.OrangTuaId);
    }
}
