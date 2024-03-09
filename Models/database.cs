using Microsoft.EntityFrameworkCore;
using Prenota.Models;

public class Database : DbContext
{
     private readonly DbContextOptions? _options;
     public Database() { }

     protected override void
             OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=database.db");

     public DbSet<Utente> Utenti { get; set; }
     public string? Nome {get;set;}
}
