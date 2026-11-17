using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhamNgocKhai_241230754.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }

    public int MaLoai { get; set; }

    public string TenHang { get; set; } = null!;

    [Required]
    [Range(typeof(decimal),"100" , "5000" ,ErrorMessage ="vui long nhap trong khaong 100 va 5000") ]
    public decimal? Gia { get; set; }

    public string? Anh { get; set; }

    public virtual LoaiHang MaLoaiNavigation { get; set; } = null!;
}
