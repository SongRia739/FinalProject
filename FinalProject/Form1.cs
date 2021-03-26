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

                //lucas route
                else if (scene == 5) { scene = 7; }
                else if (scene == 7) { scene = 9; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 13) { scene = 16; }
                else if (scene == 16) { scene = 21; }
                else if (scene == 21) { scene = 25; }
            }

            /// display text and game options to screen based on the current scene
            switch (scene)
            {
                //opening scene
                case 0:
                    textLabel.Text = "Welcome to [Game Name]...ready for your adventure?" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 1:
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
                        " but get lower than 1000 and lose all hope. \n\nGood luck!" +
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
                        "but get below 1000 and suffer. \n\nDo your best!";
                    break;
                case 24:
                    textLabel.Text = "You never mention it again, why must you do this to yourself?";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                case 25:
                    textLabel.Hide();
                    break;
                case 26:
                    textLabel.Hide();
                    break;
            }


            //move player during mini game

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //move player during mini game
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draw player

            //draw obsticals
        }

        public void GameInitialize()
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        public void hide()
        {
            NLabel.Hide();
            NBox.Hide();
            MLabel.Hide();
            MBox.Hide();
            sceneBox.Hide();
        }

        public void show()
        {
            NLabel.Show();
            NBox.Show();
            MLabel.Show();
            MBox.Show();
            sceneBox.Show();
        }
    }
}
