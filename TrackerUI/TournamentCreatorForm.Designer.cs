namespace TrackerUI
{
    partial class TournamentCreatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createTournmentButton = new System.Windows.Forms.Button();
            this.teamsPlayersLabel = new System.Windows.Forms.Label();
            this.teamsPlayersListBox = new System.Windows.Forms.ListBox();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.selectAllTeamsPlayersCheckbox = new System.Windows.Forms.CheckBox();
            this.selectAllPrizesCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteSelectedTeamsPlayersButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizesButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentLabel.Location = new System.Drawing.Point(336, 9);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(242, 37);
            this.createTournamentLabel.TabIndex = 1;
            this.createTournamentLabel.Text = "Create Tournament";
            this.createTournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.Location = new System.Drawing.Point(364, 55);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(178, 25);
            this.tournamentNameLabel.TabIndex = 2;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Location = new System.Drawing.Point(300, 83);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(295, 25);
            this.tournamentNameTextBox.TabIndex = 3;
            this.tournamentNameTextBox.TextChanged += new System.EventHandler(this.TournamentName_textbox_TextChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.Location = new System.Drawing.Point(401, 111);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(95, 25);
            this.entryFeeLabel.TabIndex = 4;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.Location = new System.Drawing.Point(355, 139);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(194, 25);
            this.entryFeeTextBox.TabIndex = 5;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.Location = new System.Drawing.Point(59, 175);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(115, 25);
            this.selectTeamLabel.TabIndex = 6;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewTeamLink.Location = new System.Drawing.Point(225, 183);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(76, 17);
            this.createNewTeamLink.TabIndex = 7;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(59, 203);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(295, 25);
            this.selectTeamDropdown.TabIndex = 8;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.Location = new System.Drawing.Point(134, 234);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(132, 31);
            this.addTeamButton.TabIndex = 9;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createTournmentButton
            // 
            this.createTournmentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournmentButton.Location = new System.Drawing.Point(313, 578);
            this.createTournmentButton.Name = "createTournmentButton";
            this.createTournmentButton.Size = new System.Drawing.Size(250, 45);
            this.createTournmentButton.TabIndex = 9;
            this.createTournmentButton.Text = "Create Tournament";
            this.createTournmentButton.UseVisualStyleBackColor = true;
            // 
            // teamsPlayersLabel
            // 
            this.teamsPlayersLabel.AutoSize = true;
            this.teamsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teamsPlayersLabel.Location = new System.Drawing.Point(43, 286);
            this.teamsPlayersLabel.Name = "teamsPlayersLabel";
            this.teamsPlayersLabel.Size = new System.Drawing.Size(147, 25);
            this.teamsPlayersLabel.TabIndex = 2;
            this.teamsPlayersLabel.Text = "Teams / Players";
            this.teamsPlayersLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // teamsPlayersListBox
            // 
            this.teamsPlayersListBox.FormattingEnabled = true;
            this.teamsPlayersListBox.ItemHeight = 17;
            this.teamsPlayersListBox.Location = new System.Drawing.Point(43, 314);
            this.teamsPlayersListBox.Name = "teamsPlayersListBox";
            this.teamsPlayersListBox.Size = new System.Drawing.Size(320, 157);
            this.teamsPlayersListBox.TabIndex = 10;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.Location = new System.Drawing.Point(485, 286);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(64, 25);
            this.prizesLabel.TabIndex = 2;
            this.prizesLabel.Text = "Prizes";
            this.prizesLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 17;
            this.prizesListBox.Location = new System.Drawing.Point(485, 314);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(320, 157);
            this.prizesListBox.TabIndex = 10;
            // 
            // selectAllTeamsPlayersCheckbox
            // 
            this.selectAllTeamsPlayersCheckbox.AutoSize = true;
            this.selectAllTeamsPlayersCheckbox.Location = new System.Drawing.Point(230, 291);
            this.selectAllTeamsPlayersCheckbox.Name = "selectAllTeamsPlayersCheckbox";
            this.selectAllTeamsPlayersCheckbox.Size = new System.Drawing.Size(133, 21);
            this.selectAllTeamsPlayersCheckbox.TabIndex = 11;
            this.selectAllTeamsPlayersCheckbox.Text = "Select/Deselect All";
            this.selectAllTeamsPlayersCheckbox.UseVisualStyleBackColor = true;
            this.selectAllTeamsPlayersCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // selectAllPrizesCheckbox
            // 
            this.selectAllPrizesCheckbox.AutoSize = true;
            this.selectAllPrizesCheckbox.Location = new System.Drawing.Point(672, 291);
            this.selectAllPrizesCheckbox.Name = "selectAllPrizesCheckbox";
            this.selectAllPrizesCheckbox.Size = new System.Drawing.Size(133, 21);
            this.selectAllPrizesCheckbox.TabIndex = 11;
            this.selectAllPrizesCheckbox.Text = "Select/Deselect All";
            this.selectAllPrizesCheckbox.UseVisualStyleBackColor = true;
            this.selectAllPrizesCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // deleteSelectedTeamsPlayersButton
            // 
            this.deleteSelectedTeamsPlayersButton.Location = new System.Drawing.Point(140, 477);
            this.deleteSelectedTeamsPlayersButton.Name = "deleteSelectedTeamsPlayersButton";
            this.deleteSelectedTeamsPlayersButton.Size = new System.Drawing.Size(110, 30);
            this.deleteSelectedTeamsPlayersButton.TabIndex = 12;
            this.deleteSelectedTeamsPlayersButton.Text = "Delete Selected";
            this.deleteSelectedTeamsPlayersButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizesButton
            // 
            this.deleteSelectedPrizesButton.Location = new System.Drawing.Point(597, 477);
            this.deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            this.deleteSelectedPrizesButton.Size = new System.Drawing.Size(110, 30);
            this.deleteSelectedPrizesButton.TabIndex = 12;
            this.deleteSelectedPrizesButton.Text = "Delete Selected";
            this.deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.Location = new System.Drawing.Point(575, 234);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(132, 31);
            this.createPrizeButton.TabIndex = 9;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 650);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.deleteSelectedPrizesButton);
            this.Controls.Add(this.deleteSelectedTeamsPlayersButton);
            this.Controls.Add(this.selectAllPrizesCheckbox);
            this.Controls.Add(this.selectAllTeamsPlayersCheckbox);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.teamsPlayersListBox);
            this.Controls.Add(this.teamsPlayersLabel);
            this.Controls.Add(this.createTournmentButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TournamentCreatorForm";
            this.Text = "Tournament Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createTournmentButton;
        private System.Windows.Forms.Label teamsPlayersLabel;
        private System.Windows.Forms.ListBox teamsPlayersListBox;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.CheckBox selectAllTeamsPlayersCheckbox;
        private System.Windows.Forms.CheckBox selectAllPrizesCheckbox;
        private System.Windows.Forms.Button deleteSelectedTeamsPlayersButton;
        private System.Windows.Forms.Button deleteSelectedPrizesButton;
        private System.Windows.Forms.Button createPrizeButton;
    }
}

