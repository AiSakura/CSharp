using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            Style[] spec = new Style[n];
            
            spec[0] = new Style("<Narvik>,chest of drawers", 219, "Belarus", "JYSK", EnvironFr.Four, "Modern", 85, 13, 10, 10);
            spec[1] = new Style();
            Array.Sort(spec);
            for (int i = 0; i < n; i++)
            {
                try
                {
                    if (((ICustomerRating)spec[i]).PositiveFeedback < 0 || ((ICustomerRating)spec[i]).Quality < 0 )
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    spec[i].NotifyMark += mes => Console.ForegroundColor = ConsoleColor.Green;
                }
                try
                {
                    if (spec[i].checkFeedback() == "Yes" || spec[i].checkFeedback() == "Unknown")
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    spec[i].NotifyRetake += mes => Console.ForegroundColor = ConsoleColor.Red;
                }

                spec[i].NotifyMark += delegate (string mes)
                {
                    Console.WriteLine(mes);
                };
                spec[i].NotifyRetake += delegate (string mes)
                {
                    Console.WriteLine(mes);
                };
                spec[i].Print(i + 1);
            }
            Console.ReadKey();
        }
    }
}