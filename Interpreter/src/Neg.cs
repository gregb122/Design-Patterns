using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.src
{
    class Neg : AbstractExpression
    {
        public AbstractExpression Expression { get; private set; }

        public Neg(AbstractExpression exp)
        {
            this.Expression = exp;
        }
        public override bool Interpret(Context context)
        {
            return !Expression.Interpret(context);
        }
    }
}
