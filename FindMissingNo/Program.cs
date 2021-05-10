using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNo
{
    class Program
    {
        static int getMissingNo(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;
            for (int i = 0; i < n; i++)
                total -= a[i];
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Total number of input : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrint = new int[n];
            int[] a = { 1, 2, 3, 5, 6 };
            int miss = getMissingNo(a, 5);
            Console.Write(miss);
            Console.WriteLine("Press any key to exit ....");
            Console.ReadKey();            
        }
    }
}
