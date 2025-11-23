using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuwarSuwirApp.Controllers;

namespace SuwarSuwirApp.Models
{
    [Table("users")]
    public class M_User
    {
        [Key]
        [Column("id_user")]
        public int IdUser { get; set; }

        [Column("nama_lengkap")]
        public string NamaLengkap { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; } // plain-text untuk testing sesuai permintaan

        [Column("email")]
        public string Email { get; set; }

        [Column("no_hp")]
        public string NoHp { get; set; }

        [Column("alamat")]
        public string Alamat { get; set; }

        [Column("role")]
        public string Role { get; set; } // admin or customer

        [Column("tanggal_daftar")]
        public DateTime TanggalDaftar { get; set; }

        // Methods - logic akses DB ada di controller, namun helper statis boleh ada:
        public static OperationResult<M_User> ValidateLogin(string username, string password, M_DbContextFactory factory)
        {
            try
            {
                using var db = factory.CreateDbContext();
                var user = db.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
                if (user == null)
                    return OperationResult<M_User>.Fail("Username atau password salah.");
                return OperationResult<M_User>.SuccessResult(user);
            }
            catch (Exception ex)
            {
                return OperationResult<M_User>.Fail($"Gagal validasi login: {ex.Message}");
            }
        }
    }
}
