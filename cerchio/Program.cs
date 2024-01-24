using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire raggio");
            float r=float.Parse(Console.ReadLine());
            Cerchio c = new Cerchio(r);

            Console.WriteLine("area={0} e perimetro={1}", c.Area(), c.Perimetro());

            Console.ReadLine();
        }
    }
}
