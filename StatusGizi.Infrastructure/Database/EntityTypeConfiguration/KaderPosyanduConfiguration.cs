using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

internal class KaderPosyanduConfiguration : IEntityTypeConfiguration<KaderPosyandu>
{
    public void Configure(EntityTypeBuilder<KaderPosyandu> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Posyandu).WithMany(p => p.DaftarKaderPosyandu);
        builder.HasOne(x => x.AppUser).WithOne(a => a.KaderPosyandu).HasForeignKey<AppUser>(a => a.KaderPosyanduId);
    }
}
