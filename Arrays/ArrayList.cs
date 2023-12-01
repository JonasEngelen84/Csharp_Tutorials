namespace Arrays
{
    class ArrayList
    {
        public static void Ausgabe()
        {
            System.Collections.ArrayList myArrayList = new System.Collections.ArrayList();
            myArrayList.Add(250);
            myArrayList.Add("string");
            myArrayList.Add(66.666f);
            myArrayList.Add(Number.i);
            myArrayList.RemoveAt(0);

            foreach (var i in myArrayList)
            {
                System.Console.WriteLine(i);
            }
        }
    }

    class Number
    {
        public static double i = 5.654;
    }
}
