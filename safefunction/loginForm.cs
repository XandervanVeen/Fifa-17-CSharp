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
    public partial class loginForm : Form
    {
        public static string path = @"bets\users.json";
        public static string pathusers = @"bets\users.json";

        User user = new User();
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            string data = File.ReadAllText(path);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(data);
            // Als er nog geen user is maakt hij alvast een list aan anders probeert hij een list optehalen die niet bestaat.
            if (users == null)
            {
                users = new List<User>();
            }
            //==============================================================================================================
           
            // hier zet ik de nieuwe user in de program.user
            Program.Users = users;
            //==============================================
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string input = registerTextBox.Text;

            if (input == "")
            {
                MessageBox.Show("Vul een gebruikersnaam in.");
            }
            else
            {
                try
                {
                    user.Username = input;
                    foreach (User person in Program.Users)
                    {// Hij loopt over elke user en naamt hem person. Daarna kijkt hij op de username van elke persoon gelijk
                        // is aan de input van de user. Als dit klopt, bestaat de user all.
                        if (person.Username == input)
                        {
                            MessageBox.Show("Deze gebruiker bestaat al. \nVerzin een nieuwe naam.");
                            return;
                        }
                    }//===========================================================================
                    user.Credits = 50;
                    Program.Users.Add(user);
                    MessageBox.Show("Gebruiker aan gemaakt");
                    string jsond = JsonConvert.SerializeObject(Program.Users);
                    File.WriteAllText(path, jsond);
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Er ging iets mis.");
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            usersForm usersForm = new usersForm(user);
            this.Hide();
            usersForm.ShowDialog();
            this.Close();
        }
    }
}
