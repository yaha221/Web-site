using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;

namespace MySite.Models
{
    public class Comment
    {
        public int CommentID{ get; set; }
        public int? AccountID{ get; set; }
        public int? ArticleID{ get; set; }
        public string TextComment { get; set; }
        public DateTime DateCreateComment { get; set; }
        
        public virtual Account Account { get; set; }
        public virtual Article Article { get; set; }
    }
}