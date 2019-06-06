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

namespace safefunction
{
    public partial class installForm : Form
    {
        public static string dirpath = @"bets";
        public static string pathusers = @"bets\users.json";

        public installForm()
        {
            InitializeComponent();
        }
        private void installButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirpath))
            {
                Directory.CreateDirectory(dirpath);
                File.Create(pathusers);
            }
            else if (!File.Exists(pathusers))
            {
                File.Create(pathusers);
            }
            else
            {
                MessageBox.Show("Alle bestand zijn al gedownload");
            }
            MessageBox.Show("Bestanden gedownload\nHer-open het programma");
            this.Close();
        }

        private void installForm_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(dirpath) || File.Exists(pathusers))
            {
                loginForm loginform = new loginForm();
                this.Hide();
                loginform.ShowDialog();
                this.Close();
            }
        }
    }
}
