using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            foreach (int x in arr)
            {
                arr[x] = 0;
            }
            int checkout = 0;//рандомятся числа до того момента, пока не введем -1
            while (checkout != -1)
            {
                int k = rnd.Next(1, n);
                arr[k]++;
                checkout = int.Parse(Console.ReadLine());
            }
            //сортировка 
            int temp;
            for (int r = 0; r < arr.Length; r++)
            {
                for (int o = r + 1; o < arr.Length; o++)
                {
                    if (arr[r] > arr[o])
                    {
                        temp = arr[r];
                        arr[r] = arr[o];
                        arr[o] = temp;
                    }
                }
            }
            foreach (int x in arr)
            {
                Console.WriteLine(arr[x]);
            }
            Console.ReadKey();
        }
    }
}
