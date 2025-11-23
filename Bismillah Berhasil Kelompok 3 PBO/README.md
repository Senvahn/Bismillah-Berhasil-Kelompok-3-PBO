# SuwarSuwirApp - README

Proyek: Sistem Manajemen Produksi dan Transaksi Suwar-Suwir (WinForms .NET 8)

## Persyaratan
- Visual Studio 2022 (pastikan support .NET 8 dan Windows Forms)
- PostgreSQL + PgAdmin (sudah tersedia)
- NuGet packages:
  - Npgsql.EntityFrameworkCore.PostgreSQL
  - Microsoft.EntityFrameworkCore.Tools

## Langkah setup singkat
1. Buka Visual Studio 2022.
2. Buat folder project baru bernama `SuwarSuwirApp` atau buka project existing dan paste file sesuai struktur.
3. Tambahkan file-file `.cs` dan `.Designer.cs` sesuai struktur yang diberikan (Models/, Controllers/, Views/, Program.cs, README.md, schema_and_seed.sql).
4. Di Visual Studio: Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution:
   - Install `Npgsql.EntityFrameworkCore.PostgreSQL`
   - Install `Microsoft.EntityFrameworkCore.Tools`
5. Pastikan connection string pada `Program.cs` sesuai:
   `Host=localhost;Port=5432;Database=suwarsuwirfixplis;Username=postgres;Password=postgresql;`
6. Buat database `suwarsuwirfixplis` di PgAdmin:
   - Login PgAdmin -> Create -> Database -> Name: `suwarsuwirfixplis`
7. Import/Run file `schema_and_seed.sql` di Query Tool PgAdmin untuk membuat tabel dan seed data.
8. Build project di Visual Studio. Jika ada referensi namespace, pastikan `namespace SuwarSuwirApp` disesuaikan.
9. Jalankan aplikasi. Form Login muncul.
   - Login Admin: username `Adminsigma`, password `Sigma123`
   - Customer contoh: username `budi01`, password `password123` (sudah di-seed)
10. Uji fitur:
    - Login admin -> Kelola Produk -> Tambah/Edit/Hapus/Atur Stok
    - Login customer -> Lihat Produk -> Pilih produk -> Tambah ke keranjang -> Bayar

## Catatan teknis
- Semua operasi DB memakai EF Core.
- Penanganan stok menggunakan SELECT ... FOR UPDATE untuk menghindari race condition.
- Password disimpan plain-text untuk tujuan pembelajaran/testing.
- Jangan gunakan default password di produksi.

## Skenario uji manual (singkat)
1. Pembelian berhasil:
   - Login sebagai customer (`budi01`)
   - Pilih `Suwar-Suwir Original` (stok awal 50)
   - Beli 1, pilih metode `Transfer Bank`, bayar.
   - Hasil: status transaksi `Lunas`, stok produk berkurang 1.

2. Pembelian gagal (stok kurang):
   - Manual ubah stok produk menjadi 0 di PgAdmin atau gunakan fitur Admin -> Atur Stok.
   - Customer mencoba beli 1 produk yang stoknya 0.
   - Saat Bayar terjadi pengecekan stok, proses rollback, muncul pesan "Stok ... tidak cukup. Pembayaran dibatalkan."

