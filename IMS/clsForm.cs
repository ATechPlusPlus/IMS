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
            Color_Master = 1,
            Customer_Master = 2,
            Product_Master = 3,
            Brand_Master = 4,
            Category_Master = 5,
            Country_Master = 6,
            Employee_Details = 7,
            Size_Master = 8,
            Size_Type_Master = 9,
            Store_Master = 10,
            Supplier_Details = 11,
            Material_Details = 12,
            Currency_Value_Settings = 13,
            Employee_Commission_Setting = 14,
            frmOtherSetting = 15,
            Sales_Bill_Details = 16,
            Sales_Invoice = 17,
            frmSalesInvoice = 18,
            frmSalesReport = 19,
            Delivering_Purchase_Bill = 20,
            frmDiffPurchaseReceived = 21,
            frmDiffPurchaseReceviedDetails = 22,
            Posting_Delivery = 23,
            Purchase_Bill_Details = 24,
            Purchase_Invoice = 25,
            frmBarCode = 26,
            BarCode_Designer = 27,
            frmDatabaseMaintenance = 28
       
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