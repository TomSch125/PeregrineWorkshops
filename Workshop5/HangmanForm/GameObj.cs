using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class GameObj
    {
        private String[] Words;
        private string target;
        public int guesses;
        public List<char> current = new List<char>();

        public GameObj( string[] words)
        {
            Words = words;
            Random rnd = new Random();
            this.target = words[rnd.Next(1, words.Length)];
            this.guesses = 0;
            for (int i = 0; i < target.Length; i++)
            {
                current.Add('?');
            }
        }

        public int nextState(char input) {

            bool found = checkTarget(input);
            if (!current.Contains('?'))
            {
                return 0;
            }

            if (!found)
            {
                guesses++;
                if (guesses == 6) {
                    return 3;
                }
                return 2;
            }

            return 1; 
        }

        private bool checkTarget(char guess)
        {
            bool found = false;
            char[] targetChrs = target.ToCharArray();
            for (int i = 0; i < target.Length; i++) { 
                if (targetChrs[i] == guess) {
                    current[i] = guess;
                    found = true;
                }
            }

            return found;
        }
        public string returnCurrent()
        {
            string res = "";
            foreach (char c in current)
            {
                if (c == '?')
                {
                    res = res + '_';
                }
                else {
                    res = res + c;
                }
                res = res + ' ';
            }

            return res;
        }


    }
}
