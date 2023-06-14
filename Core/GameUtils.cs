using AssetsTools.NET.Extra;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWMM2.Core
{
    internal static class GameUtils
    {
        public static string DetermineGameVersion()
        {
            var am = new AssetsManager();
            am.LoadClassPackage("classdata.tpk");

            var ggmPath = Path.Combine(UserSave.CurrentSave.GamePath, "SpiderHeckApp_Data", "globalgamemanagers");
            var ggm = am.LoadAssetsFile(ggmPath, true);

            am.LoadClassDatabaseFromPackage(ggm.file.Metadata.UnityVersion);
            
            var versionAssetInfo = ggm.file.GetAssetsOfType(AssetClassID.PlayerSettings).First();
            var versionAsset = am.GetBaseField(ggm, versionAssetInfo);

            return versionAsset["bundleVersion"].AsString;
        }
    }
}
