using System.Collections.Generic;

namespace MobTime.Ini
{
    public class Section
    {
        public string Name { get; set; }
        public SortedList<string, Setting> Entries { get; set; }
    }

    public class Setting
    {
        public int LineNumber { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{LineNumber}: {Key} = {Value}";
        }
    }
}
