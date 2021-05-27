using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;

namespace SlackOverload.Models
{
    [Table("questions")]
    public class questions
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string title { get; set; }
        public string details { get; set; }
        public DateTime posted { get; set; }
        public string tags { get; set; }
        public int status { get; set; }
    }
}
