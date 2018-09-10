using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03b
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            string txt = "2;55;34;2;6;77;64;64;12;45;67;8";

            Console.WriteLine($"Gennemsnitsløn: {calculateGennemsnit(månedsløn)}");

            Console.ReadLine();

            string[] splittedArr = splitArr(txt);
            
            int sum = 0;

            for (int i = 0; i < splittedArr.Length; i++)
            {
                int tal = Convert.ToInt32(splittedArr[i]);
                sum += tal;
            }

            Console.WriteLine($"Sum of converted string array is: {sum}");

            Console.ReadLine();
        }

        

        static double calculateGennemsnit(int[] arr)
        {
            double sum = 0;
            int amount = arr.Length;
            for (int i = 0; i < amount; i++)
            {
                sum += arr[i];
            }

            return sum / amount;

        }

        static string[] splitArr(string arr)
        {
            return arr.Split(';');
        }


    }
}
