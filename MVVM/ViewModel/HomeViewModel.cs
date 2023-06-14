using CWMM2.Core;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CWMM2.MVVM.ViewModel
{
    internal class HomeViewModel
    {
        public string GameVersion { get; private set; }
        public string GameType => $"Installed via {UserSave.CurrentSave.GameType}";
        public string ModCount => $"0 mods installed";
        public IEnumerable<ModNews> NewsList => ModNews.Fetch(true).OrderBy(mn => mn.id);
        public RelayCommand OpenNewsLinkCommand { get; private set; }
        public RelayCommand OpenGameCommand { get; private set; }

        public HomeViewModel()
        {
            GameVersion = "Version " + GameUtils.DetermineGameVersion();
            OpenNewsLinkCommand = new RelayCommand(o =>
            {
                Utils.OpenLink((string)o);
            });
            OpenGameCommand = new RelayCommand((o) =>
            {
                if(UserSave.CurrentSave.GameType == Core.GameType.Steam)
                {
                    Utils.OpenLink("steam://rungameid/1329500");
                } else
                {
                    MessageBox.Show($"Can't auto-launch SpiderHeck from {UserSave.CurrentSave.GameType} yet!");
                }
            });
        }
    }
}
