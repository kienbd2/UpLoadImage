namespace UpLoadImage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XuatKho")]
    public partial class XuatKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XuatKho()
        {
            XuatKhoChiTiets = new HashSet<XuatKhoChiTiet>();
        }

        [Key]
        [StringLength(12)]
        public string MaXuatKho { get; set; }

        public DateTime NgayXuat { get; set; }

        [StringLength(1024)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XuatKhoChiTiet> XuatKhoChiTiets { get; set; }
    }
}
