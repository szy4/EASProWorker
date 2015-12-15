using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataQuery.Analyzer
{
    public static class SaleIssueAnalyzer
    {
        public static IEnumerable<Model.SaleIssueBase> FertilizerBrandReport(IEnumerable<Model.SaleIssueBase> data)
        {
            
            return data;
        }

        public static IEnumerable<Model.SaleIssueBase> FertilizerBrandReport(IEnumerable<Model.SaleIssueBase> data, int conditionId)
        {

            return data.Where(s => s.FBizDate == DateTime.Parse("2015-01-09"));
        }


        public static IEnumerable<Model.SaleIssueBase> AnalyzerDefult(IEnumerable<Model.SaleIssueBase> data)
        {
            var saleIssueBases = data as IList<SaleIssueBase> ?? data.ToList();

            var t1 = from d in saleIssueBases
                group d by new
                {
                    d.FParentStorageOrgUnit,
                    d.FBrandCarbaMind
                }
                into g
                select new
                {
                    g
                };

            //var res = saleIssueBases.GroupBy(d =>
            //{
            //    if (d.FParentStorageOrgUnit == "云南农业生产资料股份有限公司")
            //    {
            //        d.FParentStorageOrgUnit = d.FStorageOrgUnit;
            //    }
            //    return d;
            //});


            return null;
        }


    }
}
