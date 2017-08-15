using System;
using System.IO;

namespace MobTime
{
    static class Config
    {
        public static void Save(int duration)
        {
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            filename = Path.Combine(filename, "mob-time.conf");
            try
            {
                System.IO.File.WriteAllText(filename, duration.ToString());
            }
            catch { }
        }

        public static int Load(int defaultDuration)
        {
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            filename = Path.Combine(filename, "mob-time.conf");
            try
            {
                var txt = System.IO.File.ReadAllText(filename);
                return int.Parse(txt.Trim());
            }
            catch { }
            return defaultDuration;
        }
    }
}
