using System;

namespace ConsoleApp2
{
    internal class ResultState : IState
    {
        private Context context;        

        public ResultState(Context context)
        {
            this.context = context;
        }

        public void Digit(string key)
        {
            context.ChangeState(new FirstState(context));
            context.Digit(key);
        }

        public void Equal()
        {
            int x = context.x;
            int y = context.y;
            switch (context.operation)
            {
                case "+": context.x = x + y; break;
                case "-": context.x = x - y; break;
                case "*": context.x = x * y; break;
                case "/": if (y != 0) context.x = x / y; break;
            }
        }

        public void Operation(string key)
        {
            Equal();
            context.ChangeState(new OperationState(context));
            context.Operation(key);
        }

        public string Screen()
        {
            return $"= {context.x}";
        }
    }
}