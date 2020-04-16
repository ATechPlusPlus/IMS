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
            Masters = 1,
            DepartmentMaster = 2,
            StoreMaster = 3,
            ShopeMaster = 4

        }
        public enum Operation
        {
            View = 1,
            Save = 2,
            Update = 3,
            Delete = 4,
            Other=5

        }

        public static bool HasFormRight(Forms formName, Operation operation)
        {
            int fID = (int)formName;
            int Operation = (int)operation;

            return CoreApp.clsUtility.HasFormRights(fID, Operation);


        }
    }
}
