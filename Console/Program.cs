using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataQuery;
using DataQuery.Analyzer;
using DataQuery.Filters;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var query = new DataQuery.SaleIssue();

            var res = query.QueryBases(new SaleIssueFilter()
            {
                BizDateStart = DateTime.Parse("2015-01-01"),
                BizDateEnd = DateTime.Parse("2015-01-10")
            });

            var corRes = SaleIssueAnalyzer.FertilizerBrandReport(res);

            System.Console.WriteLine(corRes.Count());
            System.Console.ReadLine();
        }
    }
}
