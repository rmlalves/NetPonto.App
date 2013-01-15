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
        public IDataServiceQuery<TElement> Expand<TTarget>(Expression<Func<TElement, TTarget>> navigationPropertyAccessor)
        {
            return this;
        }

        public IDataServiceQuery<TElement> Expand(string path)
        {
            return this;
        }

        public IDataServiceQuery<TElement> IncludeTotalCount()
        {
            return this;
        }

        public IDataServiceQuery<TElement> AddQueryOption(string name, object value)
        {
            return this;
        }

        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TElement> EndExecute(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TElement> Execute()
        {
            return _query;
        }

        IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
        {
            return _query.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _query.GetEnumerator();
        }

        public Type ElementType
        {
            get { return _query.ElementType; }
        }

        public Expression Expression
        {
            get { return _query.Expression; }
        }

        public IQueryProvider Provider
        {
            get { return _query.Provider; }
        } 
        #endregion
    }
}