using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while(true)
        {
            string Input = Console.ReadLine();
            if (Input == "-") break;

            int num = Input.Length;
            int m = int.Parse(Console.ReadLine());
            int[] h1 = new int[m];
            int[] h2 = new int[m];

            for(int i = 0; i < m; i++)
            {
                h1[i] = int.Parse(Console.ReadLine());
            }

            string s1 = Input.Substring(0, h1[0]);
            string s2 = Input.Substring(h1[0]);
            string ans = s2 + s1;
            for (int i = 1; i < m; i++)
            {
                s1 = ans.Substring(0, h1[i]);
                s2 = ans.Substring(h1[i]);
                ans = "";
                ans += s2 + s1;
            }
            Console.WriteLine(ans);
        }
    }
}