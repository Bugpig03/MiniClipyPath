using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniClipyPath
{
    public partial class Form_config : Form
    {
        public Form_config()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            MainForm MainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (MainForm != null)
            {
                int Index = MainForm.currentIndex;
                int pageIndex = MainForm.pageIndex;
                string newName = textBox_name.Text;
                string newPath = textBox_path.Text;
                string keyName = "page" + pageIndex + "Button" + Index + "Name";
                string keyPath = "page" + pageIndex + "Button" + Index + "Path";

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                AppSettingsSection appSettings = config.AppSettings;

                // update data
                if (appSettings.Settings[keyName] != null)
                {
                    appSettings.Settings[keyName].Value = newName;
                    appSettings.Settings[keyPath].Value = newPath;

                    // Save data change
                    config.Save(ConfigurationSaveMode.Modified);

                    // refresh app settings
                    ConfigurationManager.RefreshSection("appSettings");
                    Console.WriteLine("data has been changed.");
                }
                else
                {
                    // La clé spécifiée n'existe pas dans la configuration
                    Console.WriteLine("key doesnt exist");
                }
                MainForm.initButtonName();
            }
            Close();

        }
    }
}
