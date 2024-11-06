using CMSArticle.ModelLayer;
using CMSArticle.ModelLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.RepositoryLayer
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(CMSContext context) : base(context)
        {
        }
    }
}
