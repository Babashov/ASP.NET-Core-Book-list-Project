using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Users
    {
        [ForeignKey("Users")]
        public int UsersID { get; set; }
        public string UsersName { get; set; }
    }
}
