using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace SuwarSuwirApp.Models
{
    // DbContext untuk EF Core
    public class M_AppDbContext : DbContext
    {
        public string ConnectionString { get; }

        public DbSet<M_User> Users { get; set; }
        public DbSet<M_Produk> Produks { get; set; }
        public DbSet<M_Transaksi> Transaksis { get; set; }
        public DbSet<M_DetailTransaksi> DetailTransaksis { get; set; }

        public M_AppDbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        // Untuk EF tools
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapping nama tabel dan kolom
            modelBuilder.Entity<M_User>().ToTable("users").HasKey(u => u.IdUser);
            modelBuilder.Entity<M_Produk>().ToTable("produks").HasKey(p => p.IdProduk);
            modelBuilder.Entity<M_Transaksi>().ToTable("transaksis").HasKey(t => t.IdTransaksi);
            modelBuilder.Entity<M_DetailTransaksi>().ToTable("detailtransaksis").HasKey(d => d.IdDetail);

            // Atur kolom PK names sesuai permintaan
            modelBuilder.Entity<M_User>().Property(u => u.IdUser).HasColumnName("id_user");
            modelBuilder.Entity<M_Produk>().Property(p => p.IdProduk).HasColumnName("id_produk");
            modelBuilder.Entity<M_Transaksi>().Property(t => t.IdTransaksi).HasColumnName("id_transaksi");
            modelBuilder.Entity<M_DetailTransaksi>().Property(d => d.IdDetail).HasColumnName("id_detail");

            // Mapping kolom lain: otomatis EF akan memakai nama properti. Jika perlu override, lakukan di sini.
            base.OnModelCreating(modelBuilder);
        }

        // helper untuk SaveChanges async
        public async Task<int> SaveChangesAsyncSafe()
        {
            return await base.SaveChangesAsync();
        }

        // Helper untuk membuat instance baru (tidak static factory di sini)
        public static M_AppDbContext Create(string connectionString)
        {
            return new M_AppDbContext(connectionString);
        }

        // Getter DbSet methods sesuai spesifikasi
        public DbSet<M_User> GetDbSetUser() => Users;
        public DbSet<M_Produk> GetDbSetProduk() => Produks;
        public DbSet<M_Transaksi> GetDbSetTransaksi() => Transaksis;
        public DbSet<M_DetailTransaksi> GetDbSetDetailTransaksi() => DetailTransaksis;
    }
}
