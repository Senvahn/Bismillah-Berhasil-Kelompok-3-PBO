using System;
using System.Linq;
using SuwarSuwirApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SuwarSuwirApp.Controllers
{
    public class C_UserController : C_BaseController
    {
        public M_User CurrentUser { get; private set; }

        public C_UserController(M_DbContextFactory factory) : base(factory) { }

        // Login synchronous (dipanggil dari UI thread handler)
        public OperationResult<M_User> Login(string username, string password)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var user = db.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
                if (user == null)
                    return OperationResult<M_User>.Fail("Username atau password salah.");
                CurrentUser = user;
                return OperationResult<M_User>.SuccessResult(user, "Login berhasil.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_User>.Fail($"Gagal login: {ex.Message}");
            }
        }

        public OperationResult<bool> Logout()
        {
            try
            {
                CurrentUser = null;
                return new OperationResult<bool> { Success = true, Message = "Logout berhasil.", Data = true };
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.Fail($"Gagal logout: {ex.Message}");
            }
        }

        public OperationResult<M_User> RegisterCustomer(M_User userData)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var exists = db.Users.Any(u => u.Username == userData.Username);
                if (exists)
                    return OperationResult<M_User>.Fail("Username sudah digunakan.");

                userData.Role = "customer";
                userData.TanggalDaftar = DateTime.UtcNow;
                db.Users.Add(userData);
                db.SaveChanges();
                return OperationResult<M_User>.SuccessResult(userData, "Registrasi berhasil.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_User>.Fail($"Gagal registrasi: {ex.Message}");
            }
        }

        public OperationResult<M_User> GetProfile(int idUser)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var user = db.Users.SingleOrDefault(u => u.IdUser == idUser);
                if (user == null) return OperationResult<M_User>.Fail("User tidak ditemukan.");
                return OperationResult<M_User>.SuccessResult(user);
            }
            catch (Exception ex)
            {
                return OperationResult<M_User>.Fail($"Gagal ambil profil: {ex.Message}");
            }
        }

        public OperationResult<M_User> UpdateProfile(M_User userData)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var user = db.Users.SingleOrDefault(u => u.IdUser == userData.IdUser);
                if (user == null) return OperationResult<M_User>.Fail("User tidak ditemukan.");

                user.NamaLengkap = userData.NamaLengkap;
                user.Email = userData.Email;
                user.NoHp = userData.NoHp;
                user.Alamat = userData.Alamat;
                // password boleh diupdate
                if (!string.IsNullOrEmpty(userData.Password))
                    user.Password = userData.Password;

                db.SaveChanges();
                return OperationResult<M_User>.SuccessResult(user, "Profil diperbarui.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_User>.Fail($"Gagal update profil: {ex.Message}");
            }
        }

        public OperationResult<List<M_User>> GetAllCustomers()
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var list = db.Users.Where(u => u.Role == "customer").ToList();
                return OperationResult<List<M_User>>.SuccessResult(list);
            }
            catch (Exception ex)
            {
                return OperationResult<List<M_User>>.Fail($"Gagal ambil daftar customer: {ex.Message}");
            }
        }
    }
}
