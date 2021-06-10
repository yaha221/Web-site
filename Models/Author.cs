using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;

namespace MySite.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FullName { get; set; }
        public string ShortDescriptionAuthor { get; set; }
        public DateTime DateCreateAuthor { get; set; }
        public string ImageScr { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}