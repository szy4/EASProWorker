using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService;
using Model;

namespace DataQuery
{
    public class SaleIssue
    {
        private readonly EasEntities _db = new EasEntities();

        public IEnumerable<Model.SaleIssueBase> QueryBases(Filters.SaleIssueFilter filter)
        {
            return _db.SZY_SaleIssueBase(filter.BizDateStart, filter.BizDateEnd).Select(o=>o.ToPoco());
        }
    }
}
