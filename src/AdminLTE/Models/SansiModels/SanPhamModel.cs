using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Models.SansiModels
{
    public class SanPhamModel
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public double? GiaSanPham { get; set; }
        public string UrlImage { get; set; }
        public int Type { get; set; }
    }
}
