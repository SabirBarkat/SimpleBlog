using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class UserRepository
    {
        public static IEnumerable<User> Retrieve()
        {
            var result = new List<User>();
            using(var ctx=new SimpleBlogContext())
            {
                result = ctx.UserSet.ToList();
            }
            return result;
        }

        public static bool UserExists(string username)
        {
            bool result = false;
            using(var ctx=new SimpleBlogContext())
            {
                result = ctx.UserSet.Any(x => x.Username == username);
            }
            return result;
        }

        public static bool Save(User user)
        {
            bool result = false;
            using(var ctx = new SimpleBlogContext())
            {
                ctx.UserSet.Add(user);
                ctx.SaveChanges();
                result = true;
            }
            return result;
        }
    } // class
}