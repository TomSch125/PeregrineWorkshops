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
                string input = Console.ReadLine().ToLower();
                checkTarget(input);
                if (!current.Contains('?')) {
                    Console.WriteLine("Word Found !!!!!");
                    return;
                }

                printHangman();

                guesses++;
            }

            Console.WriteLine("Failed to find the word");


        }

        private void checkTarget(string guess)
        {
            if (guess.Length > target.Length) {
                guess = guess.Substring(0, target.Length);
            }

            char[] targetChrs = target.ToCharArray();
            char[] guessChrs = guess.ToCharArray();
            for (int i = 0; i < guessChrs.Length; i++) { 
                if (targetChrs[i] == guessChrs[i]) {
                    current[i] = guessChrs[i];
                }
            }

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
