namespace DataStructureProgramStackAndQueue
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Programs");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            Console.WriteLine("\n-------------------------");
            stack.IsEmpty();
            stack.Display();
        }
    }
}