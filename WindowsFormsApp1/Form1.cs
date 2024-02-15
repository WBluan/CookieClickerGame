using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        public SoundPlayer musicPlayer = new SoundPlayer();
        private int _ticks;
        private int _clicks;

        public Form1()
        {
            InitializeComponent();
            PlayMusic("lofisong.wav");
            button2.Hide();
            button4.Hide();
        }

        public void PlayMusic(string filepath)
        {
            button4.Hide();
            button3.Show();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Play();

        }

        public void StopMusic(string filepath)
        {
            button4.Show();
            button3.Hide();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cookie
            timer1.Start();
            label2.Text = "Clicks: " + _clicks;
            if (_ticks >= 1)
            {
                _clicks++;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer
            _ticks++;
            label1.Text = "Time: " + _ticks.ToString();

            if (_ticks == 11)
            {
                timer1.Stop();
                label1.Text = "Game Over!";
                label2.Text = "Your CLicks: " + _clicks;
                _ticks = 0;
                _clicks = 0;
                MessageBox.Show("Time is up!");
                button2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reset button
            timer1.Stop();
            _ticks = 0;
            _clicks = 0;
            label1.Text = "Time: 10";
            label2.Text = "Clicks: 0";
            button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StopMusic("lofisong.wav");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayMusic("lofisong.wav");
        }
    }
}
