using Microsoft.EntityFrameworkCore;

namespace GestaoDeSoftwaresBcv.Data;

public class SoftwareDbContexto: DbContext
{
    public SoftwareDbContexto(DbContextOptions<SoftwareDbContexto> options) : base(options) { }

    public DbSet<Models.Software> Software { get; set; }
}