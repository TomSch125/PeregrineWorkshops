namespace String3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(countYZ("day fyyyz"));

        }

        static private int countYZ(string input) { 
            if (input == null) { return 0; }
            if (input.Length == 0) {  return 0; }

            int count = 0;

            List <char[]> words = new List<char[]>();
            string cur = "";

            char[] chars = input.ToLower().ToCharArray();
            char c;

            for (int i = 0; i < chars.Length; i++) {
                c = chars[i];
                if (97 <= c && c <= 122)
                {
                    cur = cur + c;
                    if (i == chars.Length - 1) {
                        words.Add(cur.ToCharArray());
                    }

                }
                else
                {
                    words.Add(cur.ToCharArray());
                    cur = "";
                }
            }

            foreach (char[] word in words) {
                if (word[word.Length - 1] == 'y' || word[word.Length - 1] == 'z') {
                    count++;
                }
            }

            return count;

        }
    }
}
