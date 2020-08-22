using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Context : IState
    {
        private IState state;
        internal int x, y;
        internal string operation;

        public Context()
        {
            Clear();
        }

        public void Clear()
        {
            state = new FirstState(this);
            x = 0;
            y = 0;
            operation = "";
        }

        public void Digit(string key)
        {
            state.Digit(key);
        }

        public void Equal()
        {
            state.Equal();
        }

        public void Operation(string key)
        {
            state.Operation(key);
        }

        public string Screen()
        {            
            return $"{((x == 0) ? "" : x.ToString())} {((operation == "") ? "" : operation)} {((y == 0) ? "" : y.ToString())}" +
            $" \n\r{ ((state.Screen() == "0") ? "" : "Результат: " + state.Screen())}";
        }

        public void ChangeState(IState state)
        {
            this.state = state;
        }
    }
}
