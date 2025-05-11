using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Data;

public class AppDbContext : DbContext
{
    // DbSet properties for each entity
    public DbSet<CustomerRequest> CustomerRequests { get; set; }
    public DbSet<DeveloperReport> DeveloperReports { get; set; }
    public DbSet<CostReport> CostReports { get; set; }
    public DbSet<OrderReport> OrderReports { get; set; }
    public DbSet<PaymentConfirmation> PaymentConfirmations { get; set; }

    // Configure the database provider and connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MyBusinessAppDB;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // CustomerRequest -> DeveloperReport (1:N)
        modelBuilder.Entity<DeveloperReport>()
            .HasOne(d => d.CustomerRequest)
            .WithMany(c => c.DeveloperReports)
            .HasForeignKey(d => d.RequestID_FK)
            .OnDelete(DeleteBehavior.Cascade);

        // DeveloperReport -> CostReport (1:1)
        modelBuilder.Entity<CostReport>()
            .HasOne(c => c.DeveloperReport)
            .WithOne(d => d.CostReport)
            .HasForeignKey<CostReport>(c => c.DevRep_ID_FK)
            .OnDelete(DeleteBehavior.Cascade);

        // OrderReport -> CostReport (1:N)
        modelBuilder.Entity<CostReport>()
            .HasOne(c => c.OrderReport)
            .WithMany(o => o.CostReports)
            .HasForeignKey(c => c.OrderRep_ID)
            .OnDelete(DeleteBehavior.SetNull);

        // PaymentConfirmation -> OrderReport (1:1)
        modelBuilder.Entity<OrderReport>()
            .HasOne(o => o.PaymentConfirmation)
            .WithOne()
            .HasForeignKey<OrderReport>(o => o.Confirmation_ID)
            .OnDelete(DeleteBehavior.Cascade);

        // Additional optional: Configure table names explicitly
        modelBuilder.Entity<CustomerRequest>().ToTable("CustomerRequest");
        modelBuilder.Entity<DeveloperReport>().ToTable("DeveloperReport");
        modelBuilder.Entity<CostReport>().ToTable("CostReport");
        modelBuilder.Entity<OrderReport>().ToTable("OrderReport");
        modelBuilder.Entity<PaymentConfirmation>().ToTable("PaymentConfirmation");
    }
}
