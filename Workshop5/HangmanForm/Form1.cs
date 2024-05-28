using Hangman;

namespace HangmanForm
{
    public partial class Form1 : Form
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

        bool loss = false;

        static String allWords = "ant baboon badger bat bear beaver camel cat clam cobra cougar coyote crow deer dog donkey duck eagle ferret fox frog goat goose hawk lion lizard llama mole monkey moose mouse mule newt otter owl panda parrot pigeon python rabbit ram rat raven rhino salmon seal shark sheep skunk sloth snake spider stork swan tiger toad trout turkey turtle weasel whale wolfwombat zebra";
        static String[] words = allWords.Split(new char[] { ' ' });
        GameObj game;
        public Form1()
        {
            InitializeComponent();
            game = new GameObj(words);
            lblCurrent.Text = "";
            lblPic.Text = "";
            lblWin.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputS = LetterBox.Text.ToString().ToLower();
            if (inputS == "")
            {
                return;
            }

            if (loss)
            {
                lblWin.Text = "You Lose";
                LetterBox.Text = "";
                return;
            }

            char input = inputS[0];
            int state = game.nextState(input);

            if (state == 0)
            {
                lblWin.Text = "You Win Congradulations !!!!";
                LetterBox.Text = "";
                return;
            }
            if (state == 2)
            {
                lblPic.Text = Pics[game.guesses];
                LetterBox.Text = "";
                return;
            }
            if (state == 3)
            {
                lblWin.Text = "You Lose";
                lblPic.Text = Pics[game.guesses];
                loss = true;
                LetterBox.Text = "";
                return;
            }

            lblCurrent.Text = game.returnCurrent();
            LetterBox.Text = "";


        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            game = new GameObj(words);
            lblCurrent.Text = "";
            lblPic.Text = "";
            lblWin.Text = "";
        }
    }
}
