using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MySite.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        [Display(Name = "Логин")]
        public string Login { get; set; }
        public string Password { get; set; }
        public string RoleAccount { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}