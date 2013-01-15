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
        public IDataServiceQuery<TElement> Expand<TTarget>(Expression<Func<TElement, TTarget>> navigationPropertyAccessor)
        {
            return new DataServiceQueryWrapper<TElement>(_query.Expand(navigationPropertyAccessor));
        }

        public IDataServiceQuery<TElement> Expand(string path)
        {
            return new DataServiceQueryWrapper<TElement>(_query.Expand(path));
        }

        public IDataServiceQuery<TElement> IncludeTotalCount()
        {
            return new DataServiceQueryWrapper<TElement>(_query.IncludeTotalCount());
        }

        public IDataServiceQuery<TElement> AddQueryOption(string name, object value)
        {
            return new DataServiceQueryWrapper<TElement>(_query.AddQueryOption(name, value));
        }

        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            return _query.BeginExecute(callback, state);
        }

        public IEnumerable<TElement> EndExecute(IAsyncResult asyncResult)
        {
            return _query.EndExecute(asyncResult);
        }

        public IEnumerable<TElement> Execute()
        {
            var asyncResult = _query.BeginExecute((result) => { }, _query);
            var list = _query.EndExecute(asyncResult).ToList();

            return list;
        }

        IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
        {
            return _query as IEnumerator<TElement>;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _query as IEnumerator;
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