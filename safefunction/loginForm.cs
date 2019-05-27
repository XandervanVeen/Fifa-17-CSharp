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
        //string temp = "[{" + "\"Username\"" + ":" + "\"temp\"" + "," + "\"Credits\"" + ":0"+","+"\""+"team"+"\""+":null,"+"\""+"amount"+"\""+":0"+"}"+"]";
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
            if (users == null)
            {
                users = new List<User>();
            }
            Program.Users = users;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            string input = registerTextBox.Text;

            if (input == "")
            {
                MessageBox.Show("Vul een username in.");
            }
            else
            {
                try
                {
                    user.Username = input;
                    foreach (User person in Program.Users)
                    {
                        if (person.Username == input)
                        {
                            MessageBox.Show("Deze gebruiker bestaat al. \n Verzin een nieuwe naam.");
                            return;
                        }
                    }
                    user.Credits = 50;
                    Program.Users.Add(user);
                    MessageBox.Show("User aan gemaakt");
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
