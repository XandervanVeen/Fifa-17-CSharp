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
        public static string pathapi = @"bets\API.json";

        public installForm()
        {
            InitializeComponent();
        }

        private void installForm_Load(object sender, EventArgs e)
        {   //Dit checked of je bestanden en folders bestaan. Als ze besstaan openent hij meteen de API Form
            if (Directory.Exists(dirpath) && File.Exists(pathusers) && File.Exists(pathapi))
            {
                ApiForm apiform = new ApiForm();
                this.Hide();
                apiform.ShowDialog();
                this.Close();
            }
            //================================================================================================
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            // Dit maakt de bestanden op de de locaties boven aan gegeven (dirpath enzo). (! staat voor niet).
            if (!Directory.Exists(dirpath))
            {
                Directory.CreateDirectory(dirpath);
                File.Create(pathusers);
                File.Create(pathapi);
            }
            else if (!File.Exists(pathusers) && !File.Exists(pathapi))
            {
                File.Create(pathusers);
                File.Create(pathapi);
            }
            else if (!File.Exists(pathapi))
            {
                File.Create(pathapi);
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


    }
}
