﻿using System.Web;
using System.Web.Mvc;

namespace SP_keyvault_integration_via_vm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
