namespace UpLoadImage
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<NhapKho> NhapKhoes { get; set; }
        public virtual DbSet<NhapKhoChiTiet> NhapKhoChiTiets { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<XuatKho> XuatKhoes { get; set; }
        public virtual DbSet<XuatKhoChiTiet> XuatKhoChiTiets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhapKho>()
                .Property(e => e.MaNhapKho)
                .IsUnicode(false);

            modelBuilder.Entity<NhapKhoChiTiet>()
                .Property(e => e.MaSp)
                .IsUnicode(false);

            modelBuilder.Entity<NhapKhoChiTiet>()
                .Property(e => e.MaNhapKho)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSp)
                .IsUnicode(false);

            modelBuilder.Entity<XuatKho>()
                .Property(e => e.MaXuatKho)
                .IsUnicode(false);

            modelBuilder.Entity<XuatKhoChiTiet>()
                .Property(e => e.MaSp)
                .IsUnicode(false);

            modelBuilder.Entity<XuatKhoChiTiet>()
                .Property(e => e.MaXuatKho)
                .IsUnicode(false);
        }
    }
}
