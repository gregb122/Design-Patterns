using Interpreter.src;
using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context con = new Context();
            con.SetValue("q", false);
            AbstractExpression exp = new And(new Or(new Var(true), new Var(false)), new Neg(new Var("q")));
            AbstractExpression exp1 = new And(new Or(new Var(true), new Var(false)), new Neg(new Var(true)));
            AbstractExpression exp2 = new And(new Or(new Var(true), new Var(false)), new Neg(new Var("n")));


            Console.WriteLine(exp.Interpret(con));
            Console.WriteLine(exp1.Interpret(con));
            Console.WriteLine(exp2.Interpret(con));


        }
    }
}
