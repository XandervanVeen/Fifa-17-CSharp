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
using System.Media;

namespace safefunction
{
    public partial class loggedinForm : Form
    {
        private SoundPlayer _soundPlayer = new SoundPlayer(@"cheer2.wav");
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

        public void updateListBox()
        {
            betListBox.Items.Clear();
            for (int i = 0; i < user.Savedbets.Count; i++)
            {
                int GameID = Int32.Parse(user.Savedbets[i].gameID);
                betListBox.Items.Add("Game: " + GameID);
                betListBox.Items.Add("Team:" + user.Savedbets[i].betTeam);
                betListBox.Items.Add("Score: " + user.Savedbets[i].betScore);
                betListBox.Items.Add("Amount: " + user.Savedbets[i].betAmount);
                betListBox.Items.Add("\n");
            }
        }

        private void loggedinForm_Load(object sender, EventArgs e)
        {
            Program.matches.getData();

            updateListBox();

            for (int i = 0; i < Program.matches.matchInfo.Count; i++)
            {
                TreeNode gameTreeNode = treeView1.Nodes.Add("Game " + (i +1));
                gameTreeNode.Tag = Program.matches.matchInfo[i];
                gameTreeNode.Nodes.Add(Program.matches.matchInfo[i].team1);
                gameTreeNode.Nodes.Add(Program.matches.matchInfo[i].team2);
            }
            credit = user.Credits;
            nameLabel.Text = user.Username;
            balanceLabel.Text = credit.ToString();

            string data = File.ReadAllText(path);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(data);
        }

        private void loggedinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string jsond = JsonConvert.SerializeObject(Program.Users);
            File.WriteAllText(path, jsond);
        }

        private void betButton_Click(object sender, EventArgs e)
        {

            Savedbet savedbet = new Savedbet();

            try
            {
                MatchInfo matchInfo = (MatchInfo)treeView1.SelectedNode.Tag;
                if (betAmountNumericUpDown.Value <= 0)
                {
                    MessageBox.Show("Je kan niet 0 of minder credits bieden.");
                    return;
                }
                foreach (var bet in user.Savedbets)
                {
                    if (bet.gameID.ToString() == matchInfo.id.ToString())
                    {
                        MessageBox.Show("Je hebt al een bet op deze game");
                        return;
                    }
                }
                savedbet.betAmount = (int)betAmountNumericUpDown.Value;

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
                    savedbet.gameID = matchInfo.id.ToString();
                    user.Savedbets.Add(savedbet);
                    betListBox.Items.Add("Game: " + (matchInfo.id));
                    betListBox.Items.Add("Team:" + savedbet.betTeam);
                    betListBox.Items.Add("Score: " + savedbet.betScore);
                    betListBox.Items.Add("Amount: " + savedbet.betAmount);
                    betListBox.Items.Add("\n");
                }
                catch
                {
                    MessageBox.Show("Kies een team");
                    return;
                }

                ulong newbal = user.Credits - (ulong)betAmountNumericUpDown.Value;
                balanceLabel.Text = newbal.ToString();

                user.Credits = newbal;
                string jsond = JsonConvert.SerializeObject(Program.Users);
                File.WriteAllText(path, jsond);
                _soundPlayer.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecteer een game.");
            }


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
            try
            {
                MatchInfo matchInfo = (MatchInfo)treeView1.SelectedNode.Tag;
                team1Label.Text = matchInfo.team1;
                team2Label.Text = matchInfo.team2;
                team1RadioButton.Text = matchInfo.team1;
                team2RadioButton.Text = matchInfo.team2;
            }
            catch (Exception)
            {

                return;
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (user.Savedbets.Count == 0)
            {
                MessageBox.Show("Er zijn nog geen bets!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je de bets wilt checken?\nAls er nog geen score is, is je bet fout!", "Check Bets", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var bet in user.Savedbets)
                {
                    int GameID = Int32.Parse(bet.gameID);
                    for (int i = 0; i < Program.matches.matchInfo.Count; i++)
                    {
                        if (Program.matches.matchInfo[i].id == GameID)
                        {
                            bool team1win;
                            bool team2win;

                            if (Int32.Parse(Program.matches.matchInfo[i].team1score) > Int32.Parse(Program.matches.matchInfo[i].team2score))
                            {
                                team1win = true;
                            }
                            else
                            {
                                team2win = true;
                            }

                            string resultscore = Program.matches.matchInfo[i].team1score + " - " + Program.matches.matchInfo[i].team2score + Program.matches.matchInfo[i].id;
                            int GameId = Int32.Parse(bet.gameID);
                            string betting = bet.betScore + bet.gameID;

                            if (team1win = true && bet.betTeam == Program.matches.matchInfo[i].team1 && betting == resultscore)
                            {
                                MessageBox.Show("Beide uw gebetten score en gebetten team op game " + GameId + " is gelijk!\nPay-out is x5!");
                                user.Credits = user.Credits + ((ulong)bet.betAmount * 5);
                            }
                            else if (team2win = true && bet.betTeam == Program.matches.matchInfo[i].team2 && betting == resultscore)
                            {
                                MessageBox.Show("Beide uw gebetten score en gebetten team op game " + GameId + " is gelijk!\nPay-out is x5!");
                                user.Credits = user.Credits + ((ulong)bet.betAmount * 5);
                            }
                            else if (betting == resultscore)
                            {
                                MessageBox.Show("Uw gebetten score op game " + GameId + " is gelijk!\nPay-out is x3!");
                                user.Credits = user.Credits + ((ulong)bet.betAmount * 3);
                            }
                            else if (team1win = true && bet.betTeam == Program.matches.matchInfo[i].team1)
                            {
                                MessageBox.Show("Uw gebetten Team op game " + GameId + " is gelijk!\nPay-out is x2!");
                                user.Credits = user.Credits + ((ulong)bet.betAmount * 2);
                                updateLabel();
                            }
                            else if (team2win = true && bet.betTeam == Program.matches.matchInfo[i].team2)
                            {
                                MessageBox.Show("Uw gebetten Tean op game " + GameId + " is gelijk!\nPay-out is x2!");
                                user.Credits = user.Credits + ((ulong)bet.betAmount * 2);
                                updateLabel();
                            }
                            else
                            {
                                MessageBox.Show("Helaas!\nNiks gewonnen.");
                            }
                         
                        }
                    }
                }
                user.Savedbets.Clear();

                updateListBox();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
            
            string jsond = JsonConvert.SerializeObject(Program.Users);
            File.WriteAllText(path, jsond);
        }

        private void clearBetsButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je de bets wilt clearen?\nJe credits krijg je niet terug!", "Clear Bets", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < user.Savedbets.Count; i++)
                {
                    user.Savedbets.RemoveAt(i);
                }
                updateListBox();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
