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
using CUP.Properties;
using System.Media;

namespace CUP
{
    public partial class Form1 : Form
    {
        private bool isMuted = false;
        public Form1()
        {
            InitializeComponent();
            var Musica = new SoundPlayer(Resources._Audio__CupheadIntroSongStudio__mp3cut_net_);
            Musica.Play();
            Musica.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Musica = new SoundPlayer(Resources.Intro21);
            Musica.Play();
            Musica.PlayLooping();
            pictureBox1.Image = Properties.Resources.Carregamento__1_;
            button1.Visible = false;
            progressBar1.Visible = true;
            timer1.Enabled = true;
            progressBar1.Increment(2);
            button2.Visible = false;

            if (progressBar1.Value == 100)
            {       
           
              
                timer1.Enabled = false;
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
               Musica.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var Musica = new SoundPlayer(Resources._Audio__CupheadIntroSongStudio__mp3cut_net_);
            Musica.Stop();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            var Musica = new SoundPlayer(Resources._Audio__CupheadIntroSongStudio__mp3cut_net_);
            Musica.Stop();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isMuted)
            {
                var Musica = new SoundPlayer(Resources._Audio__CupheadIntroSongStudio__mp3cut_net_);
           
                isMuted = true;
                button2.Image = Properties.Resources.IS3; 
                Musica.Stop();
            }
            else
            {
               
                var Musica = new SoundPlayer(Resources._Audio__CupheadIntroSongStudio__mp3cut_net_);
                isMuted = false;
                button2.Image = Properties.Resources.IS1; 
                Musica.Play();
                Musica.PlayLooping();
            }
        }
    }
}


