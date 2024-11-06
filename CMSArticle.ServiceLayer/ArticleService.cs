using CMSArticle.ModelLayer;
using CMSArticle.ModelLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ServiceLayer
{
    public class ArticleService : EntityService<Article>, IArticleService
    {
        public ArticleService(CMSContext context) : base(context)
        {
        }
    }
}
