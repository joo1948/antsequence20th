using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1";
            int n = 1;
            while (n <= 20)
            {
                Console.WriteLine(n + "번째 수열: " + s);
                char cut = s[0];
                int count = 0;
                string s2 = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (cut == s[i])
                    {
                        if (cut == s[i]) count++;
                    }
                    else
                    {
                        s2 += "" + cut + count;
                        count = 0;
                        cut = s[i];
                        count++;
                    }
                    if (i + 1 == s.Length)
                        s2 += "" + cut + count;
                }
                s = s2;
                n++;
            }
        }
    }
}
