using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TC_Vehiculos.Models
{
    public partial class TCVehiculosContext : DbContext
    {
        public TCVehiculosContext()
        {
        }

        public TCVehiculosContext(DbContextOptions<TCVehiculosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vehiculos> Vehiculos { get; set; }

        public static void SetConnectionString(string connectionString)
        {
            if (ConnectionString == null)

            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new Exception();
            }
        }
        // this part will help you to open the connection
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        private static string ConnectionString { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress01;Database=TCVehiculos;Trusted_Connection=True;User ID=usr_covenants;Password=123456789;");
                //optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Marca)
                    .HasColumnName("MARCA")
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasColumnName("MODELO")
                    .IsUnicode(false);

                entity.Property(e => e.Patente)
                    .HasColumnName("PATENTE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Puertas).HasColumnName("PUERTAS");

                entity.Property(e => e.Titular)
                    .HasColumnName("TITULAR")
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
