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
        String[] Pics;
        String[] Words;
        string target;
        int guesses = 0;
        List<char> current = new List<char>();

        public GameObj(string[] pics, string[] words)
        {
            Pics = pics;
            Words = words;
            Random rnd = new Random();
            this.target = words[rnd.Next(1, words.Length)];
            this.guesses = 0;
            for (int i = 0; i < target.Length; i++)
            {
                current.Add('?');
            }
        }

        public void gameLoop() {

            Console.WriteLine(target);

            while (guesses<7)
            {   
                printCurrent();
                Console.WriteLine("\ninput guess:");
                string inputS = Console.ReadLine().ToLower();
                char input = inputS[0];
                bool found = checkTarget(input);
                if (!current.Contains('?')) {
                    Console.WriteLine("Word Found !!!!!");
                    return;
                }

                if (!found) {
                    printHangman();
                    guesses++;
                }
            }

            Console.WriteLine("Failed to find the word");


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
        private void printCurrent()
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

            Console.WriteLine(res);
        }

        private void printHangman() {
            Console.WriteLine('\n'+Pics[guesses]);
        }
    }
}
