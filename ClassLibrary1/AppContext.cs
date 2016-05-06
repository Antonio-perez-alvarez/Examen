using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AppContext:DbContext,IDbBase,IUnitOfWork
    {
        public AppContext()
            : base("DefaultConnection")
        {
 
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }
    }
}
