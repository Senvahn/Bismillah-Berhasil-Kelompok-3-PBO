using System;
using Microsoft.EntityFrameworkCore;

namespace SuwarSuwirApp.Models
{
    // Factory sederhana untuk membuat DbContext per operasi
    public class M_DbContextFactory
    {
        public string ConnectionString { get; }

        public M_DbContextFactory(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public M_AppDbContext CreateDbContext()
        {
            return new M_AppDbContext(ConnectionString);
        }
    }
}
