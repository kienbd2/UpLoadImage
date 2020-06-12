namespace UpLoadImage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XuatKhoChiTiet")]
    public partial class XuatKhoChiTiet
    {
        [Key]
        public int MaXuatKhoChiTiet { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string MaSp { get; set; }

        [StringLength(12)]
        public string MaXuatKho { get; set; }

        [StringLength(1024)]
        public string MoTa { get; set; }

        public virtual SanPham SanPham { get; set; }

        public virtual XuatKho XuatKho { get; set; }
    }
}
