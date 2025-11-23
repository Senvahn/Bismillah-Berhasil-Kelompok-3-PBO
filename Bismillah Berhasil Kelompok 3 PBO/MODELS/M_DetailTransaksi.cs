using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuwarSuwirApp.Models
{
    [Table("detailtransaksis")]
    public class M_DetailTransaksi
    {
        [Key]
        [Column("id_detail")]
        public int IdDetail { get; set; }

        [Column("id_transaksi")]
        public int IdTransaksi { get; set; }

        [Column("id_produk")]
        public int IdProduk { get; set; }

        [Column("jumlah")]
        public int Jumlah { get; set; }

        [Column("subtotal")]
        public decimal Subtotal { get; set; }
    }
}
