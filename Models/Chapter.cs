using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;
namespace MySite.Models
{
    public class Chapter
    {
        public int ChapterID { get; set; }
        public string NameChapter { get; set; }

        public ICollection<Article> Articles { get; set; }
        public Chapter()
        {
            Articles = new List<Article>();
        }
    }
}