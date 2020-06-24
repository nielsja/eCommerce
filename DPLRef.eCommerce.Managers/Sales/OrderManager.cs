using System;
using System.Collections.Generic;
using System.Text;
using Admin = DPLRef.eCommerce.Contracts.Admin.Sales;
using WebStore = DPLRef.eCommerce.Contracts.WebStore.Sales;

namespace DPLRef.eCommerce.Managers.Sales
{
    class OrderManager : ManagerBase, Admin.IAdminOrderManager, WebStore.IWebStoreOrderManager
    {
    }
}
