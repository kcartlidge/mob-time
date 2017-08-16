using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MobTime.Ini
{
    static class File
    {
        /// <summary>
        /// Loads the contents of a file in INI format.
        /// Understands sections, keys, values and comments.
        /// Case-insensitive sections and keys.
        /// </summary>
        /// <param name="filename">File to load the settings from.</param>
        /// <param name="warnings">Optional callback to receive content warnings (errors throw).</param>
        /// <returns></returns>
        public static SortedList<string, Section> Load(string filename, Action<int,string,string> warnings = null)
        {
            var current = "DEFAULT";
            var section = new Section()
            {
                Name = current,
                Entries = new SortedList<string, Setting>(),
            };
            var sections = new SortedList<string, Section>() { };
            sections.Add(current, section);

            var sep = "=".ToCharArray();
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                using (var f = new StreamReader(stream, Encoding.UTF8))
                {
                    var lnum = 0;
                    while (!f.EndOfStream)
                    {
                        lnum += 1;
                        var line = f.ReadLine().Trim();
                        if (line.Length == 0 || line.StartsWith("#"))
                        {
                            continue;
                        }
                        if (line.StartsWith("[") && line.EndsWith("]"))
                        {
                            var newSection = line.Substring(1, line.IndexOf("]") - 1).Trim();
                            if (newSection.Length == 0)
                            {
                                throw new Exception($"ini:{lnum} - bad section name");
                            }
                            newSection = newSection.ToUpper();
                            if (sections.ContainsKey(newSection))
                            {
                                throw new Exception($"ini:{lnum} - duplicate section name: {newSection}");
                            }
                            current = newSection;
                            sections.Add(current, new Section()
                            {
                                Name = current,
                                Entries = new SortedList<string, Setting>(),
                            });
                            continue;
                        }
                        var bits = line.Split(sep, 2);
                        if (bits.Length != 2)
                        {
                            throw new Exception($"ini:{lnum} - expected key = value");
                        }
                        bits[0] = bits[0].Trim();
                        if (bits[0].Length == 0)
                        {
                            throw new Exception($"ini:{lnum} - missing key");
                        }
                        var originalKey = bits[0];
                        bits[0] = bits[0].ToUpper();
                        bits[1] = bits[1].Trim();
                        if (bits[1].Length == 0)
                        {
                            warnings?.Invoke(lnum, bits[0], "missing value");
                        }
                        if (sections[current].Entries.ContainsKey(bits[0]))
                        {
                            warnings?.Invoke(lnum, bits[0], "duplicate key");
                        }
                        var newSetting = new Setting()
                        {
                            LineNumber = lnum,
                            Key = originalKey,
                            Value = bits[1],
                        };
                        sections[current].Entries[bits[0]] = newSetting;
                    }
                }
            }
            return sections;
        }

        /// <summary>
        /// Retrieve a setting by section and key (case-insensitive).
        /// </summary>
        /// <param name="iniValues">The values obtained from a call to Load.</param>
        /// <returns>Either a Setting object or null if not found.</returns>
        public static Setting GetSetting(SortedList<string, Section> iniValues, string section, string key)
        {
            var upperSection = section.ToUpper();
            var upperKey = key.ToUpper();

            if (iniValues.ContainsKey(upperSection))
            {
                var settings = iniValues[upperSection];
                if (settings.Entries.ContainsKey(upperKey))
                {
                    return settings.Entries[upperKey];
                }
            }
            return null;
        }

        /// <summary>
        /// Retrieve the string value of a setting by section and key (case-insensitive).
        /// </summary>
        /// <param name="iniValues">The values obtained from a call to Load.</param>
        /// <returns>Either a Setting object or the default value if not found.</returns>
        public static string GetSetting(SortedList<string, Section> iniValues, string section, string key, string defaultValue)
        {
            var setting = GetSetting(iniValues, section, key);
            if (setting == null)
            {
                return defaultValue;
            }
            return (setting.Value ?? string.Empty).Trim();
        }

        /// <summary>
        /// Retrieve the integer value of a setting by section and key (case-insensitive).
        /// </summary>
        /// <param name="iniValues">The values obtained from a call to Load.</param>
        /// <returns>Either a Setting object or the default value if not found.</returns>
        public static int GetSetting(SortedList<string, Section> iniValues, string section, string key, int defaultValue)
        {
            var setting = GetSetting(iniValues, section, key);
            if (setting == null)
            {
                return defaultValue;
            }
            if (int.TryParse(setting.Value, out int result))
            {
                return result;
            }
            return defaultValue;
        }

        /// <summary>
        /// Retrieve the boolean value of a setting by section and key (case-insensitive).
        /// </summary>
        /// <param name="iniValues">The values obtained from a call to Load.</param>
        /// <returns>Either a Setting object or the default value if not found.</returns>
        public static bool GetSetting(SortedList<string, Section> iniValues, string section, string key, bool defaultValue)
        {
            var setting = GetSetting(iniValues, section, key);
            if (setting == null)
            {
                return defaultValue;
            }
            if (bool.TryParse(setting.Value, out bool result))
            {
                return result;
            }
            return defaultValue;
        }
    }
}