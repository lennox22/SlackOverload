using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;


namespace SlackOverload.Models
{
    public class DAL
    {
        public static IDbConnection db;
        public static string CurrentUser;
        //db actions
        public static List<questions> GetAllQuestions()
        {
            List<questions> q = db.Query<questions>("select * from questions order by posted desc").ToList();
            return q;
        }
        public static questions GetOneQuestion(int id)
        {
            questions singleq = db.Get<questions>(id);
            return singleq;
        }
        public static List<answers> GetSomeAnswers(int qid)
        {
            List<answers> a = db.Query<answers>($"select * from answers where qid = {qid} order by upvotes, posted desc").ToList();
            return a;
        }
        public static void CreateQ(questions q)
        {
            db.Insert<questions>(q);
        }
    }
}
