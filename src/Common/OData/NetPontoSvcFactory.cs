using System;

using NetPonto.App.Common.OData.Api;

namespace NetPonto.App.Common.OData
{
    public static class NetPontoSvcFactory
    {
        #region Methods
        public static INetPontoSvc CreateSvc()
        {
#if DEBUG
            return new NetPontoMockContext();
#else
            return new NetPontoDbContext(new Uri(@"http://localhost:9903/OData/Api.svc"));
#endif
        } 
        #endregion
    }
}
