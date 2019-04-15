using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.src
{
    abstract class AbstractExpression
    {
        public abstract bool Interpret(Context context);
    }
}
