using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        private int BirdYdiff = 4;
        private int BirdYJumpdiff = -80;
        private SolidBrush b = new SolidBrush(Color.LimeGreen);
        private int pillarX,PillarWidth = 50,pillarHeight,pillar2X,pillar2Height;
        private Random rnd = new Random();
        private int score;
        private Rectangle Pillar1,Pillar2,Pillar1part2,Pillar2part2, Pillar3, Pillar4, Pillar3part2, Pillar4part2;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            createPillars();
            createPillars2();
            e.Graphics.FillRectangle(b,Pillar1);
            e.Graphics.FillRectangle(b,Pillar2);
            e.Graphics.FillRectangle(b, Pillar1part2);
            e.Graphics.FillRectangle(b, Pillar2part2);
            e.Graphics.FillRectangle(b, Pillar3);
            e.Graphics.FillRectangle(b, Pillar4);
            e.Graphics.FillRectangle(b, Pillar3part2);
            e.Graphics.FillRectangle(b, Pillar4part2);
        }

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            pillarX = this.Width;
            pillar2X = this.Width + 300;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score = Convert.ToInt32(Score.Text);
            PepeBird.Location = new Point(PepeBird.Location.X, PepeBird.Location.Y + BirdYdiff); 
            
            pillarX -= 2;
            pillar2X -= 2;

            if (PepeBird.Location.X == pillarX + 50 || PepeBird.Location.X == pillar2X + 50)
                score++;

            if (pillarX <= -50)
            {
                pillarX = this.Width;
                randomizePillar1Height();
            }

            if (pillar2X <= -50)
            {
                pillar2X = this.Width;
                randomizePillar2Height();
            }

            // if collision occurs stop the timer
            if(PepeBird.Bounds.IntersectsWith(Pillar1) || PepeBird.Bounds.IntersectsWith(Pillar2) || PepeBird.Location.Y >= this.Width - 165 
                || PepeBird.Location.Y <= 0 || PepeBird.Bounds.IntersectsWith(Pillar1part2) || PepeBird.Bounds.IntersectsWith(Pillar2part2)
                || PepeBird.Bounds.IntersectsWith(Pillar3) || PepeBird.Bounds.IntersectsWith(Pillar4) || PepeBird.Bounds.IntersectsWith(Pillar3part2)
                || PepeBird.Bounds.IntersectsWith(Pillar4part2))
            {
                gameOver();
            }

            Score.Text = Convert.ToString(score);
            this.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space || e.KeyCode == Keys.Up) && timer1.Enabled)
                updateBirdLocation();

            // If S is pressed start the game (starting the timer)
            if (e.KeyCode == Keys.S && !timer1.Enabled)
                gameStart();

            // If r is pressed -> restart game
            if(e.KeyCode == Keys.R)
                restartGame();


            if (e.KeyCode == Keys.Escape)
                this.Close();
                
        }

        private void randomizePillar1Height()
        {
            pillarHeight = rnd.Next(50, this.Height - 300);
        }

        private void randomizePillar2Height()
        {
            pillar2Height = rnd.Next(50, this.Height - 300);
        }

        private void gameOver()
        {
            timer1.Enabled = false;
            GameOver.Visible = true;
        }

        private void createPillars()
        {
            Pillar1 = new Rectangle(pillarX, 0, PillarWidth, pillarHeight);
            Pillar2 = new Rectangle(pillarX, pillarHeight + 170, PillarWidth, this.Height - pillarHeight - 200);
            Pillar1part2 = new Rectangle(pillarX - 20, pillarHeight - 20, 90, 20);
            Pillar2part2 = new Rectangle(pillarX - 20, pillarHeight + 170, 90, 20);
        }

        private void createPillars2()
        {
            Pillar3 = new Rectangle(pillar2X, 0, PillarWidth, pillar2Height);
            Pillar4 = new Rectangle(pillar2X, pillar2Height + 170, PillarWidth, this.Height - pillar2Height - 200);
            Pillar3part2 = new Rectangle(pillar2X - 20, pillar2Height - 20, 90, 20);
            Pillar4part2 = new Rectangle(pillar2X - 20, pillar2Height + 170, 90, 20);
        }

        private void restartGame()
        {
            Score.Text = "0";
            pillarX = this.Width;
            pillar2X = this.Width + 300;
            randomizePillar1Height();
            randomizePillar2Height();
            PepeBird.Location = new Point(260, 250);
            GameOver.Visible = false;
            timer1.Enabled = true;
        }

        private void gameStart()
        {
            timer1.Enabled = true;
            randomizePillar1Height();
            randomizePillar2Height();
            PepeBird.Visible = ScoreText.Visible = Score.Visible = true;
            StartInfo.Visible = false;
        }

        private void updateBirdLocation()
        {
            PepeBird.Location = new Point(PepeBird.Location.X, PepeBird.Location.Y + BirdYJumpdiff);
        }

        private void playBGM()
        {
            SoundPlayer simpleSound = new SoundPlayer("/BGM.vaw");
            simpleSound.Play();
        }
    }
}
