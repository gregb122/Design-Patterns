using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.src
{
    class And : AbstractExpression
    {
        public AbstractExpression LeftExpression { get; private set; }
        public AbstractExpression RightExpression { get; private set; }

        public And(AbstractExpression leftExp, AbstractExpression rigthExp)
        {
            this.LeftExpression = leftExp;
            this.RightExpression = rigthExp;
        }

        public override bool Interpret(Context context)
        {
            return LeftExpression.Interpret(context) && RightExpression.Interpret(context);
        }

    }
}
