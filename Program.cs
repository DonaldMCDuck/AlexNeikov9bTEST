using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexNeikov9bTEST
{
    class Program
    {
        static void Vuvejdane()
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str);
        }
        static bool IsPalindrome(string value)
        {
            int i = 0;
            int j = value.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = value[i];
                char b = value[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }
        static void Main(string[] args)
        {
            //Za kapak, predi godini grupa ABBA specheli Evroviziq.
            Vuvejdane();
            IsPalindrome();
            Console.ReadKey();
        }
    }
}
