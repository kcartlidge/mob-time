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
    }

    static class Config
    {
        /// <summary>
        /// Saves in the local application data folder as mob-time.ini.
        /// </summary>
        public static void Save(Options options)
        {
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            filename = Path.Combine(filename, "mob-time.ini");
            var ini = new StringBuilder();
            ini.AppendLine("[COUNTER]");
            ini.AppendLine("Upwards = " + (options.CountUpwards.ToString().ToLower()));
            ini.AppendLine("Minutes = " + options.Duration.ToString());
            try
            {
                File.WriteAllText(filename, ini.ToString());
            }
            catch { }
        }

        /// <summary>
        /// Loads from the local application data folder file named mob-time.ini.
        /// </summary>
        public static Options Load(Options defaults)
        {
            var options = new Options
            {
                Duration = defaults.Duration,
            };
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            filename = Path.Combine(filename, "mob-time.ini");
            try
            {
                var values = Ini.File.Load(filename);
                options.CountUpwards = Ini.File.GetSetting(values, "COUNTER", "UPWARDS", defaults.CountUpwards.ToString()).ToLower() == "true";
                options.Duration = Ini.File.GetSetting(values, "COUNTER", "MINUTES", defaults.Duration);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return options;
        }
    }
}
