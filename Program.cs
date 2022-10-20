namespace DataStructureProgramStackAndQueue
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Programs");
           LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            
            queue.Display();
            queue.Dequeu();
            Console.WriteLine("After Dequeue");
            queue.Display();
        
        }
    }
}