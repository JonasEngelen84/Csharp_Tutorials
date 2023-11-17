using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer_Beispiel
{
    public class Post
    {
        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "Mein erster Post";
            IsPublic = true;
            SendByUserName = "Jonas Engelen";
        }

        public Post(string title, string sendByUserName, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUserName = sendByUserName;
            IsPublic = isPublic;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        protected static int GetNextID()
        {
            return ++currentPostId;
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - von {SendByUserName}");
        }
    }
}
