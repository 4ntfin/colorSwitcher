using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace colorSwitcher
{
    public partial class ColorSwitch : Form
    {
        List<Color> colors;
        Random rnd = new Random();

        Menu menu = new Menu();

        Random blockPos = new Random();

        int blockColor = 0;
        int i;
        int speed = 5;
        int score = 0;
        bool gameOver = false;

        string playerName;

        SoundPlayer music = new SoundPlayer(Properties.Resources.GameMusic);
     //   SoundPlayer epicfail = new SoundPlayer(Properties.Resources.Fail);

        public ColorSwitch()
        {
            Application.Run(new Menu());
           
            InitializeComponent();
            resetGame();
        }

        private void playGame(object sender, EventArgs e)
        {

            
            block1.Top += speed; 
            block2.Top += speed; 
            Score.Text = "Score " + score; 

            if(block1.Top > 500)
            {
                blockColor = rnd.Next(colors.Count);
                block1.BackColor = colors[blockColor];
                block1.Top = blockPos.Next(200, 300) * -1;
                score++;
            }

            if (block2.Top > 500)
            {
                if (block1.Top > 100)
                {
                    blockColor = rnd.Next(colors.Count); // Set Block to A Random Color
                    block2.BackColor = colors[blockColor]; // Apply Color to Block 2
                    block2.Top = (block1.Top * 8) * -1; // Choose Random Position on Top of Form
                    score++; // Increment Score
                }
            }

            // if the player collides with block 1
            if (player.Bounds.IntersectsWith(block1.Bounds))
            {
                // if the player and block 1 DON'T have the same background color
                if (player.BackColor != block1.BackColor)
                {
                    gameTimer.Stop();
                    gameOver = true;
                    // we will add the current score to the list box with the time which they were played
                    playerName = Interaction.InputBox("Name?: ", "Enter Name for Leaderboard", "Enter Text...");
                    Scoreboard.Items.Add(playerName.ToString() + " Scored: " + score.ToString());
                    // game over
           
                }
            }

            // if the player collides with block 2
            if (player.Bounds.IntersectsWith(block2.Bounds))
            {
                // if the player and block 2 DON'T have the same background color
                if (player.BackColor != block2.BackColor)
                {
                    gameTimer.Stop();
                    gameOver = true;
                    playerName = Interaction.InputBox("Name?: ", "Enter Name for Leaderboard", "Enter Text...");
                    Scoreboard.Items.Add(playerName.ToString() + " Scored: " + score.ToString());                   



                }
            }

            // When The Score is A Multiple of 5, increase the speed.
            if (score >= 5)
            {
                speed = 6;
            }
          
            if (score >= 10)
            {
                speed = 8;
            }

            if (score >= 15)
            {
                speed = 12;
            }

            if (score >= 20)
            {
                speed = 15;
            }

            block1.Refresh(); // Refresh The Block So It Scrolls Down The Screen Smoothly
            block2.Refresh();

          
        }

        private void ColorSwitch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                i++;

                if (i > colors.Count - 1)
                {
                    i = 0;
                    
                }

                player.BackColor = colors[i];

                if (i + 1 < colors.Count)
                    nextColor.BackColor = colors[i + 1];
                else
                    nextColor.BackColor = colors[0];
            }

            if (e.KeyCode == Keys.R && gameOver)
            {
                // Invoke the reset game function
                resetGame();
                gameOver = false;
            }

          
        }

        public void resetGame()
        {
           

            block1.Top = -80; 
            block2.Top = -300;

            colors = new List<Color> { System.Drawing.Color.Orange, System.Drawing.Color.OliveDrab, System.Drawing.Color.Crimson, System.Drawing.Color.MediumPurple, Color.CornflowerBlue };

            music.Play();

            i = 0; 
            gameTimer.Start(); 
            speed = 5; 
            score = 0;
        }
    }
}
