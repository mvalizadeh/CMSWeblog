﻿using CMSArticle.ModelLayer;
using CMSArticle.ModelLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ServiceLayer
{
    public class CommentService : EntityService<Comment>, ICommentService
    {
        public CommentService(CMSContext context) : base(context)
        {
        }
    }
}
