using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLower('z'));
            Console.WriteLine(IsUpper('Z'));
            Console.WriteLine(ToUpper('b'));
            Console.WriteLine(ToLower('B'));
            Print_a_2_z_v1();
            Print_a_2_z_v2();
            Print_a_2_z_v3();
            {
                while(true)
                {
                    char c = Console.ReadKey().KeyChar;
                    Console.WriteLine(Char2code(c));
                }   
            }
            
            
        }
        public static void Print_a_2_z_v1()
        {
            char c = ' ';
            for(int i = 97 ; i < 122;i++)
            {
                c = (char)i;
                Console.Write(c);
            }
        }
        public static void Print_a_2_z_v2()
        {
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                Console.Write(c);
                c++;
            }
        }
        public static void Print_a_2_z_v3()
        {
            String s = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < 26; i++)
            {
                Console.Write(s[i]);
                
            }
        }

        public static int Char2code(char c)
        {
            return (int)c;
        }
        public static bool IsUpper(char c)
        {
            
            for (int i = 65; i <= 90; i++)
            {
                if(Char2code(c) == i)
                   return true;
            }
            return false;
        }
        public static bool IsLower(char c)
        {
            for (int i = 97; i <= 122; i++)
            {
                if (Char2code(c) == i)
                    return true;
            }
            return false;
        }
        public static char ToUpper(char c)
        {
            int a = Char2code(c);
            a = a - 32;
            c = (char)a;
            return c;
        }
        public static char ToLower(char c)
        {
            int a = Char2code(c);
            a = a + 32;
            c = (char)a;
            return c;
        }
        
    }
}
