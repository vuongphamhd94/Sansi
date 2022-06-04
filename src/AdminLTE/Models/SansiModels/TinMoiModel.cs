using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Models.SansiModels
{
    public class TinMoiModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string UrlImage { get; set; }
        public DateTime Time { get; set; }
        public string Note { get; set; }
    }
}
