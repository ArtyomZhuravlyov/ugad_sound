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

namespace ugad_sound
{
    public partial class Fgame : Form
    {
        Random rnd = new Random();
        int count_lable2 = 0; //введено для плавного прогресс бара
        int count_sec_on_answer;
        bool[] players = new bool[2];
       //public bool nazad = false;

        public Fgame()
        {
            InitializeComponent();
        }

        void Make_music()
        {
            if (GAME.list.Count == 0) EndGame();
            else
            {
                int n = rnd.Next(0, GAME.list.Count); // записываем рандомное число от 0 до кол-ва песен в list
                WMP.URL = GAME.list[n]; //записываем рандомную песню песню
                                        //   WMP.Ctlcontrols.play(); // запуск ВМплейер, если отсвутсвует автозапуск
                GAME.list.RemoveAt(n); //удаление песни из списка (чтобы не повторялась)
                lb_count_music.Text = GAME.list.Count.ToString();
            }
            if (GAME.end_game_prog_bar == true)
            {
                lb_counter1.Text = "0";
                lb_counter2.Text = "0";
                GAME.end_game_prog_bar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Make_music();
                timer1.Start();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Fgame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
            GAME.nazad = false;
        }

        private void Fgame_Load(object sender, EventArgs e)
        {
            
            lb_count_music.Text = GAME.list.Count.ToString();
            progressBar_music.Maximum = GAME.GameDuration * 2;// ; // умножил на 2 чтобы сделать 
                   //плавным прогресс бар (в таймере стоит 500 вместо 1000)
            progressBar_music.Value = 0;
            progressBar_music.Minimum = 0;
            label4.Text = (progressBar_music.Maximum / 2).ToString();
            count_sec_on_answer = GAME.musicDuration;
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              progressBar_music.Value++;
            // progressBar_music.Value += 0.1f ; //нельзя преобразовать в флоат
            // int bb = Convert.ToInt32(label2.Text); 
            if ((progressBar_music.Value % 2) == 1)
            { // label2.Text = progressBar_music.Value.ToString();
                count_lable2++;
                label2.Text = count_lable2.ToString();
            }

            if (progressBar_music.Value == progressBar_music.Maximum)
            {
                EndGame();
                
            }
            
            
        }

        void EndGame()
        {
            timer1.Stop();
            progressBar_music.Value = 0;
            WMP.Ctlcontrols.stop();
            SoundPlayer sp = new SoundPlayer("Resources\\ricochet.wav"); //чтобы не указывать весь путь нужно в свойствах ricochet.wav выставить (еопировать более позднюю версию)
            sp.Play();
            progressBar_music.Value = 0;
            count_lable2 = 0;
            GAME.end_game_prog_bar = true;




        }

        private void progressBar_music_Click(object sender, EventArgs e)
        {

        }

        private void bt_pause_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void bt_continue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void pause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }
        private void Fgame_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == false) return; // если таймер не активен (игра не началась) то и нажимать кнопки нет смысла
            count_sec_on_answer = GAME.musicDuration;
            if (e.KeyData == Keys.A)
            {

                timer2.Start();
                pause();
                if (MessageBox.Show("правильный ответ?", "игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lb_counter1.Text = (Convert.ToInt32(lb_counter1.Text) + 1).ToString();
                    //  lb_counter1.Text =Convert.ToString (Convert.ToInt32(lb_counter1.Text) + 1).ToString(); ещё один вариант
                    
                }
                timer2.Stop();

            }

            if (e.KeyData == Keys.L)
            {
                timer2.Start();
                pause();
                if (MessageBox.Show("правильный ответ?", "игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lb_counter2.Text = (Convert.ToInt32(lb_counter2.Text) + 1).ToString();
                  
                }
                timer2.Stop();
            }

            Make_music();
            timer1.Start();
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (GAME.randomStart == true)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2); 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count_sec_on_answer--;
            if (count_sec_on_answer == 0)
            {
                SoundPlayer sp = new SoundPlayer("Resources\\ricochet.wav"); //чтобы не указывать весь путь нужно в свойствах ricochet.wav выставить (еопировать более позднюю версию)
                sp.Play();
               
            } 


        }

        private void bt_ago_Click(object sender, EventArgs e)
        {
            pause();
            //  this.Opacity = 0;
            // this.Hide();
            // this.ControlBox = false;
            this.Visible = false;
            GAME.nazad = true;
            
            
        }

        private void lb_counter1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) (sender as Label).Text = (Convert.ToInt32((sender as Label).Text) + 1).ToString();
            if (e.Button == MouseButtons.Right) lb_counter1.Text = (Convert.ToInt32(lb_counter1.Text) - 1).ToString();
        }
    }
}
//взять название песни из медиа плейр
//answear = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);