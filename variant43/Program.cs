using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace variant43
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("D:/Users/Denta/Desktop/lab1/variant43/INPUT.txt");
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
            {
                lines.Add(sr.ReadLine());
            }
            sr.Close();

            int n = Convert.ToInt32(lines[0]);

            List<int> a = new List<int>();
            foreach (var item in lines[1].Split(" "))
            {
                a.Add(Convert.ToInt32(item));
            }

            List<int> b = new List<int>();
            foreach (var item in lines[2].Split(" "))
            {
                b.Add(Convert.ToInt32(item));
            }

            List<DoubleInt> x = new List<DoubleInt>();

            for (int i = 0; i < a.Count; i++)
            {
                x.Add(new DoubleInt { int1 = a[i] + b[i], int2 = i });
            }

            int k = a.Sum();
            int c = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if(b[i] - (k - a[i]) <= 0)
                {
                    c += 1;
                }
            }

            x.OrderBy(item => item);
            x.Reverse();
            string result = String.Empty;
            if (c != n)
            {
                foreach (var item in x)
                {
                    result += item.int2 + 1 + " ";
                }
            }
            else
            {
                result = "-1";
            }

            using (StreamWriter sw = new StreamWriter("D:/Users/Denta/Desktop/lab1/variant43/OUTPUT.txt"))
            {
                sw.WriteLine(result);
            }
        }
    }
    public class DoubleInt
    {
        public int int1 { get; set; }
        public int int2 { get; set; }
    }
}
