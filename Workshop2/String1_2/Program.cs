namespace String1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(makeOutWord("<<>>", "Yay"));

        }

        static private string makeOutWord(string modifier, string input) {
            string l = modifier.Substring(0, (int)modifier.Length/2);
            string r = modifier.Substring((int)modifier.Length / 2, modifier.Length-2);

            return l+ input + r;
        }
    }
}
