using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Models.SansiModels
{
    public class PhanTrang
    {
        public int p { get; set; }
        public int n { get; set; }
        public int totalCount { get; set; }
        public List<SanPhamModel> listSanPham { get; set; }
        public string searchName { get; set; }
    }
}