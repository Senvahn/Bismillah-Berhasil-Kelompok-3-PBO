-- schema_and_seed.sql
-- Skrip pembuatan tabel dan seed data untuk database "suwarsuwirfixplis"
-- Pastikan Anda sudah membuat database "suwarsuwirfixplis" di PgAdmin
-- Connection: Host=localhost;Port=5432;Database=suwarsuwirfixplis;Username=postgres;Password=postgresql;

-----------------------
-- TABLES CREATION
-----------------------

CREATE TABLE IF NOT EXISTS users (
    id_user SERIAL PRIMARY KEY,
    nama_lengkap VARCHAR(200) NOT NULL,
    username VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(200) NOT NULL, -- plain-text untuk testing sesuai permintaan
    email VARCHAR(200),
    no_hp VARCHAR(50),
    alamat TEXT,
    role VARCHAR(50) NOT NULL,
    tanggal_daftar TIMESTAMP NOT NULL DEFAULT NOW()
);

CREATE TABLE IF NOT EXISTS produks (
    id_produk SERIAL PRIMARY KEY,
    nama_produk VARCHAR(200) NOT NULL,
    deskripsi TEXT,
    kategori VARCHAR(100),
    harga NUMERIC(18,2) NOT NULL DEFAULT 0,
    stok INTEGER NOT NULL DEFAULT 0,
    gambar_path VARCHAR(500),
    tanggal_dibuat TIMESTAMP NOT NULL DEFAULT NOW(),
    tanggal_diubah TIMESTAMP NOT NULL DEFAULT NOW()
);

CREATE TABLE IF NOT EXISTS transaksis (
    id_transaksi SERIAL PRIMARY KEY,
    id_user INTEGER NOT NULL REFERENCES users(id_user) ON DELETE CASCADE,
    tanggal_transaksi TIMESTAMP NOT NULL DEFAULT NOW(),
    metode_pembayaran VARCHAR(200),
    status_pemesanan VARCHAR(50) NOT NULL DEFAULT 'Pending',
    total_harga NUMERIC(18,2) NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS detailtransaksis (
    id_detail SERIAL PRIMARY KEY,
    id_transaksi INTEGER NOT NULL REFERENCES transaksis(id_transaksi) ON DELETE CASCADE,
    id_produk INTEGER NOT NULL REFERENCES produks(id_produk),
    jumlah INTEGER NOT NULL,
    subtotal NUMERIC(18,2) NOT NULL
);

-----------------------
-- SEED DATA
-----------------------

-- Admin default (username=Adminsigma, password=Sigma123)
INSERT INTO users (nama_lengkap, username, password, email, no_hp, alamat, role, tanggal_daftar)
VALUES ('Administrator Suwar-Suwir', 'Adminsigma', 'Sigma123', 'admin@mutiararasa.com', '081234567890', 'Jember, Jawa Timur', 'admin', NOW())
ON CONFLICT (username) DO NOTHING;

-- Customer contoh
INSERT INTO users (nama_lengkap, username, password, email, no_hp, alamat, role, tanggal_daftar)
VALUES ('Budi Pelanggan', 'budi01', 'password123', 'budi@example.com', '081300000001', 'Jember', 'customer', NOW())
ON CONFLICT (username) DO NOTHING;

-- Produk contoh minimal 3
INSERT INTO produks (nama_produk, deskripsi, kategori, harga, stok, gambar_path, tanggal_dibuat, tanggal_diubah)
VALUES
('Suwar-Suwir Original', 'Olahan tape singkong rasa original', 'Olahan', 25000.00, 50, '', NOW(), NOW()),
('Suwar-Suwir Manis', 'Tape singkong dengan tambahan gula merah', 'Olahan', 27000.00, 30, '', NOW(), NOW()),
('Suwar-Suwir Pedas', 'Varian pedas khas Mutiara Rasa', 'Olahan', 28000.00, 20, '', NOW(), NOW())
ON CONFLICT DO NOTHING;

-- Contoh 1 transaksi (customer Budi)
-- Ambil id_user budi
DO $$
DECLARE
    uid INTEGER;
    pid INTEGER;
    transid INTEGER;
BEGIN
    SELECT id_user INTO uid FROM users WHERE username = 'budi01' LIMIT 1;
    IF uid IS NULL THEN
        RAISE NOTICE 'Customer contoh tidak ditemukan.';
        RETURN;
    END IF;

    -- Buat transaksi
    INSERT INTO transaksis (id_user, tanggal_transaksi, metode_pembayaran, status_pemesanan, total_harga)
    VALUES (uid, NOW(), 'Transfer Bank', 'Lunas', 25000.00) RETURNING id_transaksi INTO transid;

    -- Cari produk pertama (Suwar-Suwir Original) id
    SELECT id_produk INTO pid FROM produks WHERE nama_produk ILIKE 'Suwar-Suwir Original' LIMIT 1;

    IF pid IS NOT NULL THEN
        INSERT INTO detailtransaksis (id_transaksi, id_produk, jumlah, subtotal)
        VALUES (transid, pid, 1, 25000.00);

        -- Kurangi stok produk agar konsisten
        UPDATE produks SET stok = stok - 1 WHERE id_produk = pid;
    END IF;
END$$;

-- Catatan:
-- Password disimpan plain-text untuk memudahkan uji. Jangan gunakan ini di produksi.
