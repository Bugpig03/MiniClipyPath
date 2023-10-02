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
        public int pageIndex = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void openpath(int index)
        {
            string key = "page" + pageIndex + "Button" + index + "Path";
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
            string key_name = "page" + pageIndex + "Button" + currentIndex + "Name";
            string key_path = "page" + pageIndex + "Button" + currentIndex + "Path";
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
            for (int i = 0; i <= 14; i++)
            {
                string buttonName = "button" + i;

                var buttonField = this.GetType().GetField(buttonName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (buttonField != null && buttonField.FieldType == typeof(Button))
                {
                    Button button = (Button)buttonField.GetValue(this);
                    string key = "page" + pageIndex + "Button" + i + "Name";
                    button.Text = ConfigurationManager.AppSettings[key];
                }
            }
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

        private void buttonPage1_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            initButtonName();
        }

        private void buttonPage2_Click(object sender, EventArgs e)
        {
            pageIndex = 2;
            initButtonName();
        }

        private void buttonPage3_Click(object sender, EventArgs e)
        {
            pageIndex = 3;
            initButtonName();
        }

        private void buttonPage4_Click(object sender, EventArgs e)
        {
            pageIndex = 4;
            initButtonName();
        }

        private void buttonPage5_Click(object sender, EventArgs e)
        {
            pageIndex = 5;
            initButtonName();
        }

        private void buttonPage6_Click(object sender, EventArgs e)
        {
            pageIndex = 6;
            initButtonName();
        }
    }
}