using System;
using System.IO;

namespace MobTime
{
    static class Config
    {
        /// <summary>
        /// Saves in the local application data folder as mob-time.conf.
        /// </summary>
        public static void Save(int duration)
        {
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            filename = Path.Combine(filename, "mob-time.conf");
            try
            {
                File.WriteAllText(filename, duration.ToString());
            }
            catch { }
        }

        /// <summary>
        /// Loads from the local application data folder file named mob-time.conf.
        /// </summary>
        public static int Load(int defaultDuration)
        {
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            filename = Path.Combine(filename, "mob-time.conf");
            try
            {
                var txt = File.ReadAllText(filename);
                return int.Parse(txt.Trim());
            }
            catch { }
            return defaultDuration;
        }
    }
}
