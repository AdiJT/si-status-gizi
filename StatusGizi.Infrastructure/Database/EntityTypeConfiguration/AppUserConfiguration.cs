using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.OrangTua).WithOne(o => o.AppUser).HasForeignKey<AppUser>(x => x.OrangTuaId);
        builder.HasOne(x => x.KaderPosyandu).WithOne(o => o.AppUser).HasForeignKey<AppUser>(x => x.KaderPosyanduId);
    }
}
