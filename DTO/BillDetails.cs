namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillDetails
    {
        [Key]
        public int BillDetailID { get; set; }

        public int ChitietSP_ID { get; set; }

        [StringLength(1000)]
        public string TenSP { get; set; }

        public int? Bills_ID { get; set; }

        public string Mau { get; set; }

        public int Sizes { get; set; }

        public int Soluong { get; set; }

        public int Giaban { get; set; }

        public virtual Bills Bills { get; set; }

        public virtual ChiTietSanPham ChiTietSanPham { get; set; }
    }
}
