using System;
using System.Collections.Generic;
using System.Text;
using Admin = DPLRef.eCommerce.Contracts.Admin.Catalog;
using WebStore = DPLRef.eCommerce.Contracts.WebStore.Catalog;

namespace DPLRef.eCommerce.Managers.Catalog
{
    class CatalogManager : ManagerBase, Admin.IAdminCatalogManager, WebStore.IWebStoreCatalogManager
    {
    }
}
