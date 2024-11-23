using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database.EntityTypeConfiguration;

internal class StandarBeratMenurutBBTBConfiguration : IEntityTypeConfiguration<StandarBeratMenurutBBTB>
{
    public void Configure(EntityTypeBuilder<StandarBeratMenurutBBTB> builder)
    {
        builder.HasKey(s => s.Id);
    }
}
