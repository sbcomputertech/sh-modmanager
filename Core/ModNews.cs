using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CWMM2.Core
{
    internal class ModNews
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string clickLink { get; set; }

        public static List<ModNews>? Fetch(bool local = false)
        {
            if(local)
            {
                var json = File.ReadAllText("news.json");
                return JsonConvert.DeserializeObject<List<ModNews>>(json);
            }
            // TODO: Fetch from gh repo file
            return null;
        }
    }
}
