namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LinkedList LList = new LinkedList();
            LList.AddHead(1);
            LList.AddHead(6);
            LList.AddHead(3);
            LList.AddHead(4);
            LList.AddHead(6);
            LList.AddHead(6);
            Console.WriteLine($"Size : { LList.Size()}");
            Console.WriteLine($"Size : {LList.FindLength()}");
            Console.WriteLine($"Is Empty : {LList.IsEmpty()}");
            Console.WriteLine($"Peek : {LList.Peek()}");
            LList.AddTail(0);
            LList.Print();
            LList.Reverse();
            LList.Print();
            LList.RemoveDuplicate();
            LList.Print();
            Console.WriteLine($"Size : {LList.Size()}");
            Console.WriteLine($"Size : {LList.FindLength()}");
            LList.AddHead(4);
            LList.AddHead(8);
            LList.AddHead(11);
            LList.Print();
            LList.BubbleSort();
            LList.Print();
            Console.WriteLine($"Val at index 0 : {LList.NthNodeFromBeginning(0)}");
            Console.WriteLine($"Val at index 2 : {LList.NthNodeFromBeginning(2)}");
            Console.WriteLine($"Val at index last : {LList.NthNodeFromEnd(0)}");
            Console.WriteLine($"Val at index last-2 : {LList.NthNodeFromEnd(2)}");
        }
    }
}
