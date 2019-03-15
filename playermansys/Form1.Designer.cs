namespace NETAssign2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.printGuildRoster = new System.Windows.Forms.Button();
            this.disbandGuild = new System.Windows.Forms.Button();
            this.joinGuild = new System.Windows.Forms.Button();
            this.leaveGuild = new System.Windows.Forms.Button();
            this.applySearchCriteria = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guildSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playerSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPlayerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addGuildButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.GuildName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player/Guild Management System";
            // 
            // printGuildRoster
            // 
            this.printGuildRoster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.printGuildRoster.Location = new System.Drawing.Point(6, 17);
            this.printGuildRoster.Name = "printGuildRoster";
            this.printGuildRoster.Size = new System.Drawing.Size(118, 23);
            this.printGuildRoster.TabIndex = 1;
            this.printGuildRoster.Text = "Print Guild Roster";
            this.printGuildRoster.UseVisualStyleBackColor = true;
            this.printGuildRoster.Click += new System.EventHandler(this.printGuildRoster_Click);
            // 
            // disbandGuild
            // 
            this.disbandGuild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.disbandGuild.Location = new System.Drawing.Point(6, 46);
            this.disbandGuild.Name = "disbandGuild";
            this.disbandGuild.Size = new System.Drawing.Size(118, 23);
            this.disbandGuild.TabIndex = 2;
            this.disbandGuild.Text = "Disband Guild";
            this.disbandGuild.UseVisualStyleBackColor = true;
            this.disbandGuild.Click += new System.EventHandler(this.disbandGuild_Click);
            // 
            // joinGuild
            // 
            this.joinGuild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.joinGuild.Location = new System.Drawing.Point(6, 75);
            this.joinGuild.Name = "joinGuild";
            this.joinGuild.Size = new System.Drawing.Size(118, 23);
            this.joinGuild.TabIndex = 3;
            this.joinGuild.Text = "Join Guild";
            this.joinGuild.UseVisualStyleBackColor = true;
            this.joinGuild.Click += new System.EventHandler(this.joinGuild_Click);
            // 
            // leaveGuild
            // 
            this.leaveGuild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.leaveGuild.Location = new System.Drawing.Point(6, 104);
            this.leaveGuild.Name = "leaveGuild";
            this.leaveGuild.Size = new System.Drawing.Size(118, 23);
            this.leaveGuild.TabIndex = 4;
            this.leaveGuild.Text = "Leave Guild";
            this.leaveGuild.UseVisualStyleBackColor = true;
            this.leaveGuild.Click += new System.EventHandler(this.leaveGuild_Click);
            // 
            // applySearchCriteria
            // 
            this.applySearchCriteria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.applySearchCriteria.Location = new System.Drawing.Point(6, 133);
            this.applySearchCriteria.Name = "applySearchCriteria";
            this.applySearchCriteria.Size = new System.Drawing.Size(118, 23);
            this.applySearchCriteria.TabIndex = 5;
            this.applySearchCriteria.Text = "Apply Search Criteria";
            this.applySearchCriteria.UseVisualStyleBackColor = true;
            this.applySearchCriteria.Click += new System.EventHandler(this.applySearchCriteria_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guildSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.playerSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.printGuildRoster);
            this.groupBox1.Controls.Add(this.disbandGuild);
            this.groupBox1.Controls.Add(this.applySearchCriteria);
            this.groupBox1.Controls.Add(this.joinGuild);
            this.groupBox1.Controls.Add(this.leaveGuild);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(21, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management Functions";
            // 
            // guildSearch
            // 
            this.guildSearch.Location = new System.Drawing.Point(156, 92);
            this.guildSearch.Name = "guildSearch";
            this.guildSearch.Size = new System.Drawing.Size(142, 20);
            this.guildSearch.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search Guild (by Server)";
            // 
            // playerSearch
            // 
            this.playerSearch.Location = new System.Drawing.Point(156, 46);
            this.playerSearch.Name = "playerSearch";
            this.playerSearch.Size = new System.Drawing.Size(142, 20);
            this.playerSearch.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Player (by Name)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addPlayerButton);
            this.groupBox2.Controls.Add(this.RoleComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.raceComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.classComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.newPlayerName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(21, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Player";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addPlayerButton.Location = new System.Drawing.Point(301, 35);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 8;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(156, 81);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoleComboBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Role";
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(156, 36);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(121, 21);
            this.raceComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Race";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(9, 81);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(124, 21);
            this.classComboBox.TabIndex = 3;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Class";
            // 
            // newPlayerName
            // 
            this.newPlayerName.Location = new System.Drawing.Point(9, 37);
            this.newPlayerName.Name = "newPlayerName";
            this.newPlayerName.Size = new System.Drawing.Size(124, 20);
            this.newPlayerName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addGuildButton);
            this.groupBox3.Controls.Add(this.typeComboBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.serverComboBox);
            this.groupBox3.Controls.Add(this.GuildName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(21, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 147);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create New Guild";
            // 
            // addGuildButton
            // 
            this.addGuildButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addGuildButton.Location = new System.Drawing.Point(301, 47);
            this.addGuildButton.Name = "addGuildButton";
            this.addGuildButton.Size = new System.Drawing.Size(75, 23);
            this.addGuildButton.TabIndex = 6;
            this.addGuildButton.Text = "Add Guild";
            this.addGuildButton.UseVisualStyleBackColor = true;
            this.addGuildButton.Click += new System.EventHandler(this.addGuildButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(156, 92);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Server";
            // 
            // serverComboBox
            // 
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Location = new System.Drawing.Point(156, 47);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(121, 21);
            this.serverComboBox.TabIndex = 2;
            // 
            // GuildName
            // 
            this.GuildName.Location = new System.Drawing.Point(12, 48);
            this.GuildName.Name = "GuildName";
            this.GuildName.Size = new System.Drawing.Size(121, 20);
            this.GuildName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Guild Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleDescription = "";
            this.richTextBox1.AccessibleName = "OutPut";
            this.richTextBox1.Location = new System.Drawing.Point(21, 636);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(933, 164);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(21, 600);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 33);
            this.label11.TabIndex = 10;
            this.label11.Text = "Output";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(515, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Players";
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.Location = new System.Drawing.Point(519, 84);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(214, 485);
            this.playersListBox.TabIndex = 12;
            this.playersListBox.SelectedIndexChanged += new System.EventHandler(this.playersListBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(739, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Guilds";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleDescription = "";
            this.listBox1.AccessibleName = "GuildsListBox";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(743, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 485);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(966, 812);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printGuildRoster;
        private System.Windows.Forms.Button disbandGuild;
        private System.Windows.Forms.Button joinGuild;
        private System.Windows.Forms.Button leaveGuild;
        private System.Windows.Forms.Button applySearchCriteria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox guildSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox playerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPlayerName;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox serverComboBox;
        private System.Windows.Forms.TextBox GuildName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addGuildButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox1;
    }
}

