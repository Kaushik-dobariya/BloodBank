using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        int move = 0;

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            //Write the code to show Loading Animation
            timerSplash.Interval = 60;
            panelMovable.Width += 5;

            move += 5;

            //If the loading is complete then display login form and close this form
            if(move==640)
            {
                //Stop the Timer and Close this Form
                timerSplash.Stop();
                this.Hide();

                //Display the Login Form
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Load the Timer
            timerSplash.Start();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void panelMovable_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        // Declare these as class-level variables
        private string[] loadingMessages = new string[]
        {
    "Booting up system...",
    "Accessing database...",
    "Initializing modules...",
    "Loading files...",
    "Establishing connection...",
    "Verifying data...",
    "Retrieving information...",
    "System ready."
        };
        private int currentMessageIndex = 0;
        private void label4_Click(object sender, EventArgs e)
        {
            // Reset the index if this method is called again
            currentMessageIndex = 0;

            // Create and configure the timer
            Timer bootTimer = new Timer();
            bootTimer.Interval = 1000; // 1000 ms (1 second) per message (adjust as needed)

            // Event handler for the timer tick
            bootTimer.Tick += (object timerSender, EventArgs args) =>
            {
                // Check if there are more messages to display
                if (currentMessageIndex < loadingMessages.Length)
                {
                    label4.Text = loadingMessages[currentMessageIndex];
                    currentMessageIndex++;
                }
                else
                {
                    // Stop the timer and show the final message
                    bootTimer.Stop();
                    label4.Text = "System ready.";
                }
            };

            // Start the timer
            bootTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
