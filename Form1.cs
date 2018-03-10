using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {

        private int x, y;
        private int xChange, yChange;

        private Graphics paper;
        private Random RanNum;
        private Pen pen, bat,ourPen;
        private int batXPos;
        int play = 5;
        int score;
        int brkLength = 60;
        int brkHeight = 20;
        int[,] brickLocation = { { 0, 0 }, { 61, 0 }, { 122, 0 }, { 183, 0 }, { 244, 0 },{ 305, 0 }, { 366, 0 }, { 427, 0 }, { 488, 0 }, { 549, 0 } };
        bool[] brickLive = {true, true, true, true, true, true, true, true, true, true, };
        Color[] colourArray = { Color.Blue, Color.Green, Color.DarkRed, Color.Purple, Color.RoyalBlue,Color.Blue, Color.Green, Color.DarkRed, Color.Red, Color.MidnightBlue,};
        Rectangle collideBat, ball;
        Rectangle[] bricks;
        
       
        
        
  

        public Form1()
        {
            InitializeComponent();
            paper = picDisplayBox.CreateGraphics();
            pen = new Pen(Color.Red);
            pen.Width = 10;
            RanNum = new Random();

            paper = picDisplayBox.CreateGraphics();
            ourPen = new Pen(Color.White);
            ourPen.Width = 3;

            bat = new Pen(Color.Black);
            bat.Width = 1;
            batXPos = 0;
            score = 0;
            picDisplayBox.MouseMove += new System.Windows.Forms.MouseEventHandler(blackBat_MouseMove);


            brickColour();

     

        }
        public void brickColour()
        {
            bricks = new Rectangle[10];





            for (int i = 0; i < bricks.Length; i++)
            {
                bricks[i].X = brickLocation[i, 0];
                bricks[i].Y = brickLocation[i, 1];
                bricks[i].Height = brkHeight;
                bricks[i].Width = brkLength;
            }

        }
        private void blackBat_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {                                                                                     
           // paper.Clear(Color.White);
           // paper.DrawRectangle(bat, e.X + 10, picDisplayBox.Height - 20, 50, 10);
            /* the bat was was glitching every time
             that i moved the bat so i create a variable to store the 
             position and then move it to the timerandom*/
            
            
            batXPos = e.X;
        }

        private void btnRandom_Click(object sender, EventArgs e)
          
        { play = play - 1;
            txtInsert.Text = play + "";

            if (play <= 0)
            {
                btnDown.Enabled = false;
                btnL.Enabled = false;
                btnRandom.Enabled = false;
                btnStop.Enabled = false;
                btnUP.Enabled = false;
                btnR.Enabled = false;
                Bricks.Enabled = false;
                play = 5;
                  timerStart.Interval = 50;
                  timerStart.Enabled = false;
            }

    
                  //if (y >= picDisplayBox.Height)
            //yChange = -yChange;


            timerStart.Interval = 50;
            timerStart.Enabled = true;
            timerControl.Enabled = false;
            LeftTimer.Enabled = false;
            RightTimer.Enabled = false;
            DownTimer.Enabled = false;
            UpTimer.Enabled = false;
            x = 520;
            y = 520;
            xChange = 10;
            yChange = 10;

          
        }

       



        private void timerRandom_Tick(object sender, EventArgs e)
        {  
            
            paper.Clear(Color.White);
            createBick();
            moveBall();
            drawBall();
            drawBat();
            checkCollision();
            brickCollision();
            numberOfGoes();
            }

        public void numberOfGoes()
        {
            if (y > picDisplayBox.Height)
            {
                x = RanNum.Next(1, picDisplayBox.Height);
                y = RanNum.Next(1, picDisplayBox.Width);
                play = play - 1;
                txtInsert.Text = play + "";
            }

            if (play <= 0)
            {
                btnDown.Enabled = false;
                btnL.Enabled = false;
                btnRandom.Enabled = false;
                btnStop.Enabled = false;
                btnUP.Enabled = false;
                btnR.Enabled = false;
                Bricks.Enabled = false;
                play = 5;
                timerStart.Interval = 50;
                timerStart.Enabled = false;
            }
        }
        public void moveBall()
        {
            x = x + xChange;
            y = y + yChange;
            if (x >= picDisplayBox.Width)
                xChange = -xChange;
            //if (y >= picDisplayBox.Height)
            //yChange = -yChange;
            if (x <= 0)
                xChange = -xChange;
            if (y <= 0)
                yChange = -yChange;
        }


        public void checkCollision()

        { if (ball.IntersectsWith(collideBat))
            {
                yChange = -yChange;
            }
        }

        public void brickCollision()
        {

            for (int i = 0; i < brickLocation.GetLength(0); i++)
            {

                if ((ball.IntersectsWith(bricks[i])) && (brickLive[i] == true))
                {

                    brickLive[i] = false;
                    score = score + 10;
                    lblScore.Text = score + "";

                }
            }
        }
        public void drawBall()
        {
            ball = new Rectangle(x, y, 10, 10);
            paper.DrawEllipse(pen, ball); }

        public void drawBat()
        {
            paper.DrawRectangle(bat, collideBat);
            collideBat = new Rectangle(batXPos +10, picDisplayBox.Height - 30, 100, 15);
        }

        public void createBick()
        { for (int i = 0; i < brickLive.Length; i++)
          if (brickLive[i])
                
          
       {  ourPen.Color = colourArray[i];
          paper.DrawRectangle(ourPen, brickLocation[i, 0], brickLocation[i, 1], brkLength, brkHeight);
                      }

        }
    

        
    
    
        private void btnStop_Click(object sender, EventArgs e)
        {
            
            timerStart.Enabled = false;
            timerControl.Enabled = false;
            LeftTimer.Enabled = false;
            RightTimer.Enabled = false;
            DownTimer.Enabled = false;
            UpTimer.Enabled = false;
            paper.Clear(Color.White);
        }



   

        private void btnUP_Click(object sender, EventArgs e)
        {
            UpTimer.Enabled = true;
            UpTimer.Interval = 50;
            timerStart.Enabled = false;
            timerControl.Enabled = false;
            LeftTimer.Enabled = false;
            RightTimer.Enabled = false;
            DownTimer.Enabled = false;
           


            xChange = 10;
            yChange = 10;
        }

        private void Down_Tick(object sender, EventArgs e)
        {
            //x = x + xChange;
            y = y + yChange;
            if (x >= picDisplayBox.Width)
                xChange = -xChange;
            if (y >= picDisplayBox.Height)
                yChange = -yChange;
            if (x <= 0)
                xChange = -xChange;
            if (y <= 0)
                yChange = -yChange;
            paper.Clear(Color.White);
            paper.DrawEllipse(pen, x, y, 10, 10);

        }

        private void Left_Tick(object sender, EventArgs e)
        {    x = x - xChange;
            //y = y + yChange;
            if (x >= picDisplayBox.Width)
                xChange = -xChange;
            if (y >= picDisplayBox.Height)
                yChange = -yChange;
            if (x <= 0)
                xChange = -xChange;
            if (y <= 0)
                yChange = -yChange;
            paper.Clear(Color.White);
            paper.DrawEllipse(pen, x, y, 10, 10);
            

        } 

        private void Up_Tick(object sender, EventArgs e)
        {   //x = x + xChange;
            y = y - yChange;
            
            if (y >= picDisplayBox.Height)
                yChange = -yChange;
         
            if (y <= 0)
                yChange = -yChange;
            paper.Clear(Color.White);
            paper.DrawEllipse(pen, x, y, 10, 10);


        }

        private void Right_Tick(object sender, EventArgs e)
        {
            x = x + xChange;
            //y = y + yChange;
            if (x >= picDisplayBox.Width)
                xChange = -xChange;
            if (y >= picDisplayBox.Height)
                yChange = -yChange;
            if (x <= 0)
                xChange = -xChange;
            if (y <= 0)
                yChange = -yChange;
            paper.Clear(Color.White);
            paper.DrawEllipse(pen, x, y, 10, 10);
           

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            LeftTimer.Enabled = true;
            LeftTimer.Interval = 50;
            timerStart.Enabled = false;
            timerControl.Enabled = false;
            RightTimer.Enabled = false;
            DownTimer.Enabled = false;
            UpTimer.Enabled = false;

            xChange = 10;
            yChange = 10;

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            DownTimer.Enabled = true;
            DownTimer.Interval = 50;
            timerStart.Enabled = false;
            timerControl.Enabled = false;
            LeftTimer.Enabled = false;
            RightTimer.Enabled = false;
            UpTimer.Enabled = false;


            xChange = 10;
            yChange = 10;
}


        private void btnR_Click(object sender, EventArgs e)
        {
            RightTimer.Interval = 50;
            timerStart.Enabled = false;
            timerControl.Enabled = false;
            LeftTimer.Enabled = false;
            RightTimer.Enabled = true;
            DownTimer.Enabled = false;
            UpTimer.Enabled = false;


            xChange = 10;
            yChange = 10;

        }

   

        private void btnInsert_Click(object sender, EventArgs e)
        {
            

            btnDown.Enabled = true;
            btnL.Enabled = true;
            btnRandom.Enabled = true;
            btnStop.Enabled = true;
            btnUP.Enabled = true;
            btnR.Enabled = true;
            Bricks.Enabled = true;
            txtInsert.Text = play + "";
            btnRandom.Enabled = true;
            
            
        }

        private void Bricks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < brickLive.Length; i++)
            {
                if (brickLive[i])
                {
                    ourPen.Color = colourArray[i];
                    paper.DrawRectangle(ourPen, brickLocation[i, 0], brickLocation[i, 1], brkLength, brkHeight);

                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                play = play - 1;
                txtInsert.Text = play + "";

                if (play <= 0)
                {
                    btnDown.Enabled = false;
                    btnL.Enabled = false;
                    btnRandom.Enabled = false;
                    btnStop.Enabled = false;
                    btnUP.Enabled = false;
                    btnR.Enabled = false;
                    Bricks.Enabled = false;
                    play = 5;
                    timerStart.Interval = 50;
                    timerStart.Enabled = false;
                    timerRandom.Enabled = false;
                }


               
                timerRandom.Enabled = true;
                timerRandom.Interval = 50;
                timerStart.Enabled = false;
                timerControl.Enabled = false;
                LeftTimer.Enabled = false;
                RightTimer.Enabled = false;
                DownTimer.Enabled = false;
                UpTimer.Enabled = false;
                x = RanNum.Next(1, picDisplayBox.Height);
                y = RanNum.Next(1, picDisplayBox.Width);
                xChange = RanNum.Next(1, 10);
                yChange = RanNum.Next(1, 10);


            }

        }

        private void timerRandom_Tick_1(object sender, EventArgs e)
        {
            
            paper.Clear(Color.White);

            for (int i = 0; i < brickLive.Length; i++)
            {
                if (brickLive[i])
                {
                  
                    paper.DrawRectangle(ourPen, brickLocation[i, 0], brickLocation[i, 1], brkLength, brkHeight);
               
                }
            }

            
            moveBall();
            //if (y >= picDisplayBox.Height)
            //    yChange = -yChange;

            drawBall();
            drawBat();
            checkCollision();
            brickCollision();
      

            { }
            numberOfGoes();
            
                {
          
            }
                //for (int i = 0; i < brickLive.Length; i++)
               //{ paper.DrawRectangle(ourPen, brickLocation[i, 0], brickLocation[i, 1], brkLength, brkHeight); }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        }
    }

