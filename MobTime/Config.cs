using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MobTime
{
    static class Config
    {
        /// <summary>
        /// Saves in the local application data folder as mob-time.ini.
        /// </summary>
        public static void Save(int duration)
        {
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            filename = Path.Combine(filename, "mob-time.ini");
            var ini = new StringBuilder();
            ini.AppendLine("[COUNTER]");
            ini.AppendLine("Minutes = " + duration.ToString());
            try
            {
                File.WriteAllText(filename, ini.ToString());
            }
            catch { }
        }

        /// <summary>
        /// Loads from the local application data folder file named mob-time.ini.
        /// </summary>
        public static int Load(int defaultDuration)
        {
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            filename = Path.Combine(filename, "mob-time.ini");
            try
            {
                var values = Ini.File.Load(filename);
                return Ini.File.GetSetting(values, "COUNTER", "MINUTES", defaultDuration);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return defaultDuration;
        }
    }
}
