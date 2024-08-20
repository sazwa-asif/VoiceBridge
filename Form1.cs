using System.Data.OleDb;
using System.Media;
using System.Windows.Forms;
using System;
using System.Speech.Synthesis;
using Microsoft.CognitiveServices.Speech;

namespace TESTT
{
    public partial class Form1 : Form
    {
    


        // Intializing variables
        private int currentQuestionIndex = 0;
        private int score = 0;
        private string username;


        private SoundPlayer textBoxSoundPlayer;
        private SoundPlayer buttonSoundPlayer;
        private SoundPlayer henCorrectSoundPlayer;
        private SoundPlayer sheepCorrectSoundPlayer;
        private SoundPlayer lionCorrectSoundPlayer;
        private SoundPlayer henIncorrectSoundPlayer;
        private SoundPlayer sheepIncorrectSoundPlayer;
        private SoundPlayer lionIncorrectSoundPlayer;
        private SoundPlayer catIncorrectSoundPlayer;
        private SoundPlayer catCorrectSoundPlayer;
        private SoundPlayer dogIncorrectSoundPlayer;
        private SoundPlayer dogCorrectSoundPlayer;
        private SoundPlayer roosterCorrectSoundPlayer;
        private SoundPlayer roosterIncorrectSoundPlayer;
        private SoundPlayer parrotIncorrectSoundPlayer;
        private SoundPlayer parrotCorrectSoundPlayer;
        private SoundPlayer elephantIncorrectSoundPlayer;
        private SoundPlayer elephantCorrectSoundPlayer;
        private SoundPlayer mouseIncorrectSoundPlayer;
        private SoundPlayer mouseCorrectSoundPlayer;
        private SoundPlayer sparrowIncorrectSoundPlayer;
        private SoundPlayer sparrowCorrectSoundPlayer;
        private SoundPlayer pigeonIncorrectSoundPlayer;
        private SoundPlayer pigeonCorrectSoundPlayer;
        private SoundPlayer horseIncorrectSoundPlayer;
        private SoundPlayer horseCorrectSoundPlayer;
        private SoundPlayer goatIncorrectSoundPlayer;
        private SoundPlayer goatCorrectSoundPlayer;
        private SoundPlayer donkeyIncorrectSoundPlayer;
        private SoundPlayer donkeyCorrectSoundPlayer;
        private SoundPlayer crowIncorrectSoundPlayer;
        private SoundPlayer crowCorrectSoundPlayer;

        private List<int> questionOrder;
        private bool quizCompleted = false;


     
        public Form1()
        {
            InitializeComponent();
            InitializeSoundPlayers();
            SetupHoverEvents();



            this.ActiveControl = textBox1;
            button1.Click += button1_Click_1;


            //calling sounds from resourses
            henCorrectSoundPlayer = new SoundPlayer(Properties.Resources.hencorrect);
            sheepCorrectSoundPlayer = new SoundPlayer(Properties.Resources.sheepcorrect);
            lionCorrectSoundPlayer = new SoundPlayer(Properties.Resources.lioncorrect);
            catCorrectSoundPlayer = new SoundPlayer(Properties.Resources.catcorrect);
            dogCorrectSoundPlayer = new SoundPlayer(Properties.Resources.dogcorrect);
            roosterCorrectSoundPlayer = new SoundPlayer(Properties.Resources.roostercorrect);
            parrotCorrectSoundPlayer = new SoundPlayer(Properties.Resources.parrotcorrect);
            elephantCorrectSoundPlayer = new SoundPlayer(Properties.Resources.elephantcorrect);
            mouseCorrectSoundPlayer = new SoundPlayer(Properties.Resources.mousecorrect);
            sparrowCorrectSoundPlayer = new SoundPlayer(Properties.Resources.sparrowcorrect);
            pigeonCorrectSoundPlayer = new SoundPlayer(Properties.Resources.pigeoncorrect);
            horseCorrectSoundPlayer = new SoundPlayer(Properties.Resources.horsecorrect);
            goatCorrectSoundPlayer = new SoundPlayer(Properties.Resources.goatcorrect);
            donkeyCorrectSoundPlayer = new SoundPlayer(Properties.Resources.donkeycorrect);
            crowCorrectSoundPlayer = new SoundPlayer(Properties.Resources.crowcorrect);


            henIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.henincorrect);
            sheepIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.sheepincorrect);
            lionIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.lionincorrect);
            catIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.catincorrect);
            dogIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.dogincorrect);
            roosterIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.roosterincorrect);
            parrotIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.parrotincorrect);
            elephantIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.elephantincorrect);
            mouseIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.mouseincorrect);
            sparrowIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.sparrowincorrect);
            pigeonIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.pigeonincorrect);
            horseIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.horseincorrect);
            goatIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.goatincorrect);
            donkeyIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.donkeyincorrect);
            crowIncorrectSoundPlayer = new SoundPlayer(Properties.Resources.crowincorrect);


            // Initializing and shuffling the question order
            questionOrder = new List<int> { 1, 2, 3 ,4, 5 ,6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            ShuffleQuestions();

            
        }

        private void InitializeSoundPlayers()
        {
            // Initialize SoundPlayer with audio files
            textBoxSoundPlayer = new SoundPlayer(Properties.Resources.buttonhoover); 
            buttonSoundPlayer = new SoundPlayer(Properties.Resources.textboxhoover);   
        }

        private void SetupHoverEvents()
        {
            textBox1.MouseEnter += TextBox1_MouseEnter;
            button1.MouseEnter += Button1_MouseEnter;
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            textBoxSoundPlayer.Play();
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            buttonSoundPlayer.Play(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setofquestions(currentQuestionIndex);
        }

        //method to shuffle the questions
        private void ShuffleQuestions()
        {
            Random rng = new Random();
            int n = questionOrder.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = questionOrder[k];
                questionOrder[k] = questionOrder[n];
                questionOrder[n] = value;
            }
        }

        //applying conditions for sounds for user to guesss
        private void setofquestions(int questionIndex)
        {
            if (questionIndex >= questionOrder.Count)
            {
                quizCompleted = true;
                return;
            }

            int questionNumber = questionOrder[questionIndex];
            SoundPlayer ss = null;
            textBox1.Clear();

            switch (questionNumber)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.listen1;
                    ss = new SoundPlayer(Properties.Resources.hensound);
                    label1.Text = "Guess the sound";
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.l2;
                    ss = new SoundPlayer(Properties.Resources.sheepsound);
                    label1.Text = "Guess the sound";
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.listen3;
                    ss = new SoundPlayer(Properties.Resources.lionsound);
                    label1.Text = "Guess the sound";
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.l4;
                    ss = new SoundPlayer(Properties.Resources.catsound);
                    label1.Text = "Guess the sound";
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.l2;
                    ss = new SoundPlayer(Properties.Resources.dogsound);
                    label1.Text = "Guess the sound";
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.listen1;
                    ss = new SoundPlayer(Properties.Resources.roostersound);
                    label1.Text = "Guess the sound";
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.l4;
                    ss = new SoundPlayer(Properties.Resources.parrotsound);
                    label1.Text = "Guess the sound";
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.l2;
                    ss = new SoundPlayer(Properties.Resources.elephantsound);
                    label1.Text = "Guess the sound";
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.listen3;
                    ss = new SoundPlayer(Properties.Resources.mousesound);
                    label1.Text = "Guess the sound";
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.l4;
                    ss = new SoundPlayer(Properties.Resources.sparrowsound);
                    label1.Text = "Guess the sound";
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.l2;
                    ss = new SoundPlayer(Properties.Resources.pigeonsound);
                    label1.Text = "Guess the sound";
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.listen3;
                    ss = new SoundPlayer(Properties.Resources.horsesound);
                    label1.Text = "Guess the sound";
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.l4;
                    ss = new SoundPlayer(Properties.Resources.goatsound);
                    label1.Text = "Guess the sound";
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.l2;
                    ss = new SoundPlayer(Properties.Resources.donkeysound);
                    label1.Text = "Guess the sound";
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.listen3;
                    ss = new SoundPlayer(Properties.Resources.crowsound);
                    label1.Text = "Guess the sound";
                    break;

            }

            ss?.Play();
        }

        // conditational checking and execution based on correct and incorrect answer
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool isCorrect = false;
            int questionNumber = questionOrder[currentQuestionIndex];

            switch (questionNumber)
            {
                case 1:
                    if (textBox1.Text.ToLower() == "hen")
                    {
                        pictureBox1.Image = Properties.Resources.hen;
                        henCorrectSoundPlayer.Play();
                        score++;
                        label1.Text = "Correct Answer";
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        henIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.hen;
                    }
                    break;

                case 2:
                    if (textBox1.Text.ToLower() == "sheep")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        sheepCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.sheep;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        sheepIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.sheep;
                    }
                    break;

                case 3:
                    if (textBox1.Text.ToLower() == "lion")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        lionCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.lion;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        lionIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.lion;
                    }
                    break;

                case 4:
                    if (textBox1.Text.ToLower() == "cat")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        catCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.cat2;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        catIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.cat2;
                    }
                    break;

                case 5:
                    if (textBox1.Text.ToLower() == "dog")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        dogCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.dog;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        dogIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.dog;
                    }
                    break;

                case 6:
                    if (textBox1.Text.ToLower() == "rooster")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        roosterCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.rooster;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        roosterIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.rooster;
                    }
                    break;
                case 7:
                    if (textBox1.Text.ToLower() == "parrot")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        parrotCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.parrot;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        parrotIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.parrot;
                    }
                    break;

                case 8:
                    if (textBox1.Text.ToLower() == "elephant")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        elephantCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.elephant1;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        elephantIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.elephant1;
                    }
                    break;

                case 9:
                    if (textBox1.Text.ToLower() == "mouse")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        mouseCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.mouse2;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        mouseIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.mouse2;
                    }
                    break;

                case 10:
                    if (textBox1.Text.ToLower() == "sparrow")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        sparrowCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.sparrow;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        sparrowIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.sparrow;
                    }
                    break;

                case 11:
                    if (textBox1.Text.ToLower() == "pigeon")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        pigeonCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.pigeon;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        pigeonIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.pigeon;
                    }
                    break;

                case 12:
                    if (textBox1.Text.ToLower() == "horse")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        horseCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.horse1;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        horseIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.horse1;
                    }
                    break;

                case 13:
                    if (textBox1.Text.ToLower() == "goat")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        goatCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.goat1;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        goatIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.goat1;
                    }
                    break;

                case 14:
                    if (textBox1.Text.ToLower() == "donkey")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        donkeyCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.donkey;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        donkeyIncorrectSoundPlayer.Play();
                    }
                    break;

                case 15:
                    if (textBox1.Text.ToLower() == "crow")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        crowCorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.crow;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        crowIncorrectSoundPlayer.Play();
                        pictureBox1.Image = Properties.Resources.crow;
                    }
                    break;
            }

            label2.Text = "SCORE: " + score;
            textBox1.Clear();

            // 5 sec timer for displaying correct and incorrect answers
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; 
            timer.Tick += (s, args) =>
            {
                currentQuestionIndex++;
                setofquestions(currentQuestionIndex);

                if (!quizCompleted)
                {
                    textBox1.Visible = true;
                    button1.Visible = true;  
                    textBox1.Enabled = true; 
                    button1.Enabled = true; 
                }

                timer.Stop();

                if (quizCompleted)
                {
                    
                    MessageBox.Show("Quiz Completed! Your Score: " + score);
                    SaveScoreToDatabase(Form2.LoggedInUsername, score);
                    currentQuestionIndex = 0;
                    score = 0;
                    ShuffleQuestions();
                    quizCompleted = false;

                    textBox1.Visible = true; 
                    button1.Visible = true;  
                    textBox1.Enabled = true; 
                    button1.Enabled = true;
                }
            };
            timer.Start();

            textBox1.Visible = false;
            button1.Visible = false;
            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void SaveScoreToDatabase(string username, int score)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Documents\logindata.accdb";
            string query = "INSERT INTO score (username, score) VALUES (@username, @score)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Add(new OleDbParameter("@username", OleDbType.VarChar)).Value = username;
                    command.Parameters.Add(new OleDbParameter("@score", OleDbType.Integer)).Value = score;

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Score saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving score: " + ex.Message);
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

   
        }
    }



