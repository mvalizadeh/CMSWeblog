using CMSArticle.ModelLayer;
using CMSArticle.ModelLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.RepositoryLayer
{
    internal class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(CMSContext context) : base(context)
        {
        }
    }
}
