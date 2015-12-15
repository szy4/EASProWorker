using DataQuery.Analyzer;
using DataQuery.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;


namespace WebAPI.Controllers
{
    [RoutePrefix("api/FertBrandReport")]
    public class FertBrandReportController : ApiController
    {
        public IEnumerable<Model.SaleIssueBase> GetData()
        {
            

            var query = new DataQuery.SaleIssue();
            var res = query.QueryBases(new SaleIssueFilter()
            {
                BizDateStart = DateTime.Parse("2015-01-01"),
                BizDateEnd = DateTime.Parse("2015-01-31")
            });

            var corRes = SaleIssueAnalyzer.FertilizerBrandReport(res);

            var issueBases = corRes as IList<SaleIssueBase> ?? corRes.ToList();

            var t1 = from d in issueBases
                     group d by new
                     {
                         d.FParentStorageOrgUnit,
                         d.FBrandCarbaMind,
                         d.FStorageOrgUnit
                         

                     }
                         into g
                         orderby g.Key.FParentStorageOrgUnit
                         select new
                         {
                             //g.Key.FParentStorageOrgUnit,
                             FStorageOrgUnit = g.Key.FParentStorageOrgUnit == "云南农业生产资料股份有限公司" ? g.Key.FStorageOrgUnit:g.Key.FParentStorageOrgUnit,
                             g.Key.FBrandCarbaMind,
                             FSumQty = (decimal?)g.Sum(s => s.FBaseQty)
                         };

            //(from se in db.T_IM_SaleIssueEntry
            //    where
            //      se.FCompanyOrgUnitID != ""
            //    group se by new {
            //      se.FStorageOrgUnitID,
            //      se.FOrderCustomerID,
            //      se.FBaseQty,
            //      se.FQty
            //    } into g
            //    select new {
            //      g.Key.FStorageOrgUnitID,
            //      g.Key.FOrderCustomerID,
            //      g.Key.FBaseQty,
            //      g.Key.FQty
            //    }).Take(100)

            return issueBases;
        }
    }
}
