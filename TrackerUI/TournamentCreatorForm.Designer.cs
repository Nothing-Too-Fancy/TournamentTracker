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
            this.CreateTournament_label = new System.Windows.Forms.Label();
            this.TournamentName_label = new System.Windows.Forms.Label();
            this.TournamentName_textbox = new System.Windows.Forms.TextBox();
            this.EntryFee_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SelectTeam_label = new System.Windows.Forms.Label();
            this.CreateNewTeam_link = new System.Windows.Forms.LinkLabel();
            this.Team_dropdown = new System.Windows.Forms.ComboBox();
            this.AddTeam_button = new System.Windows.Forms.Button();
            this.CreateTournament_button = new System.Windows.Forms.Button();
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
            // CreateTournament_label
            // 
            this.CreateTournament_label.AutoSize = true;
            this.CreateTournament_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTournament_label.Location = new System.Drawing.Point(336, 9);
            this.CreateTournament_label.Name = "CreateTournament_label";
            this.CreateTournament_label.Size = new System.Drawing.Size(242, 37);
            this.CreateTournament_label.TabIndex = 1;
            this.CreateTournament_label.Text = "Create Tournament";
            this.CreateTournament_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentName_label
            // 
            this.TournamentName_label.AutoSize = true;
            this.TournamentName_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TournamentName_label.Location = new System.Drawing.Point(364, 55);
            this.TournamentName_label.Name = "TournamentName_label";
            this.TournamentName_label.Size = new System.Drawing.Size(178, 25);
            this.TournamentName_label.TabIndex = 2;
            this.TournamentName_label.Text = "Tournament Name";
            // 
            // TournamentName_textbox
            // 
            this.TournamentName_textbox.Location = new System.Drawing.Point(300, 83);
            this.TournamentName_textbox.Name = "TournamentName_textbox";
            this.TournamentName_textbox.Size = new System.Drawing.Size(295, 25);
            this.TournamentName_textbox.TabIndex = 3;
            // 
            // EntryFee_label
            // 
            this.EntryFee_label.AutoSize = true;
            this.EntryFee_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EntryFee_label.Location = new System.Drawing.Point(401, 111);
            this.EntryFee_label.Name = "EntryFee_label";
            this.EntryFee_label.Size = new System.Drawing.Size(95, 25);
            this.EntryFee_label.TabIndex = 4;
            this.EntryFee_label.Text = "Entry Fee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 25);
            this.textBox1.TabIndex = 5;
            // 
            // SelectTeam_label
            // 
            this.SelectTeam_label.AutoSize = true;
            this.SelectTeam_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectTeam_label.Location = new System.Drawing.Point(59, 175);
            this.SelectTeam_label.Name = "SelectTeam_label";
            this.SelectTeam_label.Size = new System.Drawing.Size(115, 25);
            this.SelectTeam_label.TabIndex = 6;
            this.SelectTeam_label.Text = "Select Team";
            // 
            // CreateNewTeam_link
            // 
            this.CreateNewTeam_link.AutoSize = true;
            this.CreateNewTeam_link.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateNewTeam_link.Location = new System.Drawing.Point(225, 183);
            this.CreateNewTeam_link.Name = "CreateNewTeam_link";
            this.CreateNewTeam_link.Size = new System.Drawing.Size(76, 17);
            this.CreateNewTeam_link.TabIndex = 7;
            this.CreateNewTeam_link.TabStop = true;
            this.CreateNewTeam_link.Text = "Create New";
            // 
            // Team_dropdown
            // 
            this.Team_dropdown.FormattingEnabled = true;
            this.Team_dropdown.Location = new System.Drawing.Point(59, 203);
            this.Team_dropdown.Name = "Team_dropdown";
            this.Team_dropdown.Size = new System.Drawing.Size(295, 25);
            this.Team_dropdown.TabIndex = 8;
            // 
            // AddTeam_button
            // 
            this.AddTeam_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddTeam_button.Location = new System.Drawing.Point(134, 234);
            this.AddTeam_button.Name = "AddTeam_button";
            this.AddTeam_button.Size = new System.Drawing.Size(132, 31);
            this.AddTeam_button.TabIndex = 9;
            this.AddTeam_button.Text = "Add Team";
            this.AddTeam_button.UseVisualStyleBackColor = true;
            // 
            // CreateTournament_button
            // 
            this.CreateTournament_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTournament_button.Location = new System.Drawing.Point(313, 578);
            this.CreateTournament_button.Name = "CreateTournament_button";
            this.CreateTournament_button.Size = new System.Drawing.Size(250, 45);
            this.CreateTournament_button.TabIndex = 9;
            this.CreateTournament_button.Text = "Create Tournament";
            this.CreateTournament_button.UseVisualStyleBackColor = true;
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
            // TournamentViewerForm
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
            this.Controls.Add(this.CreateTournament_button);
            this.Controls.Add(this.AddTeam_button);
            this.Controls.Add(this.Team_dropdown);
            this.Controls.Add(this.CreateNewTeam_link);
            this.Controls.Add(this.SelectTeam_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EntryFee_label);
            this.Controls.Add(this.TournamentName_textbox);
            this.Controls.Add(this.TournamentName_label);
            this.Controls.Add(this.CreateTournament_label);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label CreateTournament_label;
        private System.Windows.Forms.Label TournamentName_label;
        private System.Windows.Forms.TextBox TournamentName_textbox;
        private System.Windows.Forms.Label EntryFee_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SelectTeam_label;
        private System.Windows.Forms.LinkLabel CreateNewTeam_link;
        private System.Windows.Forms.ComboBox Team_dropdown;
        private System.Windows.Forms.Button AddTeam_button;
        private System.Windows.Forms.Button CreateTournament_button;
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

