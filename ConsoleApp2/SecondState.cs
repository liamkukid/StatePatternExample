namespace ConsoleApp2
{
    internal class SecondState : IState
    {
        private Context context;

        public SecondState(Context context)
        {
            this.context = context;
            context.y = 0;
        }

        public void Digit(string key)
        {
            var result = int.Parse(key);
            context.y = context.y * 10 + result;
        }

        public void Equal()
        {
            context.ChangeState(new ResultState(context));
            context.Equal();
        }

        public void Operation(string key)
        {
            context.ChangeState(new ResultState(context));
            context.Operation(key);
        }

        public string Screen()
        {
            return $"{context.x} {context.operation} {context.y}";
        }
    }
}