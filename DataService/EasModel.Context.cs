﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EasEntities : DbContext
    {
        public EasEntities()
            : base("name=EasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SZY_SaleIssueBase_Result> SZY_SaleIssueBase(Nullable<System.DateTime> fBizDateStrart, Nullable<System.DateTime> fBizDateEnd)
        {
            var fBizDateStrartParameter = fBizDateStrart.HasValue ?
                new ObjectParameter("FBizDateStrart", fBizDateStrart) :
                new ObjectParameter("FBizDateStrart", typeof(System.DateTime));
    
            var fBizDateEndParameter = fBizDateEnd.HasValue ?
                new ObjectParameter("FBizDateEnd", fBizDateEnd) :
                new ObjectParameter("FBizDateEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SZY_SaleIssueBase_Result>("SZY_SaleIssueBase", fBizDateStrartParameter, fBizDateEndParameter);
        }
    }
}
