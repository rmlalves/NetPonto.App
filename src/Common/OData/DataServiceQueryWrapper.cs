using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Linq.Expressions;

namespace NetPonto.App.Common.OData.Api
{
    public class DataServiceQueryWrapper<TElement> : IDataServiceQuery<TElement>
    {
        private DataServiceQuery<TElement> _query = null;

        public DataServiceQueryWrapper(DataServiceQuery<TElement> query)
        {
            _query = query;
        }

        #region IDataServiceQuery
        IDataServiceQuery<TElement> IDataServiceQuery<TElement>.Expand<TTarget>(Expression<Func<TElement, TTarget>> navigationPropertyAccessor)
        {
            return new DataServiceQueryWrapper<TElement>(_query.Expand(navigationPropertyAccessor));
        }

        IDataServiceQuery<TElement> IDataServiceQuery<TElement>.Expand(string path)
        {
            return new DataServiceQueryWrapper<TElement>(_query.Expand(path));
        }

        IDataServiceQuery<TElement> IDataServiceQuery<TElement>.IncludeTotalCount()
        {
            return new DataServiceQueryWrapper<TElement>(_query.IncludeTotalCount());
        }

        IDataServiceQuery<TElement> IDataServiceQuery<TElement>.AddQueryOption(string name, object value)
        {
            return new DataServiceQueryWrapper<TElement>(_query.AddQueryOption(name, value));
        }

        IAsyncResult IDataServiceQuery<TElement>.BeginExecute(AsyncCallback callback, object state)
        {
            return _query.BeginExecute(callback, state);
        }

        IEnumerable<TElement> IDataServiceQuery<TElement>.EndExecute(IAsyncResult asyncResult)
        {
            return _query.EndExecute(asyncResult);
        }

        IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
        {
            return _query as IEnumerator<TElement>;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _query as IEnumerator;
        }

        Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _query.Provider; }
        } 
        #endregion
    }
}