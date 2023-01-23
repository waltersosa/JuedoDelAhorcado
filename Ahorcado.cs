using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows;

namespace Juego_del_Ahorcado__Alberto_
{
    public partial class Ahorcado : Form
    {
        private int hits = 0;
        private bool game_on = false;
        private const int MAX_TRIES = 5;
        private StringBuilder underscore_word;
        private string current_word;
        private Words words = new Words();
        private int errors = 0;
        public Ahorcado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configure textbox
            configureInput();
        }
        private void configureInput()
        {
            // Configure appereance of textbox: character
            txtCharacter.AutoSize = false;
            txtCharacter.Height = tbButtonsParent.Height;
            txtCharacter.Font = new Font("Arial", txtCharacter.Height - 16);
            txtCharacter.MaxLength = 1;
            // Configure combobox game options
            cboxOptions.AutoSize = false;
            cboxOptions.Text = "Elige una categoria";
            string[] options = new string[words.getSize()];
            options = words.getCategories();
            foreach(string k in options)
            {
                cboxOptions.Items.Add(k);
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            string category = "";
            if (cboxOptions.SelectedIndex > -1)
            {
                category = cboxOptions.SelectedItem.ToString();
                current_word = words.getByCategory(cboxOptions.SelectedItem.ToString());
            }
            
            Console.WriteLine("Category: " + category +  " word: " + current_word);
            string aux_word_hint = getUnderscoreString();
            lblHints.Text = addSpaces(aux_word_hint);
            underscore_word = new StringBuilder(getUnderscoreString());
            game_on = true;
        }
        private string getUnderscoreString()
        {
            string aux = "";
            for(int i = 0; i < current_word.Length; i++)
            {
                aux += "_";   
            }
            return aux;
        }
        private string addSpaces(string s)
        {
            string aux = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(i != s.Length)
                {
                    aux += s[i] + " ";
                }
                else
                {
                    aux += s[i];
                }
                
            }
            return aux;
        }
        private void updateHints()
        {
            // Check for erros quantity
            if(errors < (MAX_TRIES - 1) && game_on)
            {
                // Check if the character exists inside the current word
                if(current_word.Contains(txtCharacter.Text))
                {
                    for (var i = 0; i < current_word.Length; i++)
                    {
                        for (var j = 0; j < current_word.Length; j++)
                        {
                            var chs = current_word[j];
                            if (txtCharacter.Text == chs.ToString())
                            {
                                underscore_word[j] = chs;
                            }
                        }
                    }
                    hits++;
                    lblHints.Text = addSpaces(underscore_word.ToString());
                    Console.WriteLine("Hits: " + hits);
                }
                else
                {
                    // Errors + 1
                    // Debug
                    Console.WriteLine("Errors: " +  errors);
                    errors++;
                    updateSprites();
                }
                txtCharacter.Text = "";
            }
            else
            {
                // Game over case
                pictureBox2.BackgroundImage = Juego_del_Ahorcado__Alberto_.Properties.Resources.Gameover;
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                Console.WriteLine("Game over!");
                restartGame();

            }
        }

        private void btnTryChar_Click(object sender, EventArgs e)
        {
            if(hits == current_word.Length - 1)
            {
                pictureBox2.BackgroundImage = Juego_del_Ahorcado__Alberto_.Properties.Resources.game;
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                Console.WriteLine("You win!");
                restartGame();
            }
            else
            {
                updateHints();
            }
        }
        private void restartGame()
        {
            current_word = "";
            underscore_word = new StringBuilder(current_word);
            game_on = false;
            txtCharacter.Text = "";
            lblHints.Text = "_ _ _ _ _ _ _";
        }
        private void updateSprites()
        {
            switch (errors)
            {
                case 1:
                    pictureBox1.BackgroundImage = Juego_del_Ahorcado__Alberto_.Properties.Resources.sprite_2;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Juego_del_Ahorcado__Alberto_.Properties.Resources.sprite_3;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Juego_del_Ahorcado__Alberto_.Properties.Resources.sprite_4;
                    break;
                case 4:
                    pictureBox1.BackgroundImage = Juego_del_Ahorcado__Alberto_.Properties.Resources.sprite_5;
                    break;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetearJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void salirDelJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

