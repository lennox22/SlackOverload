using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;

namespace SlackOverload.Models
{
    [Table("answers")]
    public class answers
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string details { get; set; }
        public int qid { get; set; }
        public DateTime posted { get; set; }
        public int upvotes { get; set; }

    }
}
