using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

internal class PengecekanConfiguration : IEntityTypeConfiguration<Pengecekan>
{
    public void Configure(EntityTypeBuilder<Pengecekan> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(p => p.Balita).WithMany(b => b.DaftarPengecekan);
        builder.HasOne(p => p.Posyandu).WithMany(p => p.DaftarPengecekan);
    }
}
