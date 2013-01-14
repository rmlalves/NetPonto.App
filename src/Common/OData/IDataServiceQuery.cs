using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NetPonto.App.Common.OData
{
    public interface IDataServiceQuery<TElement> : IQueryable<TElement>, IEnumerable<TElement>, IQueryable, IEnumerable
    {
        IDataServiceQuery<TElement> Expand<TTarget>(Expression<Func<TElement, TTarget>> navigationPropertyAccessor);
        IDataServiceQuery<TElement> Expand(string path);
        IDataServiceQuery<TElement> IncludeTotalCount();
        IDataServiceQuery<TElement> AddQueryOption(string name, object value);

        IAsyncResult BeginExecute(AsyncCallback callback, object state);
        IEnumerable<TElement> EndExecute(IAsyncResult asyncResult);
    }
}
