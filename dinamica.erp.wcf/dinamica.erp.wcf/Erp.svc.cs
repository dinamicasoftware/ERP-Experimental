//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using dinamica.erp.wcf.Entities;
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel.Web;
using System.Web;

namespace dinamica.erp.wcf
{
    public class Erp : CustomService
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.UseVerboseErrors = true;
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }
    }

    public class CustomService : DataService<ERPBLL>
    {
        protected override ERPBLL CreateDataSource()
        {
            ERPBLL source = new ERPBLL();
            return source;
        }

        [WebGet]
        public IQueryable<Client> Get(string where)
        {
            return null;
        }
    }

    public class ERPBLL
    {
        private ERPContext context;

        public ERPBLL()
        {
            context = new ERPContext();
        }

        public IQueryable<Client> Get(Expression<Func<Client, bool>> where)
        {
            return context.ClientsDao.Where(where);
        }
    }
}
