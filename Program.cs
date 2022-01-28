using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Ex1
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            char ch = s[12];
            Console.WriteLine(ch);
        }
    }
    class Ex2
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            if (s.Contains("is") == true)
            {
                Console.WriteLine("word found!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }
    class Ex3
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            string s1 = "and killed it";
            string s2 = string.Concat(s, s1);
            Console.WriteLine(s2);
        }
    }
    class Ex4
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            if (s.EndsWith("dog") == true)
            {
                Console.WriteLine(s);
            }
        }
    }
    class Ex5
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            if (s.Equals("The quick brown Fox jumps over the lazy dog") == true)
            {
                Console.WriteLine("It's a match");
            }
            else
            {
                Console.WriteLine("Nooo!");
            }
        }
    }
    class Ex6
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            if (s.Equals("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG") == true)
            {
                Console.WriteLine("Yess!");
            }
            else
            {
                Console.WriteLine("Noo!");
            }
        }
    }
    class Ex7
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("Length of string is: " + s.Length);
        }
    }
    class Ex8
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            string s1 = "The quick brown Fox jumps over the lazy dog";
            Console.WriteLine(s.Contains(s1));
        }
    }
    class Ex9
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            s = s.Replace("The", "A");
            Console.WriteLine(s);
        }
    }
    class Ex10
    {
        static void Main(string[] args)
        {
            string s = "The quick brown   fox   jumps over the lazy dog";
            string[] words = s.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
    class Ex11
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                if (word.Contains("fox") || word.Contains("dog") == true)
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadKey();
        }
    }
    class Ex12
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            string lower_s = s.ToLower();
            Console.WriteLine(lower_s);
        }
    }
    class Ex13
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            string upper_s = s.ToUpper();
            Console.WriteLine(upper_s);
        }
    }
    class Ex14
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            int index = s.IndexOf("a");
            Console.WriteLine("The index of 'a' is:" + index);
        }
    }
    class Ex15
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            int index = s.LastIndexOf('e');
            Console.WriteLine("The index of 'e' is:" + index);
            Console.ReadKey();
        }
    }
    class Ex16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the home directory of tomcat");
            string s = Console.ReadLine();
            string s1 = "WebApps/MyApps/Images";
            string s2 = string.Concat(s, s1);
            Console.WriteLine(s2);

        }
    }
    class Ex17
    {
        static void Main(string[] args)
        {
            string s = "I WANDER'D lonely as a cloud\n That floats on high o'er vales and hills,\nWhen all at once I saw a crowd,\nA host, of golden daffodils; Beside the lake, beneath the trees,\nFluttering and dancing in the breeze.";
            Console.WriteLine(s);
        }

    }
    class Ex18
    {
        static void Main(string[] args)
        {
            string s = "I WANDER'D lonely as a cloud   That floats on high o'er vales and hills,  When all at once I saw a crowd,   A host, of golden daffodils; Beside the lake, beneath the trees,  Fluttering and dancing in the breeze.";
            string[] str = s.Split(' ');
            foreach(string k in str)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }

    }

}
