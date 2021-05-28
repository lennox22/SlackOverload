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
        public static string loginerror;
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
            List<answers> a = db.Query<answers>($"select * from answers where qid = {qid} order by upvotes desc, posted desc").ToList();
            return a;
        }
        public static void CreateQ(questions q)
        {
            db.Insert<questions>(q);
        }
        public static answers GetOneAnswer(int id)
        {
            return db.Get<answers>(id);
        }
        public static int UpvoteA(int id)
        {
            answers a = GetOneAnswer(id);
            a.upvotes++;
            db.Update<answers>(a);
            return a.qid;
        }
        public static void DeleteQ(questions q)
        {
            db.Delete<questions>(q);
        }
        public static void CloseQ(questions q)
        {
            q.status = 1;
            db.Update<questions>(q);
        }
        public static void OpenQ(questions q)
        {
            q.status = 0;
            db.Update<questions>(q);
        }
        public static void EditQ(questions q)
        {
            db.Update<questions>(q);
        }
        public static void CreateA(answers a)
        {
            db.Insert<answers>(a);
        }
        public static void EditA(answers a)
        {
            db.Update<answers>(a);
        }
        public static void DeleteA(answers a)
        {
            db.Delete<answers>(a);
        }
    }
}
