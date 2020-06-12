namespace UpLoadImage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhapKho")]
    public partial class NhapKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhapKho()
        {
            NhapKhoChiTiets = new HashSet<NhapKhoChiTiet>();
        }

        [Key]
        [StringLength(12)]
        public string MaNhapKho { get; set; }

        public DateTime NgayNhap { get; set; }

        [StringLength(1024)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhapKhoChiTiet> NhapKhoChiTiets { get; set; }
    }
}
