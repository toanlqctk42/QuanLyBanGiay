namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhapHang")]
    public partial class NhapHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhapHang()
        {
            ChitietNhapHang = new HashSet<ChitietNhapHang>();
        }

        public int NhapHangID { get; set; }

        public DateTime ngaynhap { get; set; }

        public string NguonHang { get; set; }

        public double Tienhang { get; set; }

        public double? Phivanchuyen { get; set; }

        public double? Thue { get; set; }

        public double? ChiPhiKhac { get; set; }

        public double Thanhtien { get; set; }

        public string Ghichu { get; set; }

        public Guid rowguid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChitietNhapHang> ChitietNhapHang { get; set; }
    }
}
