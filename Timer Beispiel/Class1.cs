using System.Threading;

namespace Timer_Beispiel
{
    public class Class1
    {
        int currDuration = 10;

        public Class1()
        {
            Timer timer = new(MyTimerCallback, null, 0, 1000);
        }

        void MyTimerCallback(object o)
        {
            switch (currDuration)
            {
                case >= 0:
                    Console.WriteLine(currDuration);
                    GC.Collect();
                    currDuration--;
                    break;
                default:
                    Console.WriteLine("Verkackt");
                    break;
            }
            Console.ReadKey();

        }
    }
}
