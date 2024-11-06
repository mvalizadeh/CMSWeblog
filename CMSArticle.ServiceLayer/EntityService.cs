using CMSArticle.ModelLayer;
using CMSArticle.ModelLayer.Context;
using CMSArticle.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ServiceLayer
{
    public class EntityService<T> : GenericRepository<T> where T : BaseEntity
    {
        public EntityService(CMSContext context) : base(context)
        {
        }
    }
}
