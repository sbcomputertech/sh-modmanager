using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CWMM2.Core
{
    internal class ModIndex
    {
        public string name { get; set; }
        public string guid { get; set; }
        public string version { get; set; }
        public string author { get; set; }
        public string source { get; set; }
        public string binary { get; set; }

        public static List<ModIndex>? Fetch(bool local = false)
        {
            if (local)
            {
                var json = File.ReadAllText("mods.json");
                return JsonConvert.DeserializeObject<List<ModIndex>>(json);
            }
            // TODO: Fetch from gh repo file
            return null;
        }
    }
}
