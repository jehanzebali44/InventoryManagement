using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace InventoryManagementByWebForm
{
    public class adminBLL
    {
        public int InsertBLL(adminProps a)
        {
            adminDAL A = new adminDAL();
            int i = A.InsertDAL(a);
            return i;
        }
        public int UpdateBLL(adminProps a)
        {
            adminDAL A = new adminDAL();
            int i = A.UpdateDAL(a);
            return i;
        }
        public int SelectBLL(adminProps a)
        {
            adminDAL A = new adminDAL();
            int i = A.SelectDAL(a);
            return i;
        }
    }
}