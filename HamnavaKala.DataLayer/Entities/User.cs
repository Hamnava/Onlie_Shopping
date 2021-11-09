using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string userAccount { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string Email { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string ActiceCode { get; set; }

        #region Relations to other
        public List<Question> Questions { get; set; }
        public List<Comment> Comment { get; set; }
        #endregion
    }
}
