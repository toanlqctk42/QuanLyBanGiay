namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bills
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bills()
        {
            BillDetails = new HashSet<BillDetails>();
        }

        [Key]
        public int BillID { get; set; }

        public int NhanVienID { get; set; }

        [Required]
        [StringLength(200)]
        public string TenChiNhanh { get; set; }

        public DateTime NgaylapBill { get; set; }

        [Required]
        [StringLength(200)]
        public string TenKhachHang { get; set; }

        [StringLength(100)]
        public string SDTKhachHang { get; set; }

        public double TienHang { get; set; }

        public double Discount { get; set; }

        public double ToTal { get; set; }

        public int Active { get; set; }

        public int ChiNhanhID { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetails> BillDetails { get; set; }

        public virtual Chinhanh Chinhanh { get; set; }
    }
}
