using System;
using System.Data.OleDb;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace TESTT
{
    public partial class Form2 : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        private SoundPlayer textBoxHoverSoundPlayer;
        private SoundPlayer textBox1HoverSoundPlayer;
        private SoundPlayer buttonHoverSoundPlayer;
        private SoundPlayer introSoundPlayer;
        private SoundPlayer labelSoundPlayer;

        public static string LoggedInUsername { get; private set; }

        public Form2()
        {
            InitializeComponent();
            InitializeSoundPlayers();
            SetupHoverEvents();

   
            introSoundPlayer = new SoundPlayer(@"D:\NED UNI\semester 2\oops\oops project\intro.wav");
            introSoundPlayer.Play();

            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Documents\logindata.accdb;Persist Security Info=False;";
        }

        private void InitializeSoundPlayers()
        {
            // Initialize SoundPlayers with sounds from resources
            textBoxHoverSoundPlayer = new SoundPlayer(Properties.Resources.usernamehoover);
            textBox1HoverSoundPlayer = new SoundPlayer(Properties.Resources.passwordhoover);
            buttonHoverSoundPlayer = new SoundPlayer(Properties.Resources.playhoover);
            labelSoundPlayer = new SoundPlayer(Properties.Resources.registerhoover);

        }

        private void SetupHoverEvents()
        {
            // Attach hover event handlers
            textBox1.MouseHover += TextBox1_MouseHover;

            button1.MouseHover += Button1_MouseHover;
        }

        private void TextBox1_MouseHover(object sender, EventArgs e)
        {
            textBoxHoverSoundPlayer.Play(); // Play hover sound for TextBox
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            buttonHoverSoundPlayer.Play(); // Play hover sound for Button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from account where username = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'";

            OleDbDataReader or = cmd.ExecuteReader();

            int count = 0;
            while (or.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoggedInUsername = username;
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password does not exist! Please Register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox1HoverSoundPlayer.Play();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            labelSoundPlayer.Play();
        }
    }
}
