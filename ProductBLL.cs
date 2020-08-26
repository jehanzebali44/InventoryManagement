using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementByWebForm
{
    public class ProductBLL
    {
        ProductDAL U = new ProductDAL();
        public int InsertBLL(productPropos u)
        {
            int i = U.InsertDAL(u);
            return i;
        }
        public int UpdateBLL(productPropos u)
        {
            int i = U.UpdateDAL(u);
            return i;
        }
        public int DeleteBLL(productPropos u)
        {
            int i = U.DeleteDAL(u);
            return i;
        }
    }
}