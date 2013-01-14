using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NetPonto.App.Common.OData.Api
{
    public class DataServiceQueryMock<TElement> : IDataServiceQuery<TElement>
    {
        private IQueryable<TElement> _query = null;
        
        public DataServiceQueryMock(IQueryable<TElement> query)
        {
            _query = query;
        }

        #region IDataServiceQuery
        IDataServiceQuery<TElement> IDataServiceQuery<TElement>.Expand<TTarget>(Expression<Func<TElement, TTarget>> navigationPropertyAccessor)
        {
            return this;
        }

        IDataServiceQuery<TElement> IDataServiceQuery<TElement>.Expand(string path)
        {
            return this;
        }

        IDataServiceQuery<TElement> IDataServiceQuery<TElement>.IncludeTotalCount()
        {
            return this;
        }

        IDataServiceQuery<TElement> IDataServiceQuery<TElement>.AddQueryOption(string name, object value)
        {
            return this;
        }

        IAsyncResult IDataServiceQuery<TElement>.BeginExecute(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TElement> IDataServiceQuery<TElement>.EndExecute(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
        {
            return _query.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _query.GetEnumerator();
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