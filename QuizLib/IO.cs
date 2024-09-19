using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class IO
    {
        public static string InputString()
        {
            string response = Console.ReadLine() ?? "";
            return response;
        }
        public static char InputChar()
        {
            char response;
            while (!char.TryParse(Console.ReadLine(), out response))
            {
                Console.Write("Try again: ");
            }

            return response;
        }
        public static int InputInt()
        {
            int response;

            while (!int.TryParse(InputString(), out response))
            {
                Console.Write("Try again: ");
            }
            return response;
        }
        public static void OutPut(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void OutPutShort(string msg)
        {
            Console.Write(msg);
        }
        public static void OutPut(int number)
        {
            Console.WriteLine(number);
        }
        public static void OutPutShort(int number)
        {
            Console.Write(number);
        }
        public static void OutPut(char msg)
        {
            Console.WriteLine(msg);
        }
        public static void OutPutShort(char msg)
        {
            Console.Write(msg);
        }
    }
}
