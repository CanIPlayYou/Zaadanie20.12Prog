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
            private List<int> lista;

            public IntegerQueue()
            {
                lista = new List<int>();
            }

            public int getFirst()
            {
                return lista[0];
            }

            public void addLast(int value)
            {
                lista.Add(value);
            }

            public override string ToString()
            {
                return string.Join(", ", lista);
            }
        }
        static void Main(string[] args)
        {
            IntegerQueue lst = new IntegerQueue();

            lst.addLast(2);
            lst.addLast(231);
            lst.addLast(41);

            Console.WriteLine("Elementy w liście: " + lst.ToString());

            int pierwEle = lst.getFirst();
            Console.WriteLine("Pierwszy element w liście: " + pierwEle);

            Console.ReadKey();
        }
    }
}
