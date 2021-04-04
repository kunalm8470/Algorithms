namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push(4);
            stk.Push(5);

            int popped = stk.Pop();
        }
    }
}
