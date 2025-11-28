using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuwarSuwirApp.Models
{
    [Table("produks")]
    public class M_Produk
    {
        [Key]
        [Column("id_produk")]
        public int IdProduk { get; set; }

        [Column("nama_produk")]
        public string NamaProduk { get; set; }

        [Column("deskripsi")]
        public string Deskripsi { get; set; }

        [Column("kategori")]
        public string Kategori { get; set; }

        [Column("harga")]
        public decimal Harga { get; set; }

        [Column("stok")]
        public int Stok { get; set; }

        [Column("tanggal_dibuat")]
        public DateTime TanggalDibuat { get; set; }

        [Column("tanggal_diubah")]
        public DateTime TanggalDiubah { get; set; }
    }
}
