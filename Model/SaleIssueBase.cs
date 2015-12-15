using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SaleIssueBase
    {

        public string FID { get; set; }


        public string FNumber { get; set; }


        public string FCustomer { get; set; }


        public string FPaymentType { get; set; }


        public string FStorageOrgUnit { get; set; }


        public string FParentStorageOrgUnit { get; set; }


        public string FTransactionType { get; set; }


        public DateTime FAuditTime { get; set; }


        public string FAuditor { get; set; }


        public int FBaseStatus { get; set; }


        public string FBizType { get; set; }

        public string FBillType { get; set; }

        public int FYear { get; set; }


        public int FPeriod { get; set; }


        public DateTime FBizDate { get; set; }

        public string FCreator { get; set; }

        public DateTime FCreateTime { get; set; }


        public string FControlUnit { get; set; }


        public int FIsInTax { get; set; }


        public int FMonth { get; set; }


        public int FDay { get; set; }


        public string CFNZDepCash { get; set; }


        public decimal FTaxPrice { get; set; }


        public decimal FActualPrice { get; set; }


        public string FBalanceCustomer { get; set; }


        public string FOrderCustomer { get; set; }


        public string FPaymentCustomer { get; set; }


        public string FCompanyOrgUnit { get; set; }


        public string FWarehouse { get; set; }


        public decimal FQty { get; set; }


        public decimal FBaseQty { get; set; }


        public decimal FPrice { get; set; }


        public decimal FAmount { get; set; }


        public decimal FUnitActualCost { get; set; }


        public decimal FActualCost { get; set; }


        public string FUnit { get; set; }


        public string FBaseUnit { get; set; }


        public decimal FDiscount { get; set; }


        public decimal CFMinPrice { get; set; }


        public string CFNZMaterialName { get; set; }


        public string FCustomerNumber { get; set; }


        public string FCustomerDisplayName { get; set; }


        public string FCustomerType0 { get; set; }


        public string FCustomerType1 { get; set; }


        public string FCustomerType2 { get; set; }


        public string FMaterialNumber { get; set; }


        public string FMaterial { get; set; }


        public string FMaterialModel { get; set; }


        public string FMaterialDisplayName { get; set; }


        public string FMaterialType0 { get; set; }


        public string FMaterialType1 { get; set; }


        public string FMaterialType2 { get; set; }


        public string FBrandFertilizer { get; set; }


        public string FBrandCarbaMind { get; set; }

    }
}
