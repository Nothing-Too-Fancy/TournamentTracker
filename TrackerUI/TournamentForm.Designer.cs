namespace TrackerUI
{
    partial class tournamentForm
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
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.team2Label = new System.Windows.Forms.Label();
            this.team1Label = new System.Windows.Forms.Label();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.team1ScoreTextBox = new System.Windows.Forms.TextBox();
            this.team2ScoreTextBox = new System.Windows.Forms.TextBox();
            this.vsLabel = new System.Windows.Forms.Label();
            this.submitScoresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.Location = new System.Drawing.Point(255, 21);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(247, 32);
            this.tournamentNameLabel.TabIndex = 0;
            this.tournamentNameLabel.Text = "Tournament: <name>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.Location = new System.Drawing.Point(39, 113);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(72, 25);
            this.roundLabel.TabIndex = 1;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(127, 115);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(172, 23);
            this.roundDropDown.TabIndex = 2;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 15;
            this.matchupListBox.Location = new System.Drawing.Point(39, 179);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(260, 289);
            this.matchupListBox.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.Checked = true;
            this.unplayedOnlyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(127, 154);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(104, 19);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team2Label.Location = new System.Drawing.Point(377, 314);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(74, 25);
            this.team2Label.TabIndex = 1;
            this.team2Label.Text = "Team 2";
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team1Label.Location = new System.Drawing.Point(377, 179);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(74, 25);
            this.team1Label.TabIndex = 1;
            this.team1Label.Text = "Team 1";
            this.team1Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team1ScoreLabel.Location = new System.Drawing.Point(377, 215);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(62, 25);
            this.team1ScoreLabel.TabIndex = 1;
            this.team1ScoreLabel.Text = "Score";
            this.team1ScoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team2ScoreLabel.Location = new System.Drawing.Point(377, 351);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(62, 25);
            this.team2ScoreLabel.TabIndex = 1;
            this.team2ScoreLabel.Text = "Score";
            this.team2ScoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // team1ScoreTextBox
            // 
            this.team1ScoreTextBox.Location = new System.Drawing.Point(445, 215);
            this.team1ScoreTextBox.Name = "team1ScoreTextBox";
            this.team1ScoreTextBox.Size = new System.Drawing.Size(100, 23);
            this.team1ScoreTextBox.TabIndex = 5;
            // 
            // team2ScoreTextBox
            // 
            this.team2ScoreTextBox.Location = new System.Drawing.Point(445, 356);
            this.team2ScoreTextBox.Name = "team2ScoreTextBox";
            this.team2ScoreTextBox.Size = new System.Drawing.Size(100, 23);
            this.team2ScoreTextBox.TabIndex = 5;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vsLabel.Location = new System.Drawing.Point(445, 269);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(36, 25);
            this.vsLabel.TabIndex = 1;
            this.vsLabel.Text = "VS";
            // 
            // submitScoresButton
            // 
            this.submitScoresButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitScoresButton.Location = new System.Drawing.Point(606, 273);
            this.submitScoresButton.Name = "submitScoresButton";
            this.submitScoresButton.Size = new System.Drawing.Size(113, 42);
            this.submitScoresButton.TabIndex = 6;
            this.submitScoresButton.Text = "Submit Scores";
            this.submitScoresButton.UseVisualStyleBackColor = true;
            // 
            // tournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 570);
            this.Controls.Add(this.submitScoresButton);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.team2ScoreTextBox);
            this.Controls.Add(this.team1ScoreTextBox);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.team1Label);
            this.Controls.Add(this.team2Label);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Name = "tournamentForm";
            this.Text = "Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.Label team2ScoreLabel;
        private System.Windows.Forms.TextBox team1ScoreTextBox;
        private System.Windows.Forms.TextBox team2ScoreTextBox;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Button submitScoresButton;
    }
}