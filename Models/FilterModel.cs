using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class RangeTimeModel
    {
        public string NameFilter { get; set; }
        public DateTime TimeFilter1 { get; set; }
        public DateTime TimeFilter2 { get; set; }
    }

    public class FilterModel
    {
        public string sql { get; set; } = string.Empty;
        public string sql2 { get; set; } = string.Empty;
        public DynamicParameters param { get; set; } = new DynamicParameters();
    }
}
