using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RepositoryBase<T> where T:class
    {
        readonly IDbBase _ctx;
        public RepositoryBase(IDbBase ctx)
        {
            if (null == ctx)
            {
                throw new ArgumentNullException("context");
            }
            _ctx=ctx;
        }
        protected IDbSet<T> Entity
        {
            get
            {
                return _ctx.Set<T>();
            }
        }
    }
}
