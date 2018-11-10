using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ugad_sound
{
    public partial class fmenu : Form
    {
        Fgame fg = new Fgame();

        public fmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Fsetting fb = new Fsetting();
            fb.Show();
        }

        private void btn_game_Click(object sender, EventArgs e)
        {

            //  Hide();
            if (GAME.nazad == true)
            {
                try
                {
                    fg.Visible = true; //если окно игры сварачивалось
                }

                catch
                {
                    GAME.nazad = false;
                    Fgame fg = new Fgame();
                    fg.Visible = true; //если окно игры сварачивалось
                }
            }
            else
            {
                try
                {
                    fg.ShowDialog();
                }
                catch
                { Fgame fg = new Fgame();
                    fg.ShowDialog();
                }
            }

            //fg.Opacity = 0;

        }

        private void fmenu_Load(object sender, EventArgs e)
        {
            GAME.ReadParam();
            GAME.ReadMusic();
            
        }

        private void fmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
