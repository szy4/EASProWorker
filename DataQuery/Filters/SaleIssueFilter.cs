using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataQuery.Filters
{
    public class SaleIssueFilter
    {
        public SaleIssueFilter()
        {
            this.ControlUnit = "";
        }

        public DateTime BizDateStart { get; set; }

        public DateTime BizDateEnd { get; set; }

        public string ControlUnit { get; set; }
    }
}
