﻿using CMSArticle.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.RepositoryLayer
{
    public interface IArticleRepository:IGenericRepository<Article>
    {
    }
}
