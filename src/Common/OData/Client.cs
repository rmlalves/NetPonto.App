using System;

using Netponto.App.Common.OData.Api;

namespace Netponto.App.Common.OData
{
    public static class NetPontoSvcFactory
    {
        #region Methods
        public static INetPontoSvc CreateSvc()
        {
#if DEBUG
            return new NetPontoMockContext();
#else
            return new NetPontoDbContext(new Uri(@"http://netponto.org/OData/Api.svc"));
#endif
        } 
        #endregion
    }
}
