using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GetSingleProduct
{
    public partial class HubContext : DbContext
    {
        public HubContext()
        {
        }

        public HubContext(DbContextOptions<HubContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TenantSystemApiKey> TenantSystemApiKeys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=freightreplica.cz2wjeilzdyj.us-east-1.rds.amazonaws.com;database=platform_hub_v2;uid=joaocarniel;pwd=\"5=XjkZV!f7mgEXAX\"", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.33-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<TenantSystemApiKey>(entity =>
            {
                entity.HasKey(e => e.IdtTenantSystemApiKey)
                    .HasName("PRIMARY");

                entity.ToTable("tenantSystemApiKey");

                entity.HasIndex(e => new { e.IdTenant, e.Store, e.IdApiKey }, "tenant");

                entity.Property(e => e.IdtTenantSystemApiKey)
                    .HasColumnType("int(11)")
                    .HasColumnName("idtTenantSystemApiKey");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.IdApiKey)
                    .HasMaxLength(100)
                    .HasColumnName("idApiKey");

                entity.Property(e => e.IdSystem)
                    .HasMaxLength(100)
                    .HasColumnName("idSystem");

                entity.Property(e => e.IdTenant)
                    .HasColumnType("int(11)")
                    .HasColumnName("idTenant");

                entity.Property(e => e.IdTenantSystem)
                    .HasColumnType("int(11)")
                    .HasColumnName("idTenantSystem");

                entity.Property(e => e.Store)
                    .HasColumnType("int(11)")
                    .HasColumnName("store")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
