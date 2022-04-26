namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Bills = new HashSet<Bills>();
        }

        [Key]
        public int NhanVienID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(1000)]
        public string Fullname { get; set; }

        public DateTime Ngaykhoitao { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        public int? ChiNhanh_ID { get; set; }

        public int Active { get; set; }

        public Guid rowguid { get; set; }

        public virtual Chinhanh Chinhanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bills> Bills { get; set; }
    }
}
