using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        int scene = 0;

        string gameState = "";

        int playerX = 600;
        int playerY = 490;
        int playerWidth = 100;
        int playerHeight = 10;
        int playerSpeed = 30;

        List<int> ballXList = new List<int>();
        List<int> ballYList = new List<int>();
        List<int> ballSpeedList = new List<int>();
        List<string> ballColourList = new List<string>();
        int ballSize = 10;

        int score = 3000;

        bool leftArrow = false;
        bool rightArrow = false;

        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush coralBrush = new SolidBrush(Color.Coral);
        SolidBrush purpleBrush = new SolidBrush(Color.MediumPurple);
        SolidBrush indigoBrush = new SolidBrush(Color.Indigo);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush silverBrush = new SolidBrush(Color.Silver);

        Random randGen = new Random();
        int randValue = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)  //choice 1
            {
                if (scene == 1) { scene = 3; }

                //johnny
                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 20) { scene = 23; }
                else if (scene == 18) { scene = 17; }

                //lucas
                else if (scene == 3) { scene = 0; }
                else if (scene == 11) { scene = 13; }
                else if (scene == 33) { scene = 36; }
            }
            else if (e.KeyCode == Keys.N) //choice 2
            {
                if (scene == 1) { scene = 2; }

                //johnny
                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 20) { scene = 19; }
                else if (scene == 18) { scene = 23; }

                //lucas
                else if (scene == 3) { scene = 5; }
                else if (scene == 11) { scene = 14; }
                else if (scene == 33) { scene = 37; }
            }
            else if (e.KeyCode == Keys.Space) //continue 
            {
                if (scene == 0) { scene = 1; }

                //johnny route
                else if (scene == 4) { scene = 6; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 8) { scene = 10; }
                else if (scene == 10) { scene = 12; }
                else if (scene == 12) { scene = 15; }
                else if (scene == 15) { scene = 20; }
                else if (scene == 17) { scene = 22; }
                else if (scene == 19) { scene = 18; }
                else if (scene == 22) { scene = 24; }
                else if (scene == 23) { scene = 26; }
                else if (scene == 26) { scene = 34; }

                //lucas route
                else if (scene == 5) { scene = 7; }
                else if (scene == 7) { scene = 9; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 13) { scene = 16; }
                else if (scene == 16) { scene = 21; }
                else if (scene == 21) { scene = 25; }
                else if (scene == 25) { scene = 27; }
                else if (scene == 27) { scene = 29; }
                else if (scene == 29) { scene = 31; }
                else if (scene == 30) { scene = 32; }
                else if (scene == 31) { scene = 33; }

                //endings
                else if (scene == 24) { scene = 99; }
                else if (scene == 36) { scene = 99; }
                else if (scene == 37) { scene = 99; }
                else if (scene == 32) { scene = 99; }
                else if (scene == 14) { scene = 99; }
            }

            /// display text and game options to screen based on the current scene
            switch (scene)
            {
                //opening scene
                case 0:
                    scoreLabel.Hide();
                    textLabel.Text = "Welcome to [Game Name]...ready for your adventure?" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 1:
                    scoreLabel.Hide();
                    textLabel.Text = "Dosen't matter if you're ready or not, which one of these boys capture your heart?";
                    NLabel.Text = "Johnny";
                    MLabel.Text = "Lucas";
                    break;
                //
                case 2:
                    textLabel.Text = "Johnny: 6'0, 22 years old, has a younger sister" +
                        " and probably did drugs at one point but he'd never admit it." +
                        " Also possibly a father of 3. \n\nAre you sure?";
                    NLabel.Text = "Yes";
                    MLabel.Text = "No";
                    break;
                //
                case 3:
                    sceneImage.BackgroundImage = Properties.Resources.lucas_orange;
                    textLabel.Text = "Lucas: 6'3, 21 years old, drives a motorcycle" +
                        " as well as dated 2 girls and 1 guy at once." +
                        " He also bites his lip a lot for no reason and it makes him look stupid \n\nAre you sure?";
                    NLabel.Text = "Yes";
                    MLabel.Text = "No";
                    break;
                //
                case 4:
                    textLabel.Text = "Having known Johnny for most of your teenage years up until now, " +
                        "its safe to say you didn't know when these feelings arised. You let out a " +
                        "groan as you fiddled with the pencil you fround on the ground 10 minutes ago. " +
                        "\n\nPress the Space Bar to continue ";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 5:
                    textLabel.Text = "You and Lucas were in two different worlds, " +
                        "it was hard to say that you two would have ever cross paths" +
                        "\n\nPress the Space Bar to continue ";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 6:
                    textLabel.Text = "All you knew was that you were madly in love with your best friend " +
                        "and didn't know what to do. Man this sucks." +
                        "\n\nPress the Space Bar to continue ";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 7:
                    textLabel.Text = "You kind of forget how you got a crush on such a jerk in the first place. " +
                        "Was he ever mean to you though? No, but one time he accidently knocked your laptop over" +
                        " and while it wasn't broken, you've always held a grudge. " +
                        " But that did not matter now. " +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 8:
                    textLabel.Text = "You let out a sigh as you mindlessly scanned " +
                        "through your assignment which was due in a few days. " +
                        "It was to create a game in 5 days, like seriously, who could do that?" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 9:
                    sceneImage.BackgroundImage = Properties.Resources.crowded_bus;
                    textLabel.Text = "What mattered now was how said man had his chest " +
                        "in direct contact with your back on the very crowded bus." +
                        " You purse your lips together in only slight annoyance and Lucas " +
                        "seemed to give zero personal space, not that you minded it THAT much though." +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 10:
                    textLabel.Text = "An unexpected arm puts you in a headlock but you let out a laugh as you realize who it is. " +
                        "Johnny grins as he sits down beside you." +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 11:
                    textLabel.Text = "The bus encounters a pothole and you feel Lucas' body jerk forward";
                    NLabel.Text = "Hold on to the railing and thank the stars for this opportunity";
                    MLabel.Text = "Try to use your shoulders to keep him upright";
                    break;
                //
                case 12:
                    sceneImage.BackgroundImage = Properties.Resources.park_scene;
                    textLabel.Text = "The park is bustling with little activity as a soft wind knocks some branches overhead together" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 13:
                    textLabel.Text = "To both of your surprise, you manage to keep steady as the bus passes the pot hole." +
                        "He's quite surprised you seemed to help him without much effort, but you're quite surprised yourself." +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 14:
                    textLabel.Text = "Lucas lets out a somewhat unapologetic sorry and get's off at the next stop, it was nice while it lasted." +
                        "You gently hit your head on the railing in defeat. \n\n What a jerk.";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 15:
                    textLabel.Text = "Being your best-friend, Johnny notices quickly that something was off with you" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 16:
                    textLabel.Text = "Curiosity gets the better of him, and Lucas starts talking to you. " +
                        "You try to keep your cool, but how long can you hold up?" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 17:
                    textLabel.Text = "Johnny shrugs, you'll tell him whenever you feel like it." +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 18:
                    textLabel.Text = "You inwardly groan";
                    NLabel.Text = "There's actually something I want to tell you";
                    MLabel.Text = "It's really nothing";
                    break;
                //
                case 19:
                    textLabel.Text = "You try to brush it off, but Johnny is insisting that something must be wrong." +
                        "\n\nPress the Space Bar to continue ";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 20:
                    textLabel.Text = "'What's up dude? I don't think I've seen you so quiet.' He remarks";
                    NLabel.Text = "'Nothing Really'";
                    MLabel.Text = "'Actually...'";
                    break;
                //
                case 21:
                    hide();
                    textLabel.BackColor = Color.OrangeRed;
                    textLabel.Text = "Keep conversation with Lucas! Collect 5000 points and move on," +
                        " but get lower than 1000 and lose all hope. The purple balls will give you 100 points, but the" +
                        " black ones will take away 100 points. \n\nGood luck!\nPress the Space Bar to start" +
                        "\n\n Press the Space Bar to continue";
                    break;
                //
                case 22:
                    textLabel.Text = "But that's the thing" +
                        "\n\nPress the Space Bar to continue ";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 23:
                    hide();
                    textLabel.BackColor = Color.DarkMagenta;
                    textLabel.ForeColor = Color.White;
                    textLabel.Text = "Confess your feelings for Johnny! Collect 5000 points to be serious, " +
                        "but get below 1000 and suffer. The purple balls will give you 100 points, but the" +
                        " black ones will take away 100 points. \n\nDo your best!";
                    break;
                    //
                case 24:
                    textLabel.Text = "You never mention it again, why must you do this to yourself?";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 25:
                    textLabel.Hide();
                    scoreLabel.Show();
                    gameTimer.Enabled = true;
                    break;
                    //
                case 26:
                    textLabel.Hide();
                    scoreLabel.Show();
                    gameTimer.Enabled = true;
                    break;
                    //
                case 27:
                    show();
                    scoreLabel.Hide();
                    textLabel.BackColor = Color.PaleVioletRed;
                    textLabel.Text = "Welcome back, press the Space Bar to continue your adventure";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 28:
                    show();
                    break;
                    //
                case 29:
                    textLabel.Text = "You manage to hold a decent conversation for over 20 minutes" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 30:
                    textLabel.Text = "GAME OVER: You ended up exposing your little crush on him" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 31:
                    textLabel.Text = "The bus comes to a halt as you arrive at your stop, you wave to say goodbye but he stops you " +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 32:
                    textLabel.Text = "He simply laughs and brushes you off, you messed it up" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 33:
                    textLabel.Text = "'This may be a bit bold, but can I get your number?'";
                    NLabel.Text = "'Oh...I'm not comfortable with that'";
                    MLabel.Text = "'Sure'";
                    break;
                    //
                case 34:
                    show();
                    scoreLabel.Hide();
                    textLabel.BackColor = Color.PaleVioletRed;
                    textLabel.Text = "Welcome back, press the Space Bar to continue your adventure";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 35:
                    show();
                    break;
                    //
                case 36:
                    textLabel.Text = "You agree (maybe a bit too quickly) and wish him a good day. Today was amazing" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 37:
                    textLabel.Text = "'Yeah that's totally fine!' He says embarrassed, he was too forward. Wasn't he? " +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                    //
                case 99:
                    textLabel.Text = "Play again?";
                    NLabel.Text = "Yes";
                    MLabel.Text = "No";
                    break;
            }


            //move player during mini game
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrow = true;
                    break;
                case Keys.Right:
                    rightArrow = true;
                    break;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            //move player during mini game
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrow = false;
                    break;
                case Keys.Right:
                    rightArrow = false;
                    break;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //johnny
            if (gameTimer.Enabled == true && scene == 26)
            {
                //update labels 
                scoreLabel.Text = $"Score: {score}";

                //draw player
                e.Graphics.FillRectangle(whiteBrush, playerX, playerY, playerWidth, playerHeight);

                    //draw ground
                    e.Graphics.FillRectangle(indigoBrush, 0, 500, 6000, 100);

                    //draw obsticals
                    for (int i = 0; i < ballXList.Count(); i++)
                    {
                        if (ballColourList[i] == "black")
                        {
                            e.Graphics.FillEllipse(blackBrush, ballXList[i], ballYList[i], ballSize, ballSize);
                        }
                        else if (ballColourList[i] == "purple")
                        {
                            e.Graphics.FillEllipse(purpleBrush, ballXList[i], ballYList[i], ballSize, ballSize);
                        }
                    }
                
                if (gameState == "pass")
                {
                    e.Graphics.FillRectangle(silverBrush, 0, 0, 1200, 600);
                    gameTimer.Enabled = false;
                    textLabel.Show();
                    textLabel.Text = "Woah! You did it!\n\nPress the Space Bar to continue";
                }
                else if (gameState == "lose")
                {
                    e.Graphics.FillRectangle(silverBrush, 0, 0, 1200, 600);
                    gameTimer.Enabled = false;                                                                                
                    textLabel.Show();
                    textLabel.Text = "Woah! You suck so bad!";
                }
            }
            //lucas
            else if (gameTimer.Enabled == true && scene == 25)
            {
                //update labels 
                scoreLabel.Text = $"Score: {score}";

                //draw player
                e.Graphics.FillRectangle(whiteBrush, playerX, playerY, playerWidth, playerHeight);

                //draw ground
                e.Graphics.FillRectangle(coralBrush, 0, 500, 6000, 100);

                //draw obsticals
                for (int i = 0; i < ballXList.Count(); i++)
                {
                    if (ballColourList[i] == "black")
                    {
                        e.Graphics.FillEllipse(blackBrush, ballXList[i], ballYList[i], ballSize, ballSize);
                    }
                    else if (ballColourList[i] == "orange")
                    {
                        e.Graphics.FillEllipse(orangeBrush, ballXList[i], ballYList[i], ballSize, ballSize);
                    }
                }

                if (gameState == "pass")
                {
                    e.Graphics.FillRectangle(silverBrush, 0, 0, 1200, 600);
                    gameTimer.Enabled = false;
                    textLabel.Show();
                    textLabel.Text = "Woah! You did it!\n\nPress the Space Bar to continue";
                }
                else if (gameState == "lose")
                {
                    e.Graphics.FillRectangle(silverBrush, 0, 0, 1200, 600);
                    gameTimer.Enabled = false;
                    textLabel.Show();
                    textLabel.Text = "Woah! You suck so bad!";
                }
            }
        }

        public void GameInitialize()
        {

            gameTimer.Enabled = true;

            score = 3000;

            ballXList.Clear();
            ballYList.Clear();
            ballSpeedList.Clear();

            playerX = this.Width / 2 - playerWidth / 2;
            playerY = 490;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player
            if (leftArrow == true && playerX > 0)
            {
                playerX -= playerSpeed;
            }

            if (rightArrow == true && playerX < this.Width - playerWidth)
            {
                playerX += playerSpeed;
            }

            //check to see if a new ball should be created 
            randValue = randGen.Next(0, 51);

            if (randValue < 7) //6% change of black ball, (lose points) 
            {
                ballXList.Add(randGen.Next(10, this.Width - ballSize * 2));
                ballYList.Add(10);
                ballSpeedList.Add(randGen.Next(2, 10));
                ballColourList.Add("black");
            }
            else if (randValue >= 5 && randValue < 11) //4% change of purple ball, (get points) 
            {
                ballXList.Add(randGen.Next(10, this.Width - ballSize * 2));
                ballYList.Add(10);
                ballSpeedList.Add(randGen.Next(2, 10));
                if (scene == 26)
                {
                    ballColourList.Add("purple");
                }
                else if(scene == 25)
                {
                    ballColourList.Add("orange");
                }
               
            }

            // move balls 
            for (int i = 0; i < ballXList.Count(); i++)
            {
                ballYList[i] += ballSpeedList[i];
            }

            //check if ball is below play area and remove it if it is 
            for (int i = 0; i < ballXList.Count(); i++)
            {
                if (ballYList[i] > 500)
                {
                    ballXList.RemoveAt(i);
                    ballYList.RemoveAt(i);
                    ballSpeedList.RemoveAt(i);
                    ballColourList.RemoveAt(i);
                    break;
                }
            }

            //check collision of ball and paddle 
            Rectangle playerRec = new Rectangle(playerX, playerY, playerWidth, playerHeight);

            for (int i = 0; i < ballXList.Count(); i++)
            {
                Rectangle ballRec = new Rectangle(ballXList[i], ballYList[i], 10, 10);

                if (playerRec.IntersectsWith(ballRec))
                {
                    if (ballColourList[i] == "purple")
                    {
                        score += 100;
                    }
                    else if (ballColourList[i] == "orange")
                    {
                        score += 100;
                    }
                    else if (ballColourList[i] == "black")
                    {
                        score -= 100;
                    }

                    ballXList.RemoveAt(i);
                    ballYList.RemoveAt(i);
                    ballSpeedList.RemoveAt(i);
                    ballColourList.RemoveAt(i);
                    break;
                }
            }

            if (score == 5000)
            { 
                gameState = "pass";
            }
            else if (score == 1000)
            {
                gameState = "lose";
            }

            Refresh();
        }

        public void hide()
        {
            NLabel.Hide();
            NBox.Hide();
            MLabel.Hide();
            MBox.Hide();
            sceneImage.Hide();
        }

        public void show()
        {
            NLabel.Show();
            NBox.Show();
            MLabel.Show();
            MBox.Show();
            sceneImage.Show();
        }
    }
}
