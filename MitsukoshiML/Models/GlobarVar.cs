using MitsukoshiML.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitsukoshiML.Models
{
    public class GlobarVar
    {
        public static SettingsWriter _settings = new SettingsWriter(Path.Combine(Application.StartupPath, "Settings"), false);
        public static Configuration _systemConfig = new Configuration();

        static string Contno, POS, Compname, XML, Post, Get, APIKey, SecrKey = null;

        public static void InitializeConfiguration()
        {
            _systemConfig = _settings.Read<Configuration>("Configuration");
            if (_systemConfig != null)
            {

                Contno = _systemConfig.ContractNo.Trim().ToString();
                POS = _systemConfig.POSNo.Trim().ToString();
                Compname = _systemConfig.CompanyName.Trim().ToString();
                XML = _systemConfig.XMLPath.Trim().ToString();
                Post = _systemConfig.PostAPI.Trim().ToString();
                Get = _systemConfig.GetAPI.Trim().ToString();
                APIKey = _systemConfig.APIKey.Trim().ToString();
                SecrKey = _systemConfig.SecretKey.Trim().ToString();

            }
        }

        public static string ContractNo { get => Contno; set => Contno = value.ToString(); }
        public static string POSno { get => POS; set => POS = value.ToString(); }
        public static string CmpnyName { get => Compname; set => Compname = value.ToString(); }
        public static string XMLPath { get => XML; set => XML = value.ToString(); }
        public static string POSTAPI { get => Post; set => Post = value.ToString(); }
        public static string GETAPI { get => Get; set => Get = value.ToString(); }
        public static string APIKEY { get => APIKey; set => APIKey = value.ToString(); }
        public static string SECRETKEY { get => SecrKey; set => SecrKey = value.ToString(); }

    }
}
