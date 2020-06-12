namespace UpLoadImage
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
            NhapKhoChiTiets = new HashSet<NhapKhoChiTiet>();
            XuatKhoChiTiets = new HashSet<XuatKhoChiTiet>();
        }

        [Key]
        [StringLength(10)]
        public string MaSp { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSp { get; set; }

        [Required]
        [StringLength(20)]
        public string DonVi { get; set; }

        public int? SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhapKhoChiTiet> NhapKhoChiTiets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XuatKhoChiTiet> XuatKhoChiTiets { get; set; }
    }
}
