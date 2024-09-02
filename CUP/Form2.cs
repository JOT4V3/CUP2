using CUP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Media.SoundPlayer;



namespace CUP
{
    public partial class Form2 : Form
    {
        private bool isMuted = false;



        public Form2()
        {
            InitializeComponent();

            if (!isMuted)
            {
                
                var Musica = new SoundPlayer(Resources.Tutorial__Track_4__Theme___Cuphead__online_audio_converter_com_);
                isMuted = false;
                button3.Image = Properties.Resources.IS1;
                Musica.Play();
            }
            else
            {
                var Musica = new SoundPlayer(Resources.Tutorial__Track_4__Theme___Cuphead__online_audio_converter_com_);
                isMuted = true;
                button3.Image = Properties.Resources.IS3;
                Musica.Stop();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            if (comboBox1.SelectedIndex == 0)
            {


                if (!isMuted)
                {
                  
                    var Musica = new SoundPlayer(Resources.Inkwell_Isle_One__Track_6__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Isle_One__Track_6__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }


                    comboBox1.BackColor = Color.DarkGoldenrod;
                    comboBox1.ForeColor = Color.White;
                    button1.FlatAppearance.BorderColor = Color.White;
                    button1.ForeColor = Color.DarkGoldenrod;
                    button2.FlatAppearance.BorderColor = Color.White;
                    button2.ForeColor = Color.DarkGoldenrod;
                    label1.BackColor = Color.Transparent;
                    radioButton1.ForeColor = Color.White;
                    radioButton2.ForeColor = Color.White;
                    radioButton3.ForeColor = Color.White;
                    radioButton4.ForeColor = Color.White;
                    radioButton5.ForeColor = Color.White;
                    radioButton1.Text = "Geni Buarque";
                    radioButton2.Text = "Pânico Botânico";
                    radioButton3.Text = "Cactônio Spinoza";
                    radioButton4.Text = "Melecone";
                    radioButton5.Text = "Escoaxo e Sopapo";
                    this.BackgroundImage = Properties.Resources.ILHAT1;
                    pictureBox1.Image = Properties.Resources.LUA_120_x_120_px_;
                    pictureBox2.Image = Properties.Resources.LUA_120_x_120_px___2_;
                    pictureBox3.Image = Properties.Resources.LUA_120_x_120_px___1_;
                    pictureBox4.Image = Properties.Resources.LUA_120_x_120_px___3_;
                    pictureBox5.Image = Properties.Resources.LUA_120_x_120_px___4_;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                }
            
            else if (comboBox1.SelectedIndex == 1)
            {

                if (!isMuted)
                {
                
                    var Musica = new SoundPlayer(Resources.Porkrind_s_Shop__Track_35__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {         
                    var Musica = new SoundPlayer(Resources.Porkrind_s_Shop__Track_35__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                comboBox1.BackColor = Color.DimGray;
                comboBox1.ForeColor = Color.White;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.DimGray;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.DimGray;
                label1.BackColor = Color.Transparent;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton1.Text = "Tião Gavião";
                radioButton2.Text = "Algazarra Ardente";
                radioButton3.Text = "Zobo o Palhaço";
                radioButton4.Text = "Baronesa Bombom";
                radioButton5.Text = "Genésio o Magnífico";
                this.BackgroundImage = Properties.Resources.WP8;
                pictureBox1.Image = Properties.Resources._2ilha;
                pictureBox2.Image = Properties.Resources._2ilha__2_;
                pictureBox3.Image = Properties.Resources._2ilha__1_;
                pictureBox4.Image = Properties.Resources._2ilha__3_;
                pictureBox5.Image = Properties.Resources._2ilha__4_;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                if (!isMuted)
                {
                  
                    var Musica = new SoundPlayer(Resources.Inkwell_Isle_Three__Track_33__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Isle_Three__Track_33__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                comboBox1.BackColor = Color.Crimson;
                comboBox1.ForeColor = Color.White;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Crimson;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Crimson;
                label1.BackColor = Color.Transparent;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton1.Text = "Abélia Reale";
                radioButton2.Text = "Capitão Barba Salgada";
                radioButton3.Text = "Dona Lara";
                radioButton4.Text = "Dr.Kalo";
                radioButton5.Text = "Paula";
                this.BackgroundImage = Properties.Resources.ILHAT2;
                pictureBox1.Image = Properties.Resources.Abélia_Reale_icon;
                pictureBox2.Image = Properties.Resources.Capitao_Barba_Salgada_icon;
                pictureBox3.Image = Properties.Resources.Dona_Lara_icon;
                pictureBox4.Image = Properties.Resources.Dr_Kalo_icon;
                pictureBox5.Image = Properties.Resources.Paula_Prota_icon;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {

                if (!isMuted)
                {
                 
                    var Musica = new SoundPlayer(Resources.All_Bets_Are_Off__Track_46__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.All_Bets_Are_Off__Track_46__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                comboBox1.BackColor = Color.Gold;
                comboBox1.ForeColor = Color.DimGray;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Gold;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Gold;
                label1.BackColor = Color.Transparent;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton1.Text = "Phantom Express";
                radioButton2.Text = "";
                radioButton3.Text = "King Dice";
                radioButton4.Text = "";
                radioButton5.Text = "The Devil";
                this.BackgroundImage = Properties.Resources.OCASSINO;
                pictureBox1.Image = Properties.Resources.Phantom_Express_ico;
                pictureBox2.Image = null;
                pictureBox3.Image = Properties.Resources.KIng_Dice;
                pictureBox4.Image = null;
                pictureBox5.Image = Properties.Resources.The_Devil1;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = false;
                radioButton3.Visible = true;
                radioButton4.Visible = false;
                radioButton5.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            else if (comboBox1.Text == "")
            {
                if (!isMuted)
                {

                    var Musica = new SoundPlayer(Resources.Tutorial__Track_4__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Tutorial__Track_4__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                button3.Image = Properties.Resources.IS1;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                comboBox1.SelectedItem = null;
                BackgroundImage = Properties.Resources.WD1;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                groupBox1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                groupBox2.Visible = false;
                listBox1.ForeColor = Color.Gold;
                listBox1.BackColor = Color.DimGray;
                label1.BackColor = Color.Transparent;
                comboBox1.BackColor = Color.DimGray;
                comboBox1.ForeColor = Color.Gold;
                button1.FlatAppearance.BorderColor = Color.White;
                button2.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Gold;
                button2.ForeColor = Color.Gold;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
            }
            else if (comboBox1.Text == "ILHA TINTEIRO I")
            {
                comboBox1.BackColor = Color.DarkGoldenrod;
                comboBox1.ForeColor = Color.White;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.DarkGoldenrod;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.DarkGoldenrod;
                label1.BackColor = Color.Transparent;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton1.Text = "Geni Buarque";
                radioButton2.Text = "Pânico Botânico";
                radioButton3.Text = "Cactônio Spinoza";
                radioButton4.Text = "Melecone";
                radioButton5.Text = "Escoaxo e Sopapo";
                this.BackgroundImage = Properties.Resources.ILHAT1;
                pictureBox1.Image = Properties.Resources.LUA_120_x_120_px_;
                pictureBox2.Image = Properties.Resources.LUA_120_x_120_px___2_;
                pictureBox3.Image = Properties.Resources.LUA_120_x_120_px___1_;
                pictureBox4.Image = Properties.Resources.LUA_120_x_120_px___3_;
                pictureBox5.Image = Properties.Resources.LUA_120_x_120_px___4_;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            else if (comboBox1.Text == "ILHA TINTEIRO II")
            {
                comboBox1.BackColor = Color.Crimson;
                comboBox1.ForeColor = Color.White;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Crimson;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Crimson;
                label1.BackColor = Color.Transparent;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton1.Text = "Tião Gavião";
                radioButton2.Text = "Algazarra Ardente";
                radioButton3.Text = "Zobo o Palhaço";
                radioButton4.Text = "Baronesa Bombom";
                radioButton5.Text = "Genésio o Magnífico";
                this.BackgroundImage = Properties.Resources.ILHAT2;
                pictureBox1.Image = Properties.Resources._2ilha;
                pictureBox2.Image = Properties.Resources._2ilha__2_;
                pictureBox3.Image = Properties.Resources._2ilha__1_;
                pictureBox4.Image = Properties.Resources._2ilha__3_;
                pictureBox5.Image = Properties.Resources._2ilha__4_;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            else if (comboBox1.Text == "ILHA TINTEIRO III")
            {
                comboBox1.BackColor = Color.LightSlateGray;
                comboBox1.ForeColor = Color.White;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.LightCyan;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.LightCyan;
                label1.BackColor = Color.Transparent;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton1.Text = "Abélia Reale";
                radioButton2.Text = "Capitão Barba Salgada";
                radioButton3.Text = "Dona Lara";
                radioButton4.Text = "Dr.Kalo";
                radioButton5.Text = "Paula";
                this.BackgroundImage = Properties.Resources.ILHAT3;
                pictureBox1.Image = Properties.Resources.Abélia_Reale_icon;
                pictureBox2.Image = Properties.Resources.Capitao_Barba_Salgada_icon;
                pictureBox3.Image = Properties.Resources.Dona_Lara_icon;
                pictureBox4.Image = Properties.Resources.Dr_Kalo_icon;
                pictureBox5.Image = Properties.Resources.Paula_Prota_icon;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            else if (comboBox1.Text == "CASINO DO DIABO")
            {
                comboBox1.BackColor = Color.Gold;
                comboBox1.ForeColor = Color.DimGray;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Gold;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Gold;
                label1.BackColor = Color.Transparent;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton1.Text = "Phantom Express";
                radioButton2.Text = "";
                radioButton3.Text = "King Dice";
                radioButton4.Text = "";
                radioButton5.Text = "The Devil";
                this.BackgroundImage = Properties.Resources.OCASSINO;
                pictureBox1.Image = Properties.Resources.Phantom_Express_ico;
                pictureBox2.Image = null;
                pictureBox3.Image = Properties.Resources.KIng_Dice;
                pictureBox4.Image = null;
                pictureBox5.Image = Properties.Resources.The_Devil1;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = false;
                radioButton3.Visible = true;
                radioButton4.Visible = false;
                radioButton5.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            if (comboBox1.SelectedIndex == 0)
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Threatenin__Zeppelin__Track_10__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Threatenin__Zeppelin__Track_10__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }

                pictureBox6.Image = Properties.Resources.GENI1;
                pictureBox7.Image = Properties.Resources.GENI2;
                pictureBox8.Image = Properties.Resources.GENI3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.C_Buarque;
                comboBox1.BackColor = Color.Lavender;
                comboBox1.ForeColor = Color.Crimson;
                button1.FlatAppearance.BorderColor = Color.Lavender;
                button1.ForeColor = Color.Crimson;
                button2.FlatAppearance.BorderColor = Color.Lavender;
                button2.ForeColor = Color.Crimson;
                radioButton1.ForeColor = Color.Crimson;
                radioButton2.ForeColor = Color.Lavender;
                radioButton3.ForeColor = Color.Lavender;
                radioButton4.ForeColor = Color.Lavender;
                radioButton5.ForeColor = Color.Lavender;
                listBox1.ForeColor = Color.Crimson;
                listBox1.BackColor = Color.Lavender;
                checkBox1.ForeColor = Color.Crimson;
                checkBox2.ForeColor = Color.Crimson;
                checkBox3.ForeColor = Color.Crimson;
            }
            else if ((comboBox1.SelectedIndex == 1))
            {  
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Aviary_Action__Track_19__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Aviary_Action__Track_19__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.gaviao__3_;
                pictureBox7.Image = Properties.Resources.gaviao__2_;
                pictureBox8.Image = Properties.Resources.gaviao__1_;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.C_Tiao;
                comboBox1.BackColor = Color.Tan;
                comboBox1.ForeColor = Color.Brown;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Brown;
                button2.ForeColor = Color.Brown;
                button2.FlatAppearance.BorderColor = Color.White;
                radioButton1.ForeColor = Color.Brown;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                listBox1.ForeColor = Color.Brown;
                listBox1.BackColor = Color.Tan;
                checkBox1.ForeColor = Color.Brown;
                checkBox2.ForeColor = Color.Brown;
                checkBox3.ForeColor = Color.Brown;
            }
            else if ((comboBox1.SelectedIndex == 2))
            {
            
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Honeycomb_Herald__Track_34__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Honeycomb_Herald__Track_34__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.AScane1;
                pictureBox7.Image = Properties.Resources.AScane2;
                pictureBox8.Image = Properties.Resources.AScane3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.WP_Abélia_Reale;
                comboBox1.BackColor = Color.DarkGoldenrod;
                comboBox1.ForeColor = Color.Gold;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Gold;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Gold;
                radioButton1.ForeColor = Color.DarkGoldenrod;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                listBox1.ForeColor = Color.Gold;
                listBox1.BackColor = Color.DarkGoldenrod;
                checkBox1.ForeColor = Color.Gold;
                checkBox2.ForeColor = Color.Gold;
                checkBox3.ForeColor = Color.Gold;
            }
            else if ((comboBox1.SelectedIndex == 3))
            {
                
               
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Railroad_Wrath__Track_43__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Railroad_Wrath__Track_43__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.ExScane1;
                pictureBox7.Image = Properties.Resources.ExScane2;
                pictureBox8.Image = Properties.Resources.ExScane3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.WP_Phantom_Express;
                comboBox1.BackColor = Color.DimGray;
                comboBox1.ForeColor = Color.PaleTurquoise;
                button1.FlatAppearance.BorderColor = Color.DimGray;
                button1.ForeColor = Color.PaleTurquoise;
                button2.ForeColor = Color.PaleTurquoise;
                button2.FlatAppearance.BorderColor = Color.DimGray;
                radioButton1.ForeColor = Color.PaleTurquoise;
                radioButton2.ForeColor = Color.DimGray;
                radioButton3.ForeColor = Color.DimGray;
                radioButton4.ForeColor = Color.DimGray;
                radioButton5.ForeColor = Color.DimGray;
                listBox1.ForeColor = Color.PaleTurquoise;
                listBox1.BackColor = Color.DimGray;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            if (comboBox1.SelectedIndex == 0)
            {
           
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Botanic_Panic__Track_7__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Botanic_Panic__Track_7__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                groupBox1.Visible = true;
                pictureBox6.Image = Properties.Resources.BATATO;
                pictureBox7.Image = Properties.Resources.CEBOULA;
                pictureBox8.Image = Properties.Resources.CENOURA;
                this.BackgroundImage = Properties.Resources.C_Batato;
                label1.BackColor = Color.Transparent;
                comboBox1.BackColor = Color.Moccasin;
                comboBox1.ForeColor = Color.White;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Moccasin;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Moccasin;
                radioButton1.ForeColor = Color.Moccasin;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.Moccasin;
                radioButton4.ForeColor = Color.Moccasin;
                radioButton5.ForeColor = Color.Moccasin;
                listBox1.ForeColor = Color.White;
                listBox1.BackColor = Color.Moccasin;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
            }
            else if ((comboBox1.SelectedIndex == 1))
            {
             
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Fiery_Frolic__Track_22__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Fiery_Frolic__Track_22__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.Dragao1;
                pictureBox7.Image = Properties.Resources.Dragao2;
                pictureBox8.Image = Properties.Resources.Dragao3;
                this.BackgroundImage = Properties.Resources.C_Dragao;
                label1.BackColor = Color.Transparent;
                comboBox1.BackColor = Color.Azure;
                comboBox1.ForeColor = Color.Gray;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Azure;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Azure;
                radioButton1.ForeColor = Color.Azure;
                radioButton2.ForeColor = Color.Gray;
                radioButton3.ForeColor = Color.Azure;
                radioButton4.ForeColor = Color.Azure;
                radioButton5.ForeColor = Color.Azure;
                listBox1.ForeColor = Color.Gray;
                listBox1.BackColor = Color.Azure;
                checkBox1.ForeColor = Color.Azure;
                checkBox2.ForeColor = Color.Azure;
                checkBox3.ForeColor = Color.Azure;
            }
            else if ((comboBox1.SelectedIndex == 2))
            {
          
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Shootin_n__Lootin__Track_36__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Shootin_n__Lootin__Track_36__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.CPScane1;
                pictureBox7.Image = Properties.Resources.CPScane2;
                pictureBox8.Image = Properties.Resources.CPScane3;
                comboBox1.BackColor = Color.Gray;
                comboBox1.ForeColor = Color.Tomato;
                this.BackgroundImage = Properties.Resources.WP_Capitao_Barba_Salgada;
                button1.FlatAppearance.BorderColor = Color.Gray;
                button1.ForeColor = Color.Tomato;
                button2.FlatAppearance.BorderColor = Color.Gray;
                button2.ForeColor = Color.Tomato;
                radioButton1.ForeColor = Color.DimGray;
                radioButton2.ForeColor = Color.Tomato;
                radioButton3.ForeColor = Color.DimGray;
                radioButton4.ForeColor = Color.DimGray;
                radioButton5.ForeColor = Color.DimGray;
                listBox1.ForeColor = Color.Tomato;
                listBox1.BackColor = Color.Gray;
                checkBox1.ForeColor = Color.Tomato;
                checkBox2.ForeColor = Color.Tomato;
                checkBox3.ForeColor = Color.Tomato;
            }
            else if ((comboBox1.SelectedIndex == 3))
            {
                pictureBox6.Image = Properties.Resources.ExScane1;
                pictureBox7.Image = Properties.Resources.ExScane2;
                pictureBox8.Image = Properties.Resources.ExScane3;
                this.BackgroundImage = Properties.Resources.WP_Phantom_Express;
                comboBox1.BackColor = Color.DimGray;
                comboBox1.ForeColor = Color.PaleTurquoise;
                button1.FlatAppearance.BorderColor = Color.DimGray;
                button1.ForeColor = Color.PaleTurquoise;
                button2.ForeColor = Color.PaleTurquoise;
                button2.FlatAppearance.BorderColor = Color.DimGray;
                radioButton1.ForeColor = Color.PaleTurquoise;
                radioButton2.ForeColor = Color.DimGray;
                radioButton3.ForeColor = Color.DimGray;
                radioButton4.ForeColor = Color.DimGray;
                radioButton5.ForeColor = Color.DimGray;
                listBox1.ForeColor = Color.PaleTurquoise;
                listBox1.BackColor = Color.DimGray;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            if (comboBox1.SelectedIndex == 0)
            {
               
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Floral_Fury__Track_13__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Floral_Fury__Track_13__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                groupBox1.Visible = true;
                pictureBox6.Image = Properties.Resources.FLORA__3_;
                pictureBox7.Image = Properties.Resources.FLORA__2_;
                pictureBox8.Image = Properties.Resources.FLORA__1_;
                this.BackgroundImage = Properties.Resources.C_Florzinha;
                label1.BackColor = Color.Transparent;
                comboBox1.BackColor = Color.DarkGoldenrod;
                comboBox1.ForeColor = Color.Gold;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Gold;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Gold;
                radioButton1.ForeColor = Color.DarkGoldenrod;
                radioButton2.ForeColor = Color.DarkGoldenrod;
                radioButton3.ForeColor = Color.Goldenrod;
                radioButton4.ForeColor = Color.DarkGoldenrod;
                radioButton5.ForeColor = Color.DarkGoldenrod;
                listBox1.ForeColor = Color.Gold;
                listBox1.BackColor = Color.DarkGoldenrod;
                checkBox1.ForeColor = Color.Goldenrod;
                checkBox2.ForeColor = Color.Goldenrod;
                checkBox3.ForeColor = Color.Goldenrod;
            }
            else if ((comboBox1.SelectedIndex == 1))
            {
              
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Carnival_Kerfuffle__Track_21__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Carnival_Kerfuffle__Track_21__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.Sorisus1;
                pictureBox7.Image = Properties.Resources.Sorisus2;
                pictureBox8.Image = Properties.Resources.Sorisus3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.C_Palhaco;
                comboBox1.BackColor = Color.MediumPurple;
                comboBox1.ForeColor = Color.LavenderBlush;
                button1.FlatAppearance.BorderColor = Color.LavenderBlush;
                button1.ForeColor = Color.LavenderBlush;
                button2.FlatAppearance.BorderColor = Color.LavenderBlush;
                button2.ForeColor = Color.LavenderBlush;
                radioButton1.ForeColor = Color.LavenderBlush;
                radioButton2.ForeColor = Color.LavenderBlush;
                radioButton3.ForeColor = Color.LavenderBlush;
                radioButton4.ForeColor = Color.MediumPurple;
                radioButton5.ForeColor = Color.LavenderBlush;
                listBox1.ForeColor = Color.LavenderBlush;
                listBox1.BackColor = Color.MediumPurple;
                checkBox1.ForeColor = Color.MediumPurple;
                checkBox2.ForeColor = Color.MediumPurple;
                checkBox3.ForeColor = Color.MediumPurple;
            }
            else if ((comboBox1.SelectedIndex == 2))
            {
    
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.High_Sea_Hi_Jinx__Track_42__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.High_Sea_Hi_Jinx__Track_42__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.LScane1;
                pictureBox7.Image = Properties.Resources.LScane2;
                pictureBox8.Image = Properties.Resources.LScane3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.WP_Dona_Lara;
                comboBox1.BackColor = Color.Azure;
                comboBox1.ForeColor = Color.MediumPurple;
                button1.FlatAppearance.BorderColor = Color.MediumPurple;
                button1.ForeColor = Color.Azure;
                button2.FlatAppearance.BorderColor = Color.MediumPurple;
                button2.ForeColor = Color.Azure;
                radioButton1.ForeColor = Color.Azure;
                radioButton2.ForeColor = Color.Azure;
                radioButton3.ForeColor = Color.MediumPurple;
                radioButton4.ForeColor = Color.Azure;
                radioButton5.ForeColor = Color.Azure;
                listBox1.ForeColor = Color.MediumPurple;
                listBox1.BackColor = Color.Azure;
                checkBox1.ForeColor = Color.Azure;
                checkBox2.ForeColor = Color.Azure;
                checkBox3.ForeColor = Color.Azure;
            }
            else if ((comboBox1.SelectedIndex == 3))
            {
           
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.The_King_s_Court__Track_48__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.The_King_s_Court__Track_48__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.KD_Scane1;
                pictureBox7.Image = Properties.Resources.KD_Scane2;
                pictureBox8.Image = Properties.Resources.KD_Scane3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.WP_King_Dice;
                comboBox1.BackColor = Color.MediumPurple;
                comboBox1.ForeColor = Color.DarkSlateBlue;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.DarkSlateBlue;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.DarkSlateBlue;
                radioButton1.ForeColor = Color.LightGreen;
                radioButton2.ForeColor = Color.Transparent;
                radioButton3.ForeColor = Color.DarkGreen;
                radioButton4.ForeColor = Color.Transparent;
                radioButton5.ForeColor = Color.LightGreen;
                listBox1.ForeColor = Color.MediumPurple;
                listBox1.BackColor = Color.DarkSlateBlue;
                checkBox1.ForeColor = Color.LightGreen;
                checkBox2.ForeColor = Color.LightGreen;
                checkBox3.ForeColor = Color.LightGreen;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            if (comboBox1.SelectedIndex == 0)
            {
           
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Ruse_of_an_Ooze__Track_12__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Ruse_of_an_Ooze__Track_12__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                groupBox1.Visible = true;
                pictureBox6.Image = Properties.Resources.BOLA__4_;
                pictureBox7.Image = Properties.Resources.BOLA__6_;
                pictureBox8.Image = Properties.Resources.BOLA__5_;
                this.BackgroundImage = Properties.Resources.C_Bola;
                label1.BackColor = Color.Transparent;
                comboBox1.BackColor = Color.LightGray;
                comboBox1.ForeColor = Color.SteelBlue;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.SteelBlue;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.SteelBlue;
                radioButton1.ForeColor = Color.LightGray;
                radioButton2.ForeColor = Color.LightGray;
                radioButton3.ForeColor = Color.LightGray;
                radioButton4.ForeColor = Color.SteelBlue;
                radioButton5.ForeColor = Color.LightGray;
                listBox1.ForeColor = Color.SteelBlue;
                listBox1.BackColor = Color.LightGray;
                checkBox1.ForeColor = Color.SteelBlue;
                checkBox2.ForeColor = Color.SteelBlue;
                checkBox3.ForeColor = Color.SteelBlue;
            }
            else if ((comboBox1.SelectedIndex == 1))
            {
            
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Sugerland_Shimmy__Track_18__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Sugerland_Shimmy__Track_18__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.Ducinelia1;
                pictureBox7.Image = Properties.Resources.Ducinelia2;
                pictureBox8.Image = Properties.Resources.Ducinelia3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.C_Ducinélia;
                comboBox1.BackColor = Color.Plum;
                comboBox1.ForeColor = Color.Snow;
                button1.FlatAppearance.BorderColor = Color.Snow;
                button1.ForeColor = Color.Snow;
                button2.FlatAppearance.BorderColor = Color.Snow;
                button2.ForeColor = Color.Snow;
                radioButton1.ForeColor = Color.Snow;
                radioButton2.ForeColor = Color.Snow;
                radioButton3.ForeColor = Color.Snow;
                radioButton4.ForeColor = Color.Plum;
                radioButton5.ForeColor = Color.Snow;
                listBox1.ForeColor = Color.Snow;
                listBox1.BackColor = Color.Plum;
                checkBox1.ForeColor = Color.Plum;
                checkBox2.ForeColor = Color.Plum;
                checkBox3.ForeColor = Color.Plum;
            }
            else if ((comboBox1.SelectedIndex == 2))
            {
                
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Junkyard_Jive__Track_40__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Junkyard_Jive__Track_40__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.DrScane1;
                pictureBox7.Image = Properties.Resources.DrScane2;
                pictureBox8.Image = Properties.Resources.DrScane3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.WP_Dr_Kalo;
                comboBox1.BackColor = Color.CadetBlue;
                comboBox1.ForeColor = Color.LightGray;
                button1.FlatAppearance.BorderColor = Color.LightGray;
                button1.ForeColor = Color.CadetBlue;
                button2.FlatAppearance.BorderColor = Color.LightGray;
                button2.ForeColor = Color.CadetBlue;
                radioButton1.ForeColor = Color.CadetBlue;
                radioButton2.ForeColor = Color.CadetBlue;
                radioButton3.ForeColor = Color.CadetBlue;
                radioButton4.ForeColor = Color.LightGray;
                radioButton5.ForeColor = Color.CadetBlue;
                listBox1.ForeColor = Color.LightGray;
                listBox1.BackColor = Color.CadetBlue;
                checkBox1.ForeColor = Color.CadetBlue;
                checkBox2.ForeColor = Color.CadetBlue;
                checkBox3.ForeColor = Color.CadetBlue;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            if (comboBox1.SelectedIndex == 0)
            {
            
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Clip_Joint_Calamity__Track_15__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Clip_Joint_Calamity__Track_15__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                groupBox1.Visible = true;
                pictureBox6.Image = Properties.Resources.Sapaos__1_;
                pictureBox7.Image = Properties.Resources.Sapaos__3_;
                pictureBox8.Image = Properties.Resources.Sapaos__2_;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.C_Sopapos;
                comboBox1.BackColor = Color.LightGray;
                comboBox1.ForeColor = Color.Black;
                button1.FlatAppearance.BorderColor = Color.Black;
                button1.ForeColor = Color.LightGray;
                button2.FlatAppearance.BorderColor = Color.Black;
                button2.ForeColor = Color.LightGray;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.LightGray;
                listBox1.ForeColor = Color.Black;
                listBox1.BackColor = Color.LightGray;
                checkBox1.ForeColor = Color.LightGray;
                checkBox2.ForeColor = Color.LightGray;
                checkBox3.ForeColor = Color.LightGray;
            }
            else if ((comboBox1.SelectedIndex == 1))
            {
              
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Pyramid_Peril__Track_26__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Pyramid_Peril__Track_26__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.Aladim1;
                pictureBox7.Image = Properties.Resources.Aladim2;
                pictureBox8.Image = Properties.Resources.Aladim3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.C_Aladim;
                comboBox1.BackColor = Color.NavajoWhite;
                comboBox1.ForeColor = Color.SkyBlue;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.NavajoWhite;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.NavajoWhite;
                radioButton1.ForeColor = Color.SkyBlue;
                radioButton2.ForeColor = Color.SkyBlue;
                radioButton3.ForeColor = Color.SkyBlue;
                radioButton4.ForeColor = Color.SkyBlue;
                radioButton5.ForeColor = Color.NavajoWhite;
                listBox1.ForeColor = Color.SkyBlue;
                listBox1.BackColor = Color.NavajoWhite;
                checkBox1.ForeColor = Color.SkyBlue;
                checkBox2.ForeColor = Color.SkyBlue;
                checkBox3.ForeColor = Color.SkyBlue;
            }
            else if ((comboBox1.SelectedIndex == 2))
            {
              
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Dramatic_Fanatic__Track_37__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Dramatic_Fanatic__Track_37__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.P_Sacene1;
                pictureBox7.Image = Properties.Resources.P_Sacene2;
                pictureBox8.Image = Properties.Resources.P_Sacene3;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.WP_Paula_Prota;
                comboBox1.BackColor = Color.Teal;
                comboBox1.ForeColor = Color.Bisque;
                button1.FlatAppearance.BorderColor = Color.Bisque;
                button1.ForeColor = Color.Teal;
                button2.FlatAppearance.BorderColor = Color.Bisque;
                button2.ForeColor = Color.Teal;
                radioButton1.ForeColor = Color.Teal;
                radioButton2.ForeColor = Color.Teal;
                radioButton3.ForeColor = Color.Teal;
                radioButton4.ForeColor = Color.Teal;
                radioButton5.ForeColor = Color.Bisque;
                listBox1.ForeColor = Color.Bisque;
                listBox1.BackColor = Color.Teal;
                checkBox1.ForeColor = Color.Bisque;
                checkBox2.ForeColor = Color.Bisque;
                checkBox3.ForeColor = Color.Bisque;
            }
            else if ((comboBox1.SelectedIndex == 3))
            {
                
                
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Hell_Piano__Track_49__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Hell_Piano__Track_49__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                pictureBox6.Image = Properties.Resources.DemonScane1;
                pictureBox7.Image = Properties.Resources.DemonScane2;
                pictureBox8.Image = Properties.Resources.DemonScane3;
                pictureBox5.Image = Properties.Resources.The_Devil2;
                label1.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.WP_Demon;
                comboBox1.BackColor = Color.Maroon;
                comboBox1.ForeColor = Color.Goldenrod;
                button1.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.Goldenrod;
                button2.FlatAppearance.BorderColor = Color.White;
                button2.ForeColor = Color.Goldenrod;
                radioButton1.ForeColor = Color.Maroon;
                radioButton2.ForeColor = Color.Maroon;
                radioButton3.ForeColor = Color.Maroon;
                radioButton4.ForeColor = Color.Maroon;
                radioButton5.ForeColor = Color.Goldenrod;
                listBox1.ForeColor = Color.Goldenrod;
                listBox1.BackColor = Color.Maroon;
                checkBox1.ForeColor = Color.Maroon;
                checkBox2.ForeColor = Color.Maroon;
                checkBox3.ForeColor = Color.Maroon;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dificuldade;
            dificuldade = listBox1.Text;
            switch (dificuldade)
            {
                case "SIMPLES":
                    
                    MessageBox.Show("SIMPLES uma dificuldade para iniciantes. Você deveria aumentar a dificuldade para ver mais dos bosses.", "SIMPLES");
                    groupBox2.Visible = true;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    checkBox1.Visible = true;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    break;
                case "REGULAR":
                    MessageBox.Show("REGULAR para jogadores em evolução. Aumente a dificuldade para ir além.","REGULAR");
                    groupBox2.Visible = true;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    checkBox3.Visible = false;
                    break;
                case "EXPERT":
                    MessageBox.Show("EXPERT para jogadores ja familiarizados com dificuldades e com uma boa experiencia. Agora você pode ver tudo!!!","EXPERT");
                    groupBox2.Visible = true;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    checkBox3.Visible = true;
                    break;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            if (checkBox1.Checked == false)
            { pictureBox6.Visible = false; }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            if (checkBox2.Checked == false)
            { pictureBox7.Visible = false; }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            if (checkBox3.Checked == false)
            { pictureBox8.Visible = false; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja sair?", "Leave Cuphead?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();

                }
                else
                {
                    //nao faz nada
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Musica = new SoundPlayer(Resources.Tutorial__Track_4__Theme___Cuphead__online_audio_converter_com_);
            comboBox1.Text = "";
            button3.Image = Properties.Resources.IS1;
            Musica.Play();
            Musica.PlayLooping();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.SelectedItem = null;
            BackgroundImage = Properties.Resources.WD1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            groupBox1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            groupBox2.Visible = false;
            listBox1.ForeColor = Color.Gold;
            listBox1.BackColor = Color.DimGray;
            label1.BackColor = Color.Transparent;
            comboBox1.BackColor = Color.DimGray;
            comboBox1.ForeColor = Color.Gold;
            button1.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.White;
            button1.ForeColor = Color.Gold;
            button2.ForeColor = Color.Gold;
            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;
            radioButton3.ForeColor = Color.White;
            radioButton4.ForeColor = Color.White;
            radioButton5.ForeColor = Color.White;
            checkBox1.ForeColor = Color.White;
            checkBox2.ForeColor = Color.White;
            checkBox3.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            if ( radioButton1.Checked == true && radioButton1.Text == "Geni Buarque")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Threatenin__Zeppelin__Track_10__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Threatenin__Zeppelin__Track_10__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
          else if ( radioButton2.Checked == true && radioButton2.Text == "Pânico Botânico")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Botanic_Panic__Track_7__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Botanic_Panic__Track_7__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
           else if ( radioButton3.Checked == true && radioButton3.Text == "Cactônio Spinoza")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Floral_Fury__Track_13__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Floral_Fury__Track_13__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
           else if ( radioButton4.Checked == true && radioButton4.Text == "Melecone")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Ruse_of_an_Ooze__Track_12__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Ruse_of_an_Ooze__Track_12__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
           else if (radioButton5.Checked == true && radioButton5.Text == "Escoaxo e Sopapo")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Clip_Joint_Calamity__Track_15__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Clip_Joint_Calamity__Track_15__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Isle_One__Track_6__Theme___Cuphead__online_audio_converter_com_);

                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Isle_One__Track_6__Theme___Cuphead__online_audio_converter_com_);

                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
            if ( radioButton1.Checked == true && radioButton1.Text == "Tião Gavião")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Aviary_Action__Track_19__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Aviary_Action__Track_19__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
            else if (radioButton2.Checked == true && radioButton2.Text == "Algazarra Ardente")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Fiery_Frolic__Track_22__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Fiery_Frolic__Track_22__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
            else if (radioButton3.Checked == true && radioButton3.Text == "Zobo o Palhaço")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Carnival_Kerfuffle__Track_21__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Carnival_Kerfuffle__Track_21__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
            else if (radioButton4.Checked == true && radioButton4.Text == "Baronesa Bombom")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Sugerland_Shimmy__Track_18__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Sugerland_Shimmy__Track_18__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
            else if (radioButton5.Checked == true && radioButton5.Text == "Genésio o Magnífico")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Pyramid_Peril__Track_26__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Pyramid_Peril__Track_26__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {


                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Porkrind_s_Shop__Track_35__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.Porkrind_s_Shop__Track_35__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
           
            else if (radioButton1.Checked == true && radioButton1.Text == "Abélia Reale")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Honeycomb_Herald__Track_34__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.Honeycomb_Herald__Track_34__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
            else if (radioButton2.Checked == true && radioButton2.Text == "Capitão Barba Salgada")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Shootin_n__Lootin__Track_36__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.Shootin_n__Lootin__Track_36__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
            else if (radioButton3.Checked == true && radioButton3.Text == "Dona Lara")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.High_Sea_Hi_Jinx__Track_42__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.High_Sea_Hi_Jinx__Track_42__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
            else if ( radioButton4.Checked == true && radioButton4.Text == "Dr.Kalo")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Junkyard_Jive__Track_40__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.Junkyard_Jive__Track_40__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
            else if ( radioButton5.Checked == true && radioButton5.Text == "Paula")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Dramatic_Fanatic__Track_37__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.Dramatic_Fanatic__Track_37__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }

            else if (comboBox1.SelectedIndex == 2)
            {

                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Isle_Three__Track_33__Theme___Cuphead);

                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Isle_Three__Track_33__Theme___Cuphead);

                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
           
            else if ( radioButton1.Checked == true && radioButton1.Text == "Phantom Express")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Railroad_Wrath__Track_43__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.Railroad_Wrath__Track_43__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
            
            else if ( radioButton3.Checked == true && radioButton3.Text == "King Dice")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.The_King_s_Court__Track_48__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.The_King_s_Court__Track_48__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
            
            else if (  radioButton5.Checked == true && radioButton5.Text == "The Devil")
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Inkwell_Hell_Piano__Track_49__Theme___Cuphead);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {

                    var Musica = new SoundPlayer(Resources.Inkwell_Hell_Piano__Track_49__Theme___Cuphead);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {

                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.All_Bets_Are_Off__Track_46__Theme___Cuphead);

                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.All_Bets_Are_Off__Track_46__Theme___Cuphead);

                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                    Musica.PlayLooping();
                }



            }
            else if(comboBox1.Text == "") 
            {
                if (!isMuted)
                {
                    var Musica = new SoundPlayer(Resources.Tutorial__Track_4__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = true;
                    button3.Image = Properties.Resources.IS3;
                    Musica.Stop();
                }
                else
                {
                    var Musica = new SoundPlayer(Resources.Tutorial__Track_4__Theme___Cuphead__online_audio_converter_com_);
                    isMuted = false;
                    button3.Image = Properties.Resources.IS1;
                    Musica.Play();
                }
            }
            


            
        }
    }
}



