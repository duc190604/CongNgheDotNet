using System;
using System.Collections.Generic;

namespace KTTH.Models
{
    public partial class TDanhMucSp
    {
       

        public string MaSp { get; set; } = null!;
        public string? TenSp { get; set; }
        public string? ChatLieu { get; set; }
        public string? HangSx { get; set; }
        public string? NuocSx { get; set; }
        public string? DacTinh { get; set; }
        public double? ThoiGianBaoHanh { get; set; }
        public string? GioiThieuSp { get; set; }
        public string? MaLoai { get; set; }
        public string? AnhDaiDien { get; set; }
        public decimal? Gia { get; set; }
       

      
        public virtual TLoaiSp? MaLoaiNavigation { get; set; }
      
      
    }
}
