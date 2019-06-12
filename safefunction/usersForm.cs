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
    public partial class usersForm : Form
    {
        public static string path = @"bets\users.json";
        private User user;

        public usersForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void userslist_Load(object sender, EventArgs e)
        {
            string data = File.ReadAllText(path);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(data);

            try
            {
                for (int i = 0; i < users.Count(); i++)
                {
                    userListBox.Items.Add(users[i]);
                }
            }
            catch (System.ArgumentNullException)
            {
                loginForm loginform = new loginForm();
                MessageBox.Show("Maak eerst een gebruiker.");
                this.Hide();
                loginform.ShowDialog();
                this.Close();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User selecteduser = (User)userListBox.SelectedItem;
            try
            {
                foreach (User search in Program.Users)
                {
                    if (search.Username == selecteduser.Username)
                    {
                        user = search;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecteer een gebruiker");
                return;
            }
            loggedinForm loggedinform = new loggedinForm(user);
            user.Username = selecteduser.Username;
            user.Credits = selecteduser.Credits;
            this.Hide();
            loggedinform.ShowDialog();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();
            this.Hide();
            loginform.ShowDialog();
            this.Close();
        }

        private void userListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                User selecteduser = (User)userListBox.SelectedItem;
                try
                {
                    foreach (User search in Program.Users)
                    {
                        if (search.Username == selecteduser.Username)
                        {
                            user = search;
                        }
                    }
                }
                catch (Exception)
                {

                }
                loggedinForm loggedinform = new loggedinForm(user);
                user.Username = selecteduser.Username;
                user.Credits = selecteduser.Credits;
                this.Hide();
                loggedinform.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
