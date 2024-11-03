using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ModelLayer
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Family { get; set; }
        [Required]
        [MaxLength(11)]
        [RegularExpression("^(09)\\d{9}$", ErrorMessage = "لطفا فرمت صحیح شماره موبایل را وارد کنید")]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public bool IsActive { get; set; }

        //Navigation Property
        public IEnumerable<Article> Articles { get; set; }
    }
}
