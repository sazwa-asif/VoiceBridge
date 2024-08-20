using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TESTT
{
    public partial class Form3 : Form
    {

        private OleDbConnection conn = new OleDbConnection();

        private SoundPlayer textBoxHoverSoundPlayer;
        private SoundPlayer textBox1HoverSoundPlayer;
        private SoundPlayer buttonHoverSoundPlayer;
        public Form3()
        {
            InitializeComponent();
            InitializeSoundPlayers();
            //SetupHoverEvents();

            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Documents\logindata.accdb;
Persist Security Info=False;";
        }


        private void InitializeSoundPlayers()
        {
            // Initialize SoundPlayers with sounds from resources
            textBoxHoverSoundPlayer = new SoundPlayer(Properties.Resources.usernamehoover);
            textBox1HoverSoundPlayer = new SoundPlayer(Properties.Resources.passwordhoover);
            buttonHoverSoundPlayer = new SoundPlayer(Properties.Resources.signuphoover);
     

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
            try
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO account ([username], [password]) VALUES (?, ?)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("One record has been inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBoxHoverSoundPlayer.Play();
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox1HoverSoundPlayer.Play();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            buttonHoverSoundPlayer.Play();
        }
    }
}
