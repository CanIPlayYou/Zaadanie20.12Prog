using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal class Program
    {
        public class IntegerQueue
        {
            private LinkedList<int> lista;  //Używam LinkedList bo taka lista przechowuje wskaźniki do następnych elementów

            public IntegerQueue()
            {
                lista = new LinkedList<int>();
            }

            public int getFirst()
            {
                return lista.First.Value;
            }

            public void addLast(int value)
            {
                lista.AddLast(value);
            }

            public override string ToString()
            {
                return string.Join(" ", lista);
            }
        }

        static void Main(string[] args)
        {
            IntegerQueue lst = new IntegerQueue();

            lst.addLast(5);
            lst.addLast(10);
            lst.addLast(15);

            Console.WriteLine("Elementy kolejki: " + lst.ToString());

            int pierwEle = lst.getFirst();
            Console.WriteLine("Pierwszy element: " + pierwEle);

            Console.ReadKey();
        }
    }
}
