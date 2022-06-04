using AdminLTE.Models.SansiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Models.SansiModels
{
    public class ChiTietTinModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string UrlImage { get; set; }

        public List<TinMoiModel> ListTinMoi { get; set; }

    }
}
