using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MySite.Models
{
    public class Article
    {
        public int ArticleID{ get; set; }
        public int? AuthorID{ get; set; }
        public int? ChapterID{ get; set; }
        public string NameArticle { get; set; }
        public string ShortDescriptionArticle { get; set; }
        public string TextArticle { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreateArticle { get; set; }
        public int TimeRead { get; set; }
        public string ImageScrMain { get; set; }
        public int NumViews { get; set; }
        public int NumComments { get; set; }
        public int NumLikes { get; set; }

        public virtual Author Author { get; set; }
        public virtual Chapter Chapter { get; set; }
        public virtual ICollection<Tag> Tags { get; set; } 
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Account> Accounts { get; }
    }
}