using Newtonsoft.Json;
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
    public partial class ApiForm : Form
    {
        public ApiForm()
        {
            InitializeComponent();
        }

        private void apiGoButton_Click(object sender, EventArgs e)
        {
            string pathapi = @"bets\API.json";

            if (apiTokenTextBox.Text != "")
            {
                Program.key = apiTokenTextBox.Text;
                // apiTokenTextBox.Text = Program.key;

                try
                {
                    Program.matches.getData();
                    loginForm loginform = new loginForm();

                    string jsond = JsonConvert.SerializeObject(Program.key);
                    File.WriteAllText(pathapi, jsond);

                    this.Hide();
                    loginform.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Uw api key klopt niet!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vull een api token in!");
            }
        }  

        private void ApiForm_Load(object sender, EventArgs e)
        {
            try
            {
                string pathapi = @"bets\API.json";
                string data = File.ReadAllText(pathapi);
                string key = JsonConvert.DeserializeObject<string>(data);
                Program.key = key;
                Program.matches.getData();
                loginForm loginform = new loginForm();

                this.Hide();
                loginform.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
          
            }

        }
    }
   
}
