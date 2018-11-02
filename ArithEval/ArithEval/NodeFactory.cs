using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithEval
{
    class NodeFactory : INodeFactory
    {
        public Expr Add(Expr e1, Expr e2)
        {
            return new AllExpr(1, e1, e2);
        }

        public Expr Multiply(Expr e1, Expr e2)
        {
            return new AllExpr(3, e1, e2);
        }

        public Expr Negate(Expr e1)
        {
            return new AllExpr(-1, e1);
        }

        public Expr Number(int n)
        {
            return new AllExpr(n);
        }

        public Expr Subtract(Expr e1, Expr e2)
        {
            return new AllExpr(2, e1, e2);
        }
    }
}
