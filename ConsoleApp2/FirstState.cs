using System;

namespace ConsoleApp2
{
    internal class FirstState : IState
    {
        private Context context;

        public FirstState(Context context)
        {
            this.context = context;
            context.x = 0;
        }

        public void Digit(string key)
        {
            var result = int.Parse(key);
            context.x = context.x * 10 + result;
        }

        public void Equal()
        {
            context.ChangeState(new ResultState(context));
            context.Equal();
        }

        public void Operation(string key)
        {            
            context.ChangeState(new OperationState(context));
            context.Operation(key);
        }

        public string Screen()
        {
            return context.x.ToString();
        }
    }
}