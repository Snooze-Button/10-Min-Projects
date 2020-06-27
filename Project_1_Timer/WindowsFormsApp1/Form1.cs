using System;
using System.Windows.Forms;

namespace OneHourTimer
{
    public partial class Form1 : Form
    {
       private int totalSeconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //disable Start btn after Click //
            this.btnStart.Enabled = false;
            //enable btn after Click Start btn //
            this.btnStop.Enabled = true;


            // Test var to check if slected index will do anything diff , i asumms it will be 10
           int timerMinutes = int.Parse(this.timerLengthMinutes.SelectedItem.ToString());
            // int timerMinutesToSeconds = int.Parse(this.timerLengthMinutes.SelectedItem.ToString());
            //Get selected item seconds from combobox seconds 
           int timerSeconds = int.Parse(this.timerLengthSeconds.SelectedItem.ToString());

            //Add the 2 to get total number of seconds
            totalSeconds = (timerMinutes * 60 + timerSeconds);

            //Time is enabled//
            this.timer.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;

            //put 0-59 in comboBox // 
            for (int i = 00; i < 60; i++)
            {
                this.timerLengthMinutes.Items.Add(i.ToString());
                this.timerLengthSeconds.Items.Add(i.ToString());
            }
            this.timerLengthMinutes.SelectedIndex = 10; //default values minutes
            this.timerLengthSeconds.SelectedIndex = 00; //default values seconds
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            //disable Stop btn after Click //
            this.btnStop.Enabled = false;
            //enable Start btn after Click // 
            this.btnStart.Enabled = true;

            //Resets Counter to 0
            countdownTimer.Text = "00:00";

            //Stop timer after Click // 
            this.timer.Enabled = false;
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Total min remaning min by diving total seconds by 60
            int minutes = totalSeconds / 60;

            // Total seconds remaning by subtracting totalSeconds by minutes
            int seconds = totalSeconds - minutes * 60; 

            if (totalSeconds > -1)
            {
                //Decrements time each second//
                totalSeconds--;

                //Updates Time in countdown Label each second//
                countdownTimer.Text = minutes.ToString() + ":" + seconds.ToString();

            } else if (totalSeconds < 0) 
            {   
                //Stops Timer
                this.timer.Stop();
                
                for (int i = 0; i < 5; i++)
                {
                    Console.Beep(); //Beeps 5 times
                    System.Threading.Thread.Sleep(700); //Creates 0.5 sec delays between beeps
                }
                MessageBox.Show("Time's Up!");
            }
        }
    }
}
