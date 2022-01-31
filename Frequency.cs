using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_assignment
{
    class Frequency
    {
        static void count_freq(String str)
        {
            SortedDictionary<String, int> s = new SortedDictionary<String, int>();
            String[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (s.ContainsKey(arr[i]))
                {
                    s[arr[i]] += 1;
                }
                else
                {
                    s.Add(arr[i], 1);
                }
            }
            foreach (KeyValuePair<String, int> entry in s)
            {
                Console.WriteLine(entry.Key + " - " +
                                  entry.Value);
            }
        }
        static void Main(string[] args)
        {
            String str = "DotNet is technology and DotNet is interoperable and DotNet is simple";
            count_freq(str);
            Console.ReadKey();
        }
    }
}
