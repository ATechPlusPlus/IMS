using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMS
{
    public class clsFormRights
    {
        public enum Forms
        {
            Color_Master = 36,
            Customer_Master = 37,
            Product_Master = 38,
            Brand_Master = 10,
            Category_Master = 11,
            Country_Master = 12,
            Employee_Details = 13,
            Size_Master = 14,
            Size_Type_Master = 15,
            Store_Master = 16,
            Supplier_Details = 17,
            Material_Details = 18,
            Currency_Value_Settings = 19,
            Employee_Commission_Setting = 20,
            frmOtherSetting = 21,
            Sales_Bill_Details = 22,
            Sales_Invoice = 23,
            //frmSalesInvoice = 18,
            frmSalesReport = 25,
            Delivering_Purchase_Bill = 26,
            frmDiffPurchaseReceived = 27,
            frmDiffPurchaseReceviedDetails = 28,
            Posting_Delivery = 29,
            Purchase_Bill_Details = 30,
            Purchase_Invoice = 31,
            frmBarCode = 32,
            BarCode_Designer = 33,
            frmDatabaseMaintenance = 7
        }
        public enum Operation
        {
            View = 1,
            Save = 2,
            Update = 3,
            Delete = 4,
            Other = 5
        }

        public static bool HasFormRight(Forms formName)
        {
            int fID = (int)formName;

            return CoreApp.clsUtility.HasFormRights(fID);
        }

        public static bool HasFormRight(Forms formName, Operation operation)
        {
            int fID = (int)formName;
            int Operation = (int)operation;

            return CoreApp.clsUtility.HasFormRights(fID, Operation);
        }
    }
}