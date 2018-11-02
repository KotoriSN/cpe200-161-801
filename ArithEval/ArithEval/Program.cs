using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithEval
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = System.Console.ReadLine();
            Parser p = new Parser(new NodeFactory());
            Expr e = p.Parse(s);
            System.Console.WriteLine(e.ToString());
            // Partially verify that parsing output gives the same object.
            System.Console.WriteLine(p.Parse(e.ToString()).ToString());
        }
    }
}
