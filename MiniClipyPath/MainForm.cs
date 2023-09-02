using System.Diagnostics;
using System.Configuration;

namespace MiniClipyPath
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openpath(string path)
        {
            if (Directory.Exists(path))
            {
                Process.Start("explorer.exe", path);
            }
            else
            {
                MessageBox.Show("Le chemin spécifié est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void initButtonName()
        {
            button1.Text = ConfigurationManager.AppSettings["button1Name"];
            button2.Text = ConfigurationManager.AppSettings["button2Name"];
            button3.Text = ConfigurationManager.AppSettings["button3Name"];
            button4.Text = ConfigurationManager.AppSettings["button4Name"];
            button5.Text = ConfigurationManager.AppSettings["button5Name"];
            button6.Text = ConfigurationManager.AppSettings["button6Name"];
            button7.Text = ConfigurationManager.AppSettings["button7Name"];
            button8.Text = ConfigurationManager.AppSettings["button8Name"];
            button9.Text = ConfigurationManager.AppSettings["button9Name"];
            button10.Text = ConfigurationManager.AppSettings["button10Name"];
            button11.Text = ConfigurationManager.AppSettings["button11Name"];
            button12.Text = ConfigurationManager.AppSettings["button12Name"];
            button13.Text = ConfigurationManager.AppSettings["button13Name"];
            button14.Text = ConfigurationManager.AppSettings["button14Name"];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button1Path"]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button2Path"]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button3Path"]);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button4Path"]);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button5Path"]);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button6Path"]);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button7Path"]);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button8Path"]);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button9Path"]);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button10Path"]);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button11Path"]);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button12Path"]);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button13Path"]);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            openpath(ConfigurationManager.AppSettings["button14Path"]);
        }
    }
}