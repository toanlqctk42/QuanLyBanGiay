namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChitietNhapHang")]
    public partial class ChitietNhapHang
    {
        public int ChitietNhaphangID { get; set; }

        public int? NhapHang_ID { get; set; }

        public int? ChitietsanPham_ID { get; set; }

        public double DonGia { get; set; }

        public int SoLuongNhap { get; set; }

        public virtual ChiTietSanPham ChiTietSanPham { get; set; }

        public virtual NhapHang NhapHang { get; set; }
    }
}
