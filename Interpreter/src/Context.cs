using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.src
{
    class Context
    {
        Dictionary<string, bool> eval = new Dictionary<string,bool>();
        public bool GetValue(string variableName)
        {
            return eval[variableName];
        }

        public void SetValue(string variableName, bool Value)
        {
            eval.Add(variableName, Value);
        }
    }
}
