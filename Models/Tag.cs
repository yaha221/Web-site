using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;

namespace MySite.Models
{
    public class Tag
    {
        public int TagID { get; set; }
        public string NameTag { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}