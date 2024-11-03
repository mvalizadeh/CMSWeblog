using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ModelLayer
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        //Navigation Property
        public IEnumerable<Article> Articles { get; set; }
    }
}
