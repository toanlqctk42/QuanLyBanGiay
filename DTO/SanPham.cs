namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietSanPham = new HashSet<ChiTietSanPham>();
        }

        public int SanPhamID { get; set; }

        [Required]
        [StringLength(100)]
        public string MaSanPham { get; set; }

        [Required]
        [StringLength(1000)]
        public string TenSanPham { get; set; }

        public int NhomSP_ID { get; set; }

        public int ThuongHieu_ID { get; set; }

        public DateTime Ngaynhap { get; set; }

        public int GiaNhap { get; set; }

        public int Giaban { get; set; }

        public int Soluong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPham { get; set; }

        public virtual NhomSP NhomSP { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}
