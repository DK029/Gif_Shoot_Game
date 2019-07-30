using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gif_Shoot_Game
{
    public partial class Form1 : Form
    {
        //global variable for performing the operations of the game 
        int sec = 0,Random_Fire=0,trigger=0,counter=0,loser=0;

        //object of the random class to genrerate the random no 
        Random instance_Object = new Random();

        public Form1()
        {
            InitializeComponent();
            // at the loading of the game first of all call the timer to start the game after 10 sec  the game area will be visible in front of the user 
            timer1.Start();

            //after that calling the fire method to generate the random no for first fire 
            first_Fire();
            forthBtn.Visible = false;
        }

        //this is empty method that is used to pass the random no to the global variable so it can be compare later for the generate the fire sound
        public void first_Fire() {
            //pass the random no to the global variable for compare the triger count 
            Random_Fire = instance_Object.Next(1, 6);

        }

        // this is the timer method that is used to increment of the timer and after some timr it will be display the game area
        private void timer1_Tick(object sender, EventArgs e)
        {
            //increment the timer of the global variable 
            sec++;
            if (sec==10) {
                FireGame.Visible = true;
            }
        }

        //this is post define method that is used to find the winner if the player win the game then 
        public void find_winner() {
            int win = instance_Object.Next(1,6);
            if (win==trigger) {
                MessageBox.Show("you are the  contest winner of this Game ");
                FireGame.Visible = false;
                loser = loser + 1;
            }
        }

        private void forthBtn_Click(object sender, EventArgs e)
        {
            //this method is used to restart the game again and reset the all varaibles 
            FireGame.Visible = true;
            trigger = 0;
            first_Fire();
            loser = 0;
            counter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trigger++;
            if (trigger == Random_Fire)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("sund.wav");
                player.Play();
                counter = counter + 1;
                find_winner();
                first_Fire();
                if (counter == 1)
                {
                    MessageBox.Show("this is your last chance to fire again");
                    trigger = 0;
                }

            }

            //this method is used to the generate the message for the looser after using his 2 chaces 
            if (counter == 2 && loser == 0)
            {
                MessageBox.Show("sorry you are the loose the game ");
                FireGame.Visible = false;
                forthBtn.Visible = true;
       
            }
        }

        private void thirdBtn_Click(object sender, EventArgs e)
        {
            // this counter is used to genreate the fire sound when the random no and the compare no matched 
            trigger++;
            if (trigger==Random_Fire) {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("sund.wav");
                player.Play();
                counter = counter + 1 ;
                find_winner();
                first_Fire();
                if (counter==1) {
                    MessageBox.Show("this is your last chance to fire again");
                    trigger = 0;
                }
                
            }

            //this method is used to the generate the message for the looser after using his 2 chaces 
            if (counter==2 && loser==0) {
                MessageBox.Show("sorry you are the loose the game ");
                FireGame.Visible = false;
                forthBtn.Visible = true;
            }
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            // caling the loading method of  the gun 
            pictureBox1.ImageLocation = "second.jpg";
        }
        
        private void secondBtn_Click(object sender, EventArgs e)
        {
            // this is the spin gun  button that is used to load the bullet in the gun to be ready to fire 
            pictureBox1.ImageLocation = "third.jpg";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
