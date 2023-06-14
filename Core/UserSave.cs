using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWMM2.Core
{

    internal class UserSave
    {
        public string GamePath = "Unset";
        public GameType GameType;

        public static UserSave CurrentSave {
            get
            {
                if(_currentSave == null)
                {
                    var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    var path = Path.Combine(appData, "CWMM.json");

                    if (!File.Exists(path))
                    {
                        _currentSave = new UserSave();
                        _currentSave.Save();
                    } else
                    {
                        var json = File.ReadAllText(path);
                        _currentSave = JsonConvert.DeserializeObject<UserSave>(json);
                    }
                }
                return _currentSave;
            }
        }
        private static UserSave? _currentSave;

        public void Save()
        {
            var json = JsonConvert.SerializeObject(_currentSave, Formatting.Indented);
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(appData, "CWMM.json");
            File.WriteAllText(path, json);
        }
    }

    public enum GameType
    {
        Steam,
        Epic
    }
}
