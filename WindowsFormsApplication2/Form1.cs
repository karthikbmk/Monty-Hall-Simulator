using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://karthikeuler.blogspot.in/";
            linkLabel1.Links.Add(link);
            LinkLabel.Link link2 = new LinkLabel.Link();
            link2.LinkData = "http://en.wikipedia.org/wiki/Monty_Hall_problem";
            linkLabel2.Links.Add(link2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoOfTrials.Text.Contains('.') || txtNoOfTrials.Text.Equals("") || txtNoOfTrials.Text.Contains('-'))
                {
                    MessageBox.Show("Enter valid no of trials.");
                }
                else
                {
                    chartMontyHall.Series["MontyHall Simulation"].Points.Clear();
                    ulong winningCounter = 0;
                    var randomNumer = new Random();                    
                    for (ulong gameCounter = 1; gameCounter < Convert.ToUInt64(txtNoOfTrials.Text); gameCounter++)
                    {
                        char[] lottery = new char[3];
                        int moneyPosition = randomNumer.Next(0, 3);
                        lottery[moneyPosition] = '$'; //This is where the money is !            
                        int chosenPosition = 0;
                        chosenPosition = randomNumer.Next(0, 3); //Chose a random door. You'd never know whether its the money or a goat !
                        int GSeenPosition = 0; ;
                        for (int i = 0; i < 3; i++)
                        {
                            if (i != chosenPosition && i != moneyPosition)
                            {
                                lottery[i] = 'G';
                                GSeenPosition = i;
                                break;
                            }
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            if (i != GSeenPosition && i != chosenPosition)
                                if (lottery[i] == '$')
                                {
                                    chosenPosition = i;
                                    winningCounter += 1;
                                    break;
                                }

                        }
                        chartMontyHall.Series["MontyHall Simulation"].Points.AddXY(gameCounter, ((float)winningCounter * 100 / (float)gameCounter));
                        lblAvgProbability.Text = ((float)winningCounter * 100 / (float)gameCounter).ToString() + "%";
                        lblAvgProbability.BackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Some Problem Occured. Did you enter valid data?");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            Process.Start(e.Link.LinkData as string);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        
    }
}
