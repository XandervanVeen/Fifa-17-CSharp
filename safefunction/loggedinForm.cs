using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace safefunction
{
    public partial class loggedinForm : Form
    {
        User user;
        ulong credit;
        public static string path = @"bets\users.json";

        public loggedinForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            user.Credits++;
            updateLabel();
        }

        private void updateLabel()
        {
            balanceLabel.Text = user.Credits.ToString();
        }

        private void loggedinForm_Load(object sender, EventArgs e)
        {
            Program.matches.getData();

            for (int i = 0; i < user.Savedbets.Count; i++)
            {
                betListBox.Items.Add("Game: "+ user.Savedbets[i].gameValue);
                betListBox.Items.Add("Team:"+user.Savedbets[i].betTeam);
                betListBox.Items.Add("Score: "+user.Savedbets[i].betScore);
                betListBox.Items.Add("Amount: "+user.Savedbets[i].betAmount);
                betListBox.Items.Add("\n");
            }

            //string data = File.ReadAllText(path);
            //List<User> users = JsonConvert.DeserializeObject<List<User>>(data);
            for (int i = 0; i < Program.matches.matchInfo.Count; i++)
            {
                TreeNode gameTreeNode = treeView1.Nodes.Add("Game " + i);
                gameTreeNode.Tag = Program.matches.matchInfo[i];
                gameTreeNode.Nodes.Add(Program.matches.matchInfo[i].team1);
                gameTreeNode.Nodes.Add(Program.matches.matchInfo[i].team2);
            }
            credit = user.Credits;
            nameLabel.Text = Program.loggeduser;
            balanceLabel.Text = credit.ToString();

            // =============================
            //string savedbets = File.ReadAllText(path);
            //SavedBets savebet = JsonConvert.DeserializeObject<SavedBets>(savedbets);
            string data = File.ReadAllText(path);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(data);

            try
            {

            }
            catch (System.NullReferenceException)
            {
                //user.Savedbets.Add
                //user.betAmount = 0;
                //user.betScore = "";
                //user.betTeam = "";
            }

            //if (user.betTeam == null || user.betTeam == "" || user.betScore == null || user.betScore == "")
            //{
            //    betButton.Enabled = true;
            //}
            //else
            //{
            //    betButton.Enabled = false;
            //}
        }
      
        private void loggedinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string jsond = JsonConvert.SerializeObject(Program.Users);
            File.WriteAllText(path, jsond);
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (betAmountNumericUpDown.Value <=0)
            {
                MessageBox.Show("Je kan niet 0 of minder credits bieden.");
                return;
            }
            Savedbet savedbet = new Savedbet();

            savedbet.betAmount = (int)(betAmountNumericUpDown.Value);
            if (team1RadioButton.Checked)
            {
                savedbet.betTeam = team1Label.Text;
            }
            else
            {
                savedbet.betTeam = team2Label.Text;
            }

            if ((ulong)savedbet.betAmount > user.Credits)
            {
                MessageBox.Show("Je hebt hier niet genoeg geld voor.");
                return;
            }

            savedbet.betScore = team1NumericUpDown.Value.ToString() + " - " + team2NumericUpDown.Value.ToString();
            try
            {
                MatchInfo matchInfo = (MatchInfo)treeView1.SelectedNode.Tag;
                savedbet.gameValue = matchInfo.id.ToString();
                user.Savedbets.Add(savedbet);
                betListBox.Items.Add("Game: " + (matchInfo.id - 1));
                betListBox.Items.Add("Team:" + savedbet.betTeam);
                betListBox.Items.Add("Score: " + savedbet.betScore);
                betListBox.Items.Add("Amount: " + savedbet.betAmount);
                betListBox.Items.Add("\n");
            }
            catch
            {
                MessageBox.Show("Kies een team");
            }
        


            //save function
            //bets
            //savebet.amount = user.amount;
            //savebet.score = user.score;
            //savebet.team = user.team;
            //string jsonb = JsonConvert.SerializeObject(savebet);
            //File.WriteAllText(pathbet, jsonb);
            //save function

            ulong newbal = user.Credits - (ulong)betAmountNumericUpDown.Value;
            balanceLabel.Text = newbal.ToString();
            //save function
            //credits

            foreach (User search in Program.Users)
            {
                if (search.Username == nameLabel.Text)
                {
                    user = search;
                }
            }

            user.Credits = newbal;
            string jsond = JsonConvert.SerializeObject(Program.Users);
            File.WriteAllText(path, jsond);
            //save function
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();

            this.Hide();
            loginform.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Credits++;
            updateLabel();
        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {
            user.Credits++;
            updateLabel();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MatchInfo matchInfo = (MatchInfo)treeView1.SelectedNode.Tag;
            team1Label.Text = matchInfo.team1;
            team2Label.Text = matchInfo.team2;
            team1RadioButton.Text = matchInfo.team1;
            team2RadioButton.Text = matchInfo.team2;
        }
    }
}
    