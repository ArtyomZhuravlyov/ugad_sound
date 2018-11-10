using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ugad_sound
{
    static class GAME
    {
        public static List<string> list = new List<string>();
        public static int GameDuration = 60;
        public static int musicDuration = 10;
        public static bool randomStart = false;
        public static string lastFolder = "C:\\";
        public static bool nazad = false;
        public static bool end_game_prog_bar = false;

        public static void ReadMusic()
        {
            try
            { 
            string[] music_files = System.IO.Directory.GetFiles(lastFolder, "*.mp3");
            list.Clear();
            list.AddRange(music_files);
            }
            catch
            {

            }
        }

        static public string regKeyName = "Software\\MyCompany\\Victorina";

        public static void WriteParam()
        {
            Microsoft.Win32.RegistryKey rk = null;
            try
            {
                rk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regKeyName);

                if (rk == null) return;

                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("Random", randomStart);
                rk.SetValue("GameDuration", GameDuration);
                rk.SetValue("musicDuration", musicDuration);
                int mmm = 4;
                rk.SetValue("po pricolu", mmm);

            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }

        public static void ReadParam()
        {
            Microsoft.Win32.RegistryKey rk = null;
            try
            {
                rk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regKeyName);

                if (rk == null) return;
                
                    lastFolder = (string)rk.GetValue("LastFolder");
                    randomStart = Convert.ToBoolean(rk.GetValue("Random")); // ("Random", false)
                    GameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("musicDuration");

                
            }
            catch
            {

            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }



    }
}
