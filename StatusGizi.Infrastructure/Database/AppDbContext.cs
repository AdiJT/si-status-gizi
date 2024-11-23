using Microsoft.EntityFrameworkCore;
using StatusGizi.Domain.Entities;

namespace StatusGizi.Infrastructure.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {   
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);


        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Balita> TblBalita { get; set; }
    public DbSet<Posyandu> TblPosyandu { get; set; }
    public DbSet<OrangTua> TblOrangTua { get; set; }
    public DbSet<DesaKelurahan> TblDesaKelurahan { get; set; }
    public DbSet<Pengecekan> TblPengecekan { get; set; }
    public DbSet<StandarBeratMenurutBBTB> TblStandarBeratMenurutBBTB { get; set; }
}
