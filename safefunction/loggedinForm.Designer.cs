namespace safefunction
{
    partial class loggedinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.betListBox = new System.Windows.Forms.ListBox();
            this.betButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.match1GroupBox = new System.Windows.Forms.GroupBox();
            this.betAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iLabel = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.team2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.team1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.team2Label = new System.Windows.Forms.Label();
            this.team2RadioButton = new System.Windows.Forms.RadioButton();
            this.team1Label = new System.Windows.Forms.Label();
            this.team1RadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.getBetButton = new System.Windows.Forms.Button();
            this.clearBetsButton = new System.Windows.Forms.Button();
            this.match1GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.tLabel.Location = new System.Drawing.Point(12, 48);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(55, 17);
            this.tLabel.TabIndex = 28;
            this.tLabel.Text = "Teams:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.balanceLabel.Location = new System.Drawing.Point(642, 18);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(16, 17);
            this.balanceLabel.TabIndex = 25;
            this.balanceLabel.Text = "0";
            this.balanceLabel.Click += new System.EventHandler(this.balanceLabel_Click);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.bLabel.Location = new System.Drawing.Point(592, 17);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(56, 17);
            this.bLabel.TabIndex = 24;
            this.bLabel.Text = "Credits:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.resultLabel.Location = new System.Drawing.Point(593, 59);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(63, 17);
            this.resultLabel.TabIndex = 23;
            this.resultLabel.Text = "Uw Bets:";
            // 
            // betListBox
            // 
            this.betListBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.betListBox.ForeColor = System.Drawing.SystemColors.Control;
            this.betListBox.FormattingEnabled = true;
            this.betListBox.ItemHeight = 16;
            this.betListBox.Location = new System.Drawing.Point(596, 80);
            this.betListBox.Name = "betListBox";
            this.betListBox.Size = new System.Drawing.Size(164, 196);
            this.betListBox.TabIndex = 22;
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.betButton.ForeColor = System.Drawing.SystemColors.Control;
            this.betButton.Location = new System.Drawing.Point(177, 223);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(206, 53);
            this.betButton.TabIndex = 21;
            this.betButton.Text = "Go!";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(42, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(70, 17);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Welcome:";
            // 
            // match1GroupBox
            // 
            this.match1GroupBox.Controls.Add(this.betAmountNumericUpDown);
            this.match1GroupBox.Controls.Add(this.iLabel);
            this.match1GroupBox.Controls.Add(this.vsLabel);
            this.match1GroupBox.Controls.Add(this.team2NumericUpDown);
            this.match1GroupBox.Controls.Add(this.team1NumericUpDown);
            this.match1GroupBox.Controls.Add(this.team2Label);
            this.match1GroupBox.Controls.Add(this.team2RadioButton);
            this.match1GroupBox.Controls.Add(this.team1Label);
            this.match1GroupBox.Controls.Add(this.team1RadioButton);
            this.match1GroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.match1GroupBox.Location = new System.Drawing.Point(177, 72);
            this.match1GroupBox.Name = "match1GroupBox";
            this.match1GroupBox.Size = new System.Drawing.Size(410, 147);
            this.match1GroupBox.TabIndex = 19;
            this.match1GroupBox.TabStop = false;
            this.match1GroupBox.Text = "Ronde 1";
            // 
            // betAmountNumericUpDown
            // 
            this.betAmountNumericUpDown.Location = new System.Drawing.Point(361, 119);
            this.betAmountNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.betAmountNumericUpDown.Name = "betAmountNumericUpDown";
            this.betAmountNumericUpDown.Size = new System.Drawing.Size(43, 22);
            this.betAmountNumericUpDown.TabIndex = 18;
            // 
            // iLabel
            // 
            this.iLabel.AutoSize = true;
            this.iLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iLabel.Location = new System.Drawing.Point(312, 121);
            this.iLabel.Name = "iLabel";
            this.iLabel.Size = new System.Drawing.Size(43, 17);
            this.iLabel.TabIndex = 14;
            this.iLabel.Text = "Input:";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.vsLabel.Location = new System.Drawing.Point(159, 57);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(52, 17);
            this.vsLabel.TabIndex = 7;
            this.vsLabel.Text = "-  VS  -";
            // 
            // team2NumericUpDown
            // 
            this.team2NumericUpDown.Location = new System.Drawing.Point(260, 73);
            this.team2NumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.team2NumericUpDown.Name = "team2NumericUpDown";
            this.team2NumericUpDown.Size = new System.Drawing.Size(43, 22);
            this.team2NumericUpDown.TabIndex = 6;
            // 
            // team1NumericUpDown
            // 
            this.team1NumericUpDown.Location = new System.Drawing.Point(81, 73);
            this.team1NumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.team1NumericUpDown.Name = "team1NumericUpDown";
            this.team1NumericUpDown.Size = new System.Drawing.Size(43, 22);
            this.team1NumericUpDown.TabIndex = 5;
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Location = new System.Drawing.Point(257, 56);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(0, 17);
            this.team2Label.TabIndex = 3;
            // 
            // team2RadioButton
            // 
            this.team2RadioButton.AutoSize = true;
            this.team2RadioButton.Location = new System.Drawing.Point(234, 56);
            this.team2RadioButton.Name = "team2RadioButton";
            this.team2RadioButton.Size = new System.Drawing.Size(17, 16);
            this.team2RadioButton.TabIndex = 2;
            this.team2RadioButton.TabStop = true;
            this.team2RadioButton.UseVisualStyleBackColor = true;
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Location = new System.Drawing.Point(78, 56);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(0, 17);
            this.team1Label.TabIndex = 1;
            // 
            // team1RadioButton
            // 
            this.team1RadioButton.AutoSize = true;
            this.team1RadioButton.Location = new System.Drawing.Point(55, 57);
            this.team1RadioButton.Name = "team1RadioButton";
            this.team1RadioButton.Size = new System.Drawing.Size(17, 16);
            this.team1RadioButton.TabIndex = 0;
            this.team1RadioButton.TabStop = true;
            this.team1RadioButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Location = new System.Drawing.Point(118, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            this.nameLabel.TabIndex = 31;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(7, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(29, 23);
            this.backButton.TabIndex = 32;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(7, 80);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(164, 196);
            this.treeView1.TabIndex = 33;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // getBetButton
            // 
            this.getBetButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.getBetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.getBetButton.Location = new System.Drawing.Point(389, 223);
            this.getBetButton.Name = "getBetButton";
            this.getBetButton.Size = new System.Drawing.Size(198, 53);
            this.getBetButton.TabIndex = 34;
            this.getBetButton.Text = "Check Bets";
            this.getBetButton.UseVisualStyleBackColor = false;
            this.getBetButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clearBetsButton
            // 
            this.clearBetsButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.clearBetsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearBetsButton.Location = new System.Drawing.Point(706, 28);
            this.clearBetsButton.Name = "clearBetsButton";
            this.clearBetsButton.Size = new System.Drawing.Size(54, 46);
            this.clearBetsButton.TabIndex = 35;
            this.clearBetsButton.Text = "Clear Bets";
            this.clearBetsButton.UseVisualStyleBackColor = false;
            this.clearBetsButton.Click += new System.EventHandler(this.clearBetsButton_Click);
            // 
            // loggedinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(769, 280);
            this.Controls.Add(this.clearBetsButton);
            this.Controls.Add(this.getBetButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.betListBox);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.match1GroupBox);
            this.Name = "loggedinForm";
            this.Text = "loggedinForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loggedinForm_FormClosing);
            this.Load += new System.EventHandler(this.loggedinForm_Load);
            this.match1GroupBox.ResumeLayout(false);
            this.match1GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ListBox betListBox;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox match1GroupBox;
        private System.Windows.Forms.NumericUpDown betAmountNumericUpDown;
        private System.Windows.Forms.Label iLabel;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.NumericUpDown team2NumericUpDown;
        private System.Windows.Forms.NumericUpDown team1NumericUpDown;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.RadioButton team2RadioButton;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.RadioButton team1RadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button getBetButton;
        private System.Windows.Forms.Button clearBetsButton;
    }
}