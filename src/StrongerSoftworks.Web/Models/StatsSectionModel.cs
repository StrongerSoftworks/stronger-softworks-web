using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Web.Models
{
    public class StatsItemModel
    {
        public int StartValue { get; set; }
        public int EndValue { get; set; }
        public int Duration { get; set; }
        public string Label { get; set; }
    }

    public class StatsSectionModel : SectionModel
    {
        public List<StatsItemModel> StatsItems { get; set; }
    }
}
