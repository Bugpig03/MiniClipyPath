using System.Diagnostics;
using System.Configuration;
using System.Windows.Forms;
using System;
using System.Reflection;
using static System.Windows.Forms.DataFormats;

namespace MiniClipyPath
{
    public partial class MainForm : Form
    {
        public int currentIndex;
        public MainForm()
        {
            InitializeComponent();
        }

        private void openpath(int index)
        {
            string key = "button" + index + "Path";
            string path = ConfigurationManager.AppSettings[key];
            if (Directory.Exists(path))
            {
                Process.Start("explorer.exe", path);
            }
            else
            {
                MessageBox.Show("Le chemin spécifié est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowConfigForm()
        {
            string key_name = "button" + currentIndex + "Name";
            string key_path = "button" + currentIndex + "Path";
            string name = ConfigurationManager.AppSettings[key_name];
            string path = ConfigurationManager.AppSettings[key_path];
            // Créez une nouvelle instance du formulaire Form_config
            using (var configForm = new Form_config())
            {
                // Définissez les valeurs des zones de texte en fonction des arguments
                configForm.textBox_name.Text = name;
                configForm.textBox_path.Text = path;

                // Affichez le formulaire de configuration
                configForm.ShowDialog();
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
            this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openpath(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openpath(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openpath(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openpath(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            openpath(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            openpath(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            openpath(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            openpath(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            openpath(9);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            openpath(10);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            openpath(11);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            openpath(12);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            openpath(13);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            openpath(14);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 1;
                contextMenuStrip_left_click.Show(button1, e.Location);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openpath(currentIndex);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConfigForm();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 2;
                contextMenuStrip_left_click.Show(button2, e.Location);
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 3;
                contextMenuStrip_left_click.Show(button3, e.Location);
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 4;
                contextMenuStrip_left_click.Show(button4, e.Location);
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 5;
                contextMenuStrip_left_click.Show(button5, e.Location);
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 6;
                contextMenuStrip_left_click.Show(button6, e.Location);
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 7;
                contextMenuStrip_left_click.Show(button7, e.Location);
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 8;
                contextMenuStrip_left_click.Show(button8, e.Location);
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 9;
                contextMenuStrip_left_click.Show(button9, e.Location);
            }
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 10;
                contextMenuStrip_left_click.Show(button10, e.Location);
            }
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 11;
                contextMenuStrip_left_click.Show(button11, e.Location);
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 12;
                contextMenuStrip_left_click.Show(button12, e.Location);
            }
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 13;
                contextMenuStrip_left_click.Show(button13, e.Location);
            }
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentIndex = 14;
                contextMenuStrip_left_click.Show(button14, e.Location);
            }
        }
    }
}