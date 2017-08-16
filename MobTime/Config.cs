using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MobTime
{
    struct Options
    {
        public bool CountUpwards;
        public int Duration;
        public bool DimOnLeave;
    }

    static class Config
    {
        private const string filename = "mob-time.ini";

        /// <summary>
        /// Saves in the local application data folder as mob-time.ini.
        /// </summary>
        public static void Save(Options options)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var fullpath = Path.Combine(folder, filename);
            var ini = new StringBuilder();
            ini.AppendLine("[COUNTER]");
            ini.AppendLine("Upwards = " + options.CountUpwards.ToString());
            ini.AppendLine("Minutes = " + options.Duration.ToString());
            ini.AppendLine("");
            ini.AppendLine("[DISPLAY]");
            ini.AppendLine("# should Mob Time dim when it is not the active window?");
            ini.AppendLine("Dim = " + options.DimOnLeave.ToString());
            try
            {
                File.WriteAllText(fullpath, ini.ToString());
            }
            catch { }
        }

        /// <summary>
        /// Loads from the local application data folder file named mob-time.ini.
        /// </summary>
        public static Options Load(Options defaults)
        {
            var options = defaults;
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var fullpath = Path.Combine(folder, filename);
            try
            {
                var values = Ini.File.Load(fullpath);
                options.CountUpwards = Ini.File.GetSetting(values, "COUNTER", "UPWARDS", defaults.CountUpwards);
                options.Duration = Ini.File.GetSetting(values, "COUNTER", "MINUTES", defaults.Duration);
                options.DimOnLeave = Ini.File.GetSetting(values, "DISPLAY", "DIM", defaults.DimOnLeave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return options;
        }
    }
}
