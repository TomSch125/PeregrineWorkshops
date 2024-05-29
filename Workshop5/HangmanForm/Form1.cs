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



        static String allWords = "ant baboon badger bat bear beaver camel cat clam cobra cougar coyote crow deer dog donkey duck eagle ferret fox frog goat goose hawk lion lizard llama mole monkey moose mouse mule newt otter owl panda parrot pigeon python rabbit ram rat raven rhino salmon seal shark sheep skunk sloth snake spider stork swan tiger toad trout turkey turtle weasel whale wolfwombat zebra";
        static String[] words = allWords.Split(new char[] { ' ' });
        GameObj game;
        public Form1()
        {
            InitializeComponent();
            populateWords();
            game = new GameObj(words);
            lblCurrent.Text = "";
            lblPic.Text = "";
            lblWin.Text = "";
            lblCurrent.Text = game.returnCurrent();
        }

        public void populateWords()
        {

            try
            {
                string contents = "";
                string path = @"Words.txt";
                string filename = Path.GetFileName(path);
                using (var sr = new StreamReader(path))
                {
                    contents = sr.ReadToEnd();
                }
                contents = contents.Replace("\r\n", "\n").ToLower();
                words = contents.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
                Console.WriteLine("Default words used");

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputS = LetterBox.Text.ToString().ToLower();
            if (inputS == "")
            {
                return;
            }

            if (game.loss)
            {
                lblWin.Text = "You Lose";
                LetterBox.Text = "";
                return;
            }

            char input = inputS[0];
            int state = game.nextState(input);

            if (state == 0)
            {
                lblWin.Text = "You Win!";
                LetterBox.Text = "";
            }
            if (state == 2)
            {
                lblPic.Text = Pics[game.guesses];

                string used = "Used:";
                foreach (char c in game.used)
                {
                    used = used + "\n- "+ c;
                }

                lblUsed.Text = "";
                lblUsed.Text = used;
                LetterBox.Text = "";
            }
            if (state == 3)
            {
                lblWin.Text = "You Lose!";
                lblPic.Text = Pics[game.guesses];
                //game.loss = true;
                LetterBox.Text = "";
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPic_Click(object sender, EventArgs e)
        {

        }

        private void LetterBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
