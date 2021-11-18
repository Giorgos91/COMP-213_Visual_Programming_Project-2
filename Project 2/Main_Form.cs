using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Main_Form : Form
    {
        private const int SmallNumberOfCards = 5;
        private const int MediumNumberOfCards = 11;
        private const int LargeNumberOfCards = 17;
        private const int SmallCardSize = 60;
        private const int MediumCardSize = 80;
        private const int largeCardSize = 100;
        private const int NumOfCopys2 = 2;
        private const int NumOfCopys3 = 3;

        int NumberOfCards, SizeCard, Copys,ClickCounter=0;
        Random rnd = new Random();
        Timer time = new Timer();

        PictureBox temp1=new PictureBox();
        PictureBox temp2= new PictureBox();
        public Main_Form()
        {
            InitializeComponent();
            NumberOfCards = SmallNumberOfCards;
            SizeCard = SmallCardSize;
            Copys = NumOfCopys2;
            display();
        }

        private void smallSize_Click(object sender, EventArgs e)
        {
            mediumSize.Checked = false;
            largeSize.Checked = false;
            NumberOfCards = SmallNumberOfCards;
            SizeCard = SmallCardSize;
            display();
        }

        private void mediumSize_Click(object sender, EventArgs e)
        {
            largeSize.Checked = false;
            smallSize.Checked = false;
            NumberOfCards = MediumNumberOfCards;
            SizeCard = MediumCardSize;
            display();
        }

        private void largeSize_Click(object sender, EventArgs e)
        {
            mediumSize.Checked = false;
            smallSize.Checked = false;
            NumberOfCards = LargeNumberOfCards;
            SizeCard = largeCardSize;
            display();
        }

        private void march3Rule_Click(object sender, EventArgs e)
        {
            march2Rule.Checked = false;
            Copys = NumOfCopys3;
            display();
        }

        private void march2Rule_Click(object sender, EventArgs e)
        {
            march3Rule.Checked = false;
            Copys = NumOfCopys2;
            display();
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        /*  <sumary>
            This function is generate all the pictureBox for the game.
            
            </sumary>*/
        private void display()
       {
            MainFlowLayoutPanel.Controls.Clear();
            int[] counter = new int[NumberOfCards];
            for (int i= 0; i < NumberOfCards; i++)
            {
                counter[i] = 0;
            }
            for (int i = 0; i <(NumberOfCards* Copys) ; i++)
            {              
                int name = i + 1;
                bool FindNum = true;
                PictureBox picture = new PictureBox();
                picture.Image = Properties.Resources.starting;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Width = SizeCard;
                picture.Name = $"{name}";
                picture.Click += pictureBox_Click;
                // Is a loop that alocate randomly the picture tha will be in the background in each pictureBox 
                while (FindNum)
                {
                    int NewrandomNumber = rnd.Next(NumberOfCards);
                    if (counter[NewrandomNumber] < Copys)
                    {
                        picture.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("image" + NewrandomNumber);
                        picture.Tag = NewrandomNumber;
                        counter[NewrandomNumber]++;
                        FindNum = false;
                    }
                }
                picture.BackgroundImageLayout = ImageLayout.Zoom;
                MainFlowLayoutPanel.Controls.Add(picture);
            }
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            var picture = (sender as PictureBox);

            picture.Image = picture.BackgroundImage;

            if (temp1.Tag == null)
            {
                temp1 = sender as PictureBox;
            }
            else if ((temp1.Tag != null) && (temp2.Tag == null))
            {
                 temp2 = sender as PictureBox;
            }

            if ((temp1.Tag != null) && (temp2.Tag != null))
            {
                if (temp1.Tag.GetHashCode() == temp2.Tag.GetHashCode())
                {
                    temp1 = new PictureBox();
                    temp2 = new PictureBox();
                }
                else
                {
                    time.Interval = 200;
                    time.Start();
                    time.Tick += Time_Tick;

                }
            }
            ClickCounter++;
            movesTextBox.Text = ClickCounter.ToString();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            time.Stop();
            temp1.Image = Properties.Resources.starting;
            temp2.Image = Properties.Resources.starting;
            temp1 = new PictureBox();
            temp2 = new PictureBox();
        }

        /*  <sumary>
            This function is checking if the two pictures ara the same
            </sumary>*/
        private void check(PictureBox picture1, PictureBox picture2)
        {
            Timer time = new Timer();
            time.Interval = 2000;
            if ( picture1.Name != picture2.Name)
            {
                time.Tick += Time_Tick;
                time.Enabled = true;
                picture1.Image = Properties.Resources.starting;
                picture2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("starting");
                picture1.Click += pictureBox_Click;
                picture2.Click += pictureBox_Click;
            }
        }

    }
}
