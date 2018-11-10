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
    public partial class Fsetting : Form
    {
        public Fsetting()
        {
            InitializeComponent();
            
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
           if( fbd.ShowDialog() == DialogResult.OK) //очень важно(иначе исключения и ошибки)
            { 
            string[] music_list = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3");
                GAME.lastFolder = fbd.SelectedPath;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(music_list);
                GAME.list.Clear();
                GAME.list.AddRange(music_list);

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GAME.musicDuration = Convert.ToInt32(cb_answear.Text);
            GAME.GameDuration = Convert.ToInt32(cbdeep.Text); 
            GAME.randomStart = check_random_start.Checked;
            GAME.WriteParam();
            this.Hide();
           //close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbdeep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Fsetting_Load(object sender, EventArgs e)
        {
            cbdeep.Text = GAME.GameDuration.ToString();
            cb_answear.Text = GAME.musicDuration.ToString();
            check_random_start.Checked = GAME.randomStart;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(GAME.list.ToArray());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
/* можно, но показали вариант лучше
//считывание с рееста данных и вставка их в ниспадающие боксы при заходе в настройки
Microsoft.Win32.RegistryKey fk = null;
            try
            {
                fk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(GAME.regKeyName);

                if (fk == null) return;
                { 
                    cbdeep.Text = Convert.ToString(fk.GetValue("GameDuration")); // ("Random", false)
                    cb_answear.Text = Convert.ToString(fk.GetValue("musicDuration")); 
                    check_random_start.Checked = Convert.ToBoolean(fk.GetValue("Random"));
                }
            }
            finally
            {
                if (fk != null) fk.Close();
            }
            */