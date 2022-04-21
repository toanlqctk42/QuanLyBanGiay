namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietSanPham")]
    public partial class ChiTietSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietSanPham()
        {
            BillDetails = new HashSet<BillDetails>();
            ChitietNhapHang = new HashSet<ChitietNhapHang>();
        }

        [Key]
        public int ChitietSPID { get; set; }

        public int? SanPham_ID { get; set; }

        public string MaSP { get; set; }

        public string TenSP { get; set; }

        public string Mau { get; set; }

        public int Sizes { get; set; }

        public int Soluong { get; set; }

        public int Kinhdoanh { get; set; }

        public string ImgURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetails> BillDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChitietNhapHang> ChitietNhapHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
