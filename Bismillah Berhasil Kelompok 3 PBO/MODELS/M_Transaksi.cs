using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuwarSuwirApp.Models
{
    [Table("transaksis")]
    public class M_Transaksi
    {
        [Key]
        [Column("id_transaksi")]
        public int IdTransaksi { get; set; }

        [Column("id_user")]
        public int IdUser { get; set; }

        [Column("tanggal_transaksi")]
        public DateTime TanggalTransaksi { get; set; }

        [Column("metode_pembayaran")]
        public string MetodePembayaran { get; set; }

        [Column("status_pemesanan")]
        public string StatusPemesanan { get; set; } // e.g. Pending, Lunas, Dibatalkan

        [Column("total_harga")]
        public decimal TotalHarga { get; set; }

        // Navigational property (optional)
        public List<M_DetailTransaksi> DetailTransaksis { get; set; }
    }
}
