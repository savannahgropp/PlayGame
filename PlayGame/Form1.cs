using PlayGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayGame
{
    public partial class SuperAwesomeGame : Form
    {
        public SuperAwesomeGame()
        {
            InitializeComponent();
        }

        private void SuperAwesomeGameTitle_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton_Click(sender, e, StartButton);
        }

        private void StartButton_Click(object sender, EventArgs e, Button startButton)
        {
            StartButton.Text = "Game Starts in 3";
            BackColor = Color.Black;
            SuperAwesomeGameTitle.ForeColor = Color.Red;
            SoundPlayer LowerNote = new SoundPlayer(Properties.Resources.LowerNote);
            LowerNote.Play();

            Refresh();
            Thread.Sleep(1000);

            StartButton.Text = "Game Starts in 2";
            BackColor = Color.White;
            SuperAwesomeGameTitle.ForeColor = Color.Black;
            LowerNote.Play();

            Refresh();
            Thread.Sleep(1000);

            StartButton.Text = "Game Starts in 1";
            BackColor = Color.Black;
            SuperAwesomeGameTitle.ForeColor = Color.Red;
            LowerNote.Play();

            Refresh();
            Thread.Sleep(1000);

            StartButton.Text = "Go!";
            BackColor = Color.White;
            SuperAwesomeGameTitle.ForeColor = Color.Black;
            SoundPlayer HigherNote = new SoundPlayer(Properties.Resources.HigherNote);
            HigherNote.Play();

            Refresh();
            Thread.Sleep(2000);

            StartButton.Visible = false;
            SuperAwesomeGameTitle.Visible = false;
            SoundPlayer CowSound = new SoundPlayer(Properties.Resources.CowSound);
            CowSound.Play();

            Refresh();
            Thread.Sleep(1000);

            CowPng.Visible = true;

            Refresh();
            Thread.Sleep(4000);

            CowPng.Visible = false;

        }
    }
}
