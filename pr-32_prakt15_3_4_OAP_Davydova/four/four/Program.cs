using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace four
{
    class Program
    {
        public struct person
        {
            public string f;
            public string i;
            public string o;
            public int age;
            public float massa;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("t.txt");
            string str;
            Queue queue = new Queue();
            person a;
            Console.WriteLine("меньше 40");
            while ((str = sr.ReadLine()) != null)
            {
                string[] temp = str.Split(' '); 
                a.f = temp[0];
                a.i = temp[1];
                a.o = temp[2];
                a.age = int.Parse(temp[3]);
                a.massa = float.Parse(temp[4]);
                if (a.age < 40)
                    Console.WriteLine(a.f + "\t" + a.i + "\t" + a.o + "\t" + a.age + "\t" + a.massa);
                else queue.Enqueue(a);
            }
            sr.Close();

            Console.WriteLine("40 лет и выше");
            while (queue.Count != 0) 
            {
                a = (person)queue.Dequeue();
                Console.WriteLine(a.f + "\t" + a.i + "\t" + a.o + "\t" + a.age + "\t" + a.massa);
            }
            Console.Read();
        }
    }
}
