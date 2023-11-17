using System.Diagnostics;
using System.Threading;

namespace Timer_Beispiel
{
    internal class VideoPost : Post
    {
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        protected bool isPlaying;
        protected int currDuration = 0;
        Timer timer;

        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, string videoURL, bool isPublic, int length)
        {
            ID = GetNextID();
            Title = title;
            SendByUserName = sendByUserName;
            VideoURL = videoURL;
            IsPublic = isPublic;
            Length = length;
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {VideoURL} - {Title} - {Length} Sek. - von {SendByUserName}");
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Spielt Video ab.");
                timer = new Timer(MyTimerCallBack, null, 0, 1000);
            }
        }

        private void MyTimerCallBack(object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video ist bei {0}", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Angehealten bei {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }
    }
}
