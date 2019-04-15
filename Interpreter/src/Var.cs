using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.src
{
    class Var : AbstractExpression
    {
        public string Varriable { get; set; }
        public bool Value { get; private set; }
        public Var(bool val)
        {
            this.Value = val;
        }
        public Var(string var)
        {
            this.Varriable = var;
        }

        public override bool Interpret(Context context)
        {
            if (Varriable == null)
            {
                return Value;
            }
            return context.GetValue(Varriable);
        }
    }
}
