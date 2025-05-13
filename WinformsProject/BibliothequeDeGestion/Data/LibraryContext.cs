using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static EmailService;

public class LibraryContext : DbContext
{

    public LibraryContext() { }

    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Loan> Loans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            // Configuration par défaut pour les outils EF Core
            options.UseSqlite("Data Source=library.db");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasKey(b => b.Id);
        modelBuilder.Entity<Member>()
            .HasKey(m => m.Id);
        modelBuilder.Entity<Loan>()
            .HasKey(l => l.Id);
        modelBuilder.Entity<Loan>()
            .HasOne(l => l.Book)
            .WithMany(l => l)
            .HasForeignKey(l => l.BookId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Loan>()
            .HasOne(l => l.Member)
            .WithMany()
            .HasForeignKey(l => l.MemberId).OnDelete(DeleteBehavior.Restrict);
    }
}