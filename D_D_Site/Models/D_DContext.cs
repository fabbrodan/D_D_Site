using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace D_D_Site.Models
{
    public partial class D_DContext : DbContext
    {
        public D_DContext()
        {
        }

        public D_DContext(DbContextOptions<D_DContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Characters> Characters { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=192.168.0.101;port=3306;user=root;password=Olisykes_8426!;database=D_D", x => x.ServerVersion("5.7.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Characters>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CharacterName)
                    .HasColumnName("Character_Name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.SpeciesId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PRIMARY");

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.Fys)
                    .HasColumnName("FYS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Intl)
                    .HasColumnName("INTL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kar)
                    .HasColumnName("KAR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Psy)
                    .HasColumnName("PSY")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleName)
                    .HasColumnName("Role_Name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Smi)
                    .HasColumnName("SMI")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sty)
                    .HasColumnName("STY")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.Property(e => e.SpeciesId).HasColumnType("int(11)");

                entity.Property(e => e.Fys)
                    .HasColumnName("FYS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Intl)
                    .HasColumnName("INTL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kar)
                    .HasColumnName("KAR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Psy)
                    .HasColumnName("PSY")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Smi)
                    .HasColumnName("SMI")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecieName)
                    .HasColumnName("Specie_Name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Sto)
                    .HasColumnName("STO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sty)
                    .HasColumnName("STY")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(8000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
