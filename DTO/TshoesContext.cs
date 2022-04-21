using System.Data.Entity;

namespace DTO
{
    public partial class TshoesContext : DbContext
    {
        public TshoesContext(string ConnectionString)
            : base(ConnectionString)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<BillDetails> BillDetails { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<Chinhanh> Chinhanh { get; set; }
        public virtual DbSet<ChitietNhapHang> ChitietNhapHang { get; set; }
        public virtual DbSet<ChiTietSanPham> ChiTietSanPham { get; set; }
        public virtual DbSet<LoginInfoes> LoginInfoes { get; set; }
        public virtual DbSet<NhapHang> NhapHang { get; set; }
        public virtual DbSet<NhomSP> NhomSP { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bills>()
                .HasMany(e => e.BillDetails)
                .WithOptional(e => e.Bills)
                .HasForeignKey(e => e.Bills_ID);

            modelBuilder.Entity<Chinhanh>()
                .HasMany(e => e.Account)
                .WithOptional(e => e.Chinhanh)
                .HasForeignKey(e => e.ChiNhanh_ID);

            modelBuilder.Entity<ChiTietSanPham>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.ChiTietSanPham)
                .HasForeignKey(e => e.ChitietSP_ID);

            modelBuilder.Entity<ChiTietSanPham>()
                .HasMany(e => e.ChitietNhapHang)
                .WithOptional(e => e.ChiTietSanPham)
                .HasForeignKey(e => e.ChitietsanPham_ID);

            modelBuilder.Entity<NhapHang>()
                .HasMany(e => e.ChitietNhapHang)
                .WithOptional(e => e.NhapHang)
                .HasForeignKey(e => e.NhapHang_ID);

            modelBuilder.Entity<NhomSP>()
                .HasMany(e => e.SanPham)
                .WithRequired(e => e.NhomSP)
                .HasForeignKey(e => e.NhomSP_ID);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietSanPham)
                .WithOptional(e => e.SanPham)
                .HasForeignKey(e => e.SanPham_ID);

            modelBuilder.Entity<ThuongHieu>()
                .HasMany(e => e.SanPham)
                .WithRequired(e => e.ThuongHieu)
                .HasForeignKey(e => e.ThuongHieu_ID);
        }
    }
}
