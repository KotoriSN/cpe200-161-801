using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithEval
{
    interface INodeFactory
    {
        Expr Number(int n);

        Expr Add(Expr e1, Expr e2);

        Expr Subtract(Expr e1, Expr e2);

        Expr Multiply(Expr e1, Expr e2);

        Expr Negate(Expr e1);
    }
}
