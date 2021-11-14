using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int a = int.Parse(Console.ReadLine());
            Queue queue = new Queue();
            for (int i = 1; i <= a; i++)
                queue.Enqueue(i);
            Console.WriteLine("Размерность очереди " + queue.Count);

            Console.WriteLine("Верхний элемент очереди = " + queue.Peek());
            Console.WriteLine("Размерность очереди " + queue.Count);

            Console.Write("Содержимое очереди = ");
            while (queue.Count != 0)
                Console.Write("{0} ", queue.Dequeue());
            Console.WriteLine("\nНовая размерность очереди " + queue.Count);
            Console.Read();
        }
    }
}
