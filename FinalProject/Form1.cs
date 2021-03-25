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

                //lucas route
                else if (scene == 5) { scene = 7; }
                else if (scene == 7) { scene = 9; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 13) { scene = 16; }
                else if (scene == 16) { scene = 21; }
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
                    textLabel.Text = "Johnny: [some description] \n\nAre you sure?";
                    NLabel.Text = "Yes";
                    MLabel.Text = "No";
                    break;
                //
                case 3:
                    textLabel.Text = "Lucas: [some description] \n\nAre you sure?";
                    NLabel.Text = "Yes";
                    MLabel.Text = "No";
                    break;
                //
                case 4:
                    textLabel.Text = "Having known Johnny for most of your teenage years up until now, " +
                        "its safe to say you didn't know when these feelings arised" +
                        "\n\nPress the Space Bar to continue ";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 5:
                    textLabel.Text = "You and Lucas were in two different worlds, it was hard to say that you two would have ever cross paths" +
                        "\n\nPress the Space Bar to continue ";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 6:
                    textLabel.Text = "All you knew was that you were madly in love with your best friend and didn't know what to do" +
                        "\n\nPress the Space Bar to continue ";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 7:
                    textLabel.Text = "You kind of forget how you got  a crush on such a jerk but that wasn't that did not matter now. " +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 8:
                    textLabel.Text = "You let out a sigh as you mindlessly scanned through your code which was due in a few days." +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 9:
                    textLabel.Text = "What mattered now was how said man had his chest in direct contact with your back on the very crowded bus" +
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
                    MLabel.Text = "Use your shoulders to keep him upright";
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
                    textLabel.Text = "He's quite surprised you were able to help him without much effort" +
                        "\n\nPress the Space Bar to continue";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                //
                case 14:
                    textLabel.Text = "Lucas lets out a somewhat unapologetic sorry and get's off at the next stop, it was nice while it lasted";
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
                    textLabel.Text = "Scene 21";
                    NLabel.Text = "";
                    MLabel.Text = "";
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
                    textLabel.Text = "Scene 23";
                    NLabel.Text = "";
                    MLabel.Text = "";
                    break;
                case 24:
                    textLabel.Text = "You never mention it again, why must you do this to yourself?";
                    NLabel.Text = "";
                    MLabel.Text = "";
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
    }
}
