using Microsoft.EntityFrameworkCore;

namespace IncidentApi.Models;

public class IncidentContext : DbContext
{
    public IncidentContext(DbContextOptions<IncidentContext> options)
        : base(options)
    {
    }

    public DbSet<Incident> Incidents { get; set; } = null!;
}