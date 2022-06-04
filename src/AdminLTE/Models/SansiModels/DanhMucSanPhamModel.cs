using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Models.SansiModels
{
    public class DanhMucSanPhamModel
    {
        public int Id { get; set; }
        public List<SanPhamModel> ThoiTrang;
        public List<SanPhamModel> TheThao;
        public List<SanPhamModel> DoGiaDung;
    }
}
