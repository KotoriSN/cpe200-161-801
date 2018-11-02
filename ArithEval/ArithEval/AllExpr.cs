using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithEval
{
    class AllExpr : Expr
    {
        int exprType;
        Expr e1;
        Expr e2;

        int memory;

        public AllExpr(int n)
        {
            memory = n;
        }

        public AllExpr(int exprType, Expr e1)
        {
            this.exprType = exprType;
            this.e1 = e1;
        }

        public AllExpr(int exprType, Expr e1, Expr e2)
        {
            this.exprType = exprType;
            this.e1 = e1;
            this.e2 = e2;
        }

        public string ToString()
        {
            if (exprType == 0) return memory.ToString();
            else if (exprType == -1) return "-" + e1.ToString();
            string result = e1.ToString();
            switch (exprType)
            {
                case 1:
                    result += " + ";
                    break;
                case 2:
                    result += " - ";
                    break;
                case 3:
                    result += " * ";
                    break;
                case 4:
                    result += " / ";
                    break;
            }
            result += e2.ToString();
            return "(" + result + ")";
        }
    }
}
