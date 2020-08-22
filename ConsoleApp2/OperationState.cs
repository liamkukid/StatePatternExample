namespace ConsoleApp2
{
    internal class OperationState : IState
    {
        Context context;
        public OperationState(Context context)
        {
            this.context = context;
            context.operation = "";
        }

        public void Digit(string key)
        {
            context.ChangeState(new SecondState(context));
            context.Digit(key);
        }

        public void Equal()
        {            
            context.y = context.x;
            context.ChangeState(new ResultState(context));
            context.Equal();
        }

        public void Operation(string key)
        {
            context.operation = key;
        }

        public string Screen()
        {
            return $"{context.x} {context.operation}";
        }
    }
}