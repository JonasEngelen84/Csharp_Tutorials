using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer_Beispiel
{
    public class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUserName = sendByUserName;
            IsPublic = isPublic;
            ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {ImageURL} - {Title} - von {SendByUserName}");
        }
    }
}
