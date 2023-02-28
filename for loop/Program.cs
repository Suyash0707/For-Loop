

using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class program
{
    public static void Main()
    {
        pattern1();
        pattern2();
        pattern3();
        pattern4();
        pattern5();
 
        static void pattern1()
        {
            Console.WriteLine("Display 1-10 numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        static void pattern2()
        {
            Console.WriteLine("Display 10-1 numbers");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        static void pattern3()
        {
            Console.WriteLine("Display 0-10 numbers by +2");
            for (int i = 0; i <=10; i = i + 2) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        static void pattern4()
        {
            Console.WriteLine("Display 10-0 numbers by -2");
            for (int i = 10; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        static void pattern5()
        {
            Console.WriteLine("Display suyash 5 times");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("suyash");
            }

        }
    }
}
