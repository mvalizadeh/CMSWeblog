using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ModelLayer
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        [Required]
        public int AdminId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }
        public string ImageName { get; set; }
        public int Like { get; set; }
        public int Visit { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public bool IsActive { get; set; }

        //Navigation Property
        public Category Category { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public Admin Admin { get; set; }
    }
}
