namespace Linked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedList <int> my_list =new LinkedList<int>();
            my_list.AddLast(1);
            my_list.AddLast(2);
            my_list.AddLast(3);
            my_list.AddLast(4);
            my_list.AddLast(5);
            my_list.AddLast(6);

            Console.WriteLine("Numbers in list are: ");

            foreach (int i in my_list)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            // remove first
            my_list.Remove(my_list.First);
            foreach (int i in my_list)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();


            // clear
            my_list.Clear();

            my_list.AddLast(1);
            my_list.AddLast(2);
            my_list.AddLast(4);
            my_list.AddLast(3);
            my_list.AddLast(4);


            foreach (int i in my_list)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            // contains
            Console.WriteLine("Does the list contain 1: {0}", my_list.Contains(1));

            // find
            object node4 = my_list.Find(4);
            object nodeLast4 = my_list.FindLast(4);
            Console.WriteLine("The last node in an {0}", nodeLast4.GetType());


        }
    }
}
