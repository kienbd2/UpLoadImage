namespace UpLoadImage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhapKhoChiTiet")]
    public partial class NhapKhoChiTiet
    {
        [Key]
        public int MaNhapKhoChiTiet { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string MaSp { get; set; }

        [StringLength(12)]
        public string MaNhapKho { get; set; }

        [StringLength(1024)]
        public string MoTa { get; set; }

        public virtual NhapKho NhapKho { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
