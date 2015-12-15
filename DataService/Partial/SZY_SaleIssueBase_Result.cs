using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

// ReSharper disable once CheckNamespace
namespace DataService
{
    // ReSharper disable once InconsistentNaming
    public partial class SZY_SaleIssueBase_Result
    {
        #region 将EF对象转换成实体对象 +ToPoco(SZY_SaleIssueBase_Result model)
        /// <summary>
        /// 将EF对象转换成实体对象 +ToPoco(SZY_SaleIssueBase_Result model)
        /// </summary>
        /// <returns></returns>
        public SaleIssueBase ToPoco()
        {

            return new Model.SaleIssueBase()
            {
                FActualCost = this.FActualCost ?? 0,
                FActualPrice = this.FActualPrice,
                FAmount = this.FAmount ?? 0,
                FAuditTime = this.FAuditTime ?? DateTime.MinValue,
                FAuditor = this.FAuditor,
                FBalanceCustomer = this.FBalanceCustomer,
                FBaseQty = this.FBaseQty ?? 0,
                FBaseStatus = this.FBaseStatus ?? -1,
                FBaseUnit = this.FBaseUnit,
                FBillType = this.FBillType,
                FBizDate = this.FBizDate ?? DateTime.MinValue,
                FBizType = this.FBizType,
                FBrandCarbaMind = this.FBrandCarbaMind,
                FBrandFertilizer = this.FBrandFertilizer,
                FCompanyOrgUnit = this.FCompanyOrgUnit,
                FControlUnit = this.FControlUnit,
                FCreateTime = this.FCreateTime ?? DateTime.MinValue,
                FCreator = this.FCreator,
                FCustomer = this.FCustomer,
                FCustomerDisplayName = this.FCustomerDisplayName,
                FCustomerNumber = this.FCustomerNumber,
                FCustomerType0 = this.FCustomerType0,
                FCustomerType1 = this.FCustomerType1,
                FCustomerType2 = this.FCustomerType2,
                FDay = this.FDay ?? 0,
                FDiscount = this.FDiscount ?? 0,
                FID = this.FID,
                FIsInTax = this.FIsInTax ?? -1,
                FMaterial = this.FMaterial,
                FMaterialDisplayName = this.FMaterialDisplayName,
                FMaterialModel = this.FMaterialModel,
                FMaterialNumber = this.FMaterialNumber,
                FMaterialType0 = this.FMaterialType0,
                FMaterialType1 = this.FMaterialType1,
                FMaterialType2 = this.FMaterialType2,
                FMonth = this.FMonth ?? 0,
                FNumber = this.FNumber,
                FOrderCustomer = this.FOrderCustomer,
                FParentStorageOrgUnit = this.FParentStorageOrgUnit, //需要判断
                FPaymentCustomer = this.FParentStorageOrgUnit,
                FPaymentType = this.FPaymentType,
                FPeriod = this.FPeriod ?? 0,
                FPrice = this.FPrice ?? 0,
                FQty = this.FQty ?? 0,
                FStorageOrgUnit = this.FStorageOrgUnit,
                FTaxPrice = this.FTaxPrice,
                FTransactionType = this.FTransactionType,
                FUnit = this.FUnit,
                FUnitActualCost = this.FUnitActualCost ?? 0,
                FWarehouse = this.FWarehouse,
                FYear = this.FYear ?? 0
            };

        }
        #endregion
    }
}
