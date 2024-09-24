using MitsukoshiML.Helpers;
using MitsukoshiML.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitsukoshiML
{
    public partial class config : Form
    {
        public static SettingsWriter _settings = new SettingsWriter(Path.Combine(Application.StartupPath, "Settings"), false);
        public static Configuration _systemConfig = new Configuration();
        public config()
        {
            InitializeComponent();
            InitializeConfiguration();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _settings.Save<Configuration>(SystemConfiguration, "Configuration");
            MessageBox.Show(String.Format("{0}", "Configuration Saved! \n Pls Run the application again."));
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void InitializeConfiguration() {
            _systemConfig = _settings.Read<Configuration>("Configuration");
            if (_systemConfig != null)
            {
                // Company Info and Database
                txtContractNo.Text = _systemConfig.ContractNo.Trim().ToString();
                txtPOSNo.Text = _systemConfig.POSNo.Trim().ToString();
                txtComName.Text = _systemConfig.CompanyName.Trim().ToString();
                txtXMLPath.Text = _systemConfig.XMLPath.Trim().ToString();
                txtPOST.Text = _systemConfig.PostAPI.Trim().ToString();
                txtGET.Text = _systemConfig.GetAPI.Trim().ToString();
                txtAPIkey.Text = _systemConfig.APIKey.Trim().ToString();
                txtSecretKey.Text = _systemConfig.SecretKey.Trim().ToString();

            }
        }

        public Configuration SystemConfiguration
        {
            get
            {
                return new Configuration()
                {
                    ContractNo = txtContractNo.Text.Trim().ToString(),
                    POSNo = txtPOSNo.Text.Trim().ToString(),
                    CompanyName = txtComName.Text.Trim().ToString(),
                    XMLPath = txtXMLPath.Text.Trim().ToString(),
                    PostAPI = txtPOST.Text.Trim().ToString(),
                    GetAPI = txtGET.Text.Trim().ToString(),
                    APIKey = txtAPIkey.Text.Trim().ToString(),
                    SecretKey = txtSecretKey.Text.Trim().ToString()
                };
            }
        }

        
    }
}
