using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listIndex = new List<int>();
            int sum = 0; ;
            Random random = new Random();
            int minSize = 5, maxSize = 20;
            int size = random.Next(minSize, maxSize);
            int min = -50, max = 50;
            List<int> list = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(min, max));
                Console.Write(list[i] + " , ");
                if (i % 2 == 0) sum += list[i];
            }
            Console.WriteLine();
            max =min;
            foreach (int p in list)
            {
                if (p > max) max = p;
            }
            int max2 = min;
            foreach (int p in list)
            {
                if (p > max2 && p != max) max2 = p;
            }           
            for (int i = 0; i < size; i++)
            {
                if (list[i] == max2)
                {
                    listIndex.Add(i);
                }
            }
            Console.WriteLine("второе максимальное число: "+max2);
            Console.WriteLine("индексы: ");
            foreach(int p in listIndex)
            {
                Console.Write(p + " , ");
            }
            Console.WriteLine("\n"+"сумма элементов четных позициях = "+sum);

        }
    }
}
