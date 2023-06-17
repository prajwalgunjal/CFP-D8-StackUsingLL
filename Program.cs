namespace StackUsingLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int> ();
            stack.add (1);
            stack.add (2);
            stack.add (3);
            stack.add (4);
            stack.add (5);
            stack.add (6);
            stack.add (7);
            stack.Display();
            Console.WriteLine();
            stack.pop();
            stack.Display();
            Console.WriteLine();
            stack.isEmpty ();

        }
    }
}