using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot
{
    public class SimpleBotUser
    {
        public static string Reply(Message message)
        {
            return $"{message.User} disse '{message.Text}' hoje às {DateTime.Now}";
        }

        public static UserProfile GetProfile(string id)
        {
            return null;
        }

        public static void SetProfile(string id, UserProfile profile)
        {
        }
    }
}