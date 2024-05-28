namespace Hangman
{
    internal class Program
    {

        static String[] Pics = [@"  +---+
  |   |
      |
      |
      |
      |
=========", @"  +---+
  |   |
  O   |
      |
      |
      |
=========", @"  +---+
  |   |
  O   |
  |   |
      |
      |
=========", @"  +---+
  |   |
  O   |
 /|   |
      |
      |
=========", @"  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========", @"  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========", @"  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="];

        static String allWords = "ant baboon badger bat bear beaver camel cat clam cobra cougar coyote crow deer dog donkey duck eagle ferret fox frog goat goose hawk lion lizard llama mole monkey moose mouse mule newt otter owl panda parrot pigeon python rabbit ram rat raven rhino salmon seal shark sheep skunk sloth snake spider stork swan tiger toad trout turkey turtle weasel whale wolfwombat zebra";
        static String[] words = allWords.Split(new char[] { ' ' });

        static void Main(string[] args)
        {
            GameObj game = new GameObj(Pics, words);
            game.gameLoop();
            
        }

    }
}
