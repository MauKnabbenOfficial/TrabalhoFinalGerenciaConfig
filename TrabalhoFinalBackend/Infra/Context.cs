using Microsoft.EntityFrameworkCore;
using TrabalhoFinalBackend.Models;

namespace TrabalhoFinalBackend.Infra;

public class Context : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=DESKTOP-CETQIMA; Database=TrabalhoFinalGerenciaConfig; Integrated Security=True; TrustServerCertificate=True;");
}
