using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementByWebForm
{
    public class UserBLL
    {
        UserDAL U = new UserDAL();
        public int InsertBLL(userProps u)
        {
            int i = U.InsertDAL(u);
            return i;
        }
        public int UpdateBLL(userProps u)
        {
            int i = U.UpdateDAL(u);
            return i;
        }
        public int DeleteBLL(userProps u)
        {
            int i = U.DeleteDAL(u);
            return i;
        }
        public int SelectBLL(userProps u)
        {
            int i = U.SelectDAL(u);
            return i;
        }
    }
}