namespace TeamsFileGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbClubs = new System.Windows.Forms.RadioButton();
            this.rbNationalTeams = new System.Windows.Forms.RadioButton();
            this.listViewLeagues = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewTeams = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteLeague = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnAddLeague = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnEditLeague = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtAddLeague = new System.Windows.Forms.TextBox();
            this.txtAddTeam = new System.Windows.Forms.TextBox();
            this.txtEditLeague = new System.Windows.Forms.TextBox();
            this.txtEditTeam = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbClubs
            // 
            this.rbClubs.AutoSize = true;
            this.rbClubs.Checked = true;
            this.rbClubs.Location = new System.Drawing.Point(6, 19);
            this.rbClubs.Name = "rbClubs";
            this.rbClubs.Size = new System.Drawing.Size(51, 17);
            this.rbClubs.TabIndex = 0;
            this.rbClubs.TabStop = true;
            this.rbClubs.Text = "Clubs";
            this.rbClubs.UseVisualStyleBackColor = true;
            // 
            // rbNationalTeams
            // 
            this.rbNationalTeams.AutoSize = true;
            this.rbNationalTeams.Location = new System.Drawing.Point(81, 19);
            this.rbNationalTeams.Name = "rbNationalTeams";
            this.rbNationalTeams.Size = new System.Drawing.Size(99, 17);
            this.rbNationalTeams.TabIndex = 1;
            this.rbNationalTeams.Text = "National Teams";
            this.rbNationalTeams.UseVisualStyleBackColor = true;
            this.rbNationalTeams.CheckedChanged += new System.EventHandler(this.rbNationalTeams_CheckedChanged);
            // 
            // listViewLeagues
            // 
            this.listViewLeagues.Location = new System.Drawing.Point(34, 91);
            this.listViewLeagues.MultiSelect = false;
            this.listViewLeagues.Name = "listViewLeagues";
            this.listViewLeagues.Size = new System.Drawing.Size(210, 216);
            this.listViewLeagues.TabIndex = 2;
            this.listViewLeagues.UseCompatibleStateImageBehavior = false;
            this.listViewLeagues.View = System.Windows.Forms.View.List;
            this.listViewLeagues.SelectedIndexChanged += new System.EventHandler(this.listViewLeagues_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leagues";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teams";
            // 
            // listViewTeams
            // 
            this.listViewTeams.Location = new System.Drawing.Point(312, 91);
            this.listViewTeams.Name = "listViewTeams";
            this.listViewTeams.Size = new System.Drawing.Size(423, 216);
            this.listViewTeams.TabIndex = 5;
            this.listViewTeams.UseCompatibleStateImageBehavior = false;
            this.listViewTeams.View = System.Windows.Forms.View.List;
            this.listViewTeams.SelectedIndexChanged += new System.EventHandler(this.listViewTeams_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClubs);
            this.groupBox1.Controls.Add(this.rbNationalTeams);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnDeleteLeague
            // 
            this.btnDeleteLeague.Enabled = false;
            this.btnDeleteLeague.Location = new System.Drawing.Point(169, 385);
            this.btnDeleteLeague.Name = "btnDeleteLeague";
            this.btnDeleteLeague.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLeague.TabIndex = 7;
            this.btnDeleteLeague.Text = "Delete";
            this.btnDeleteLeague.UseVisualStyleBackColor = true;
            this.btnDeleteLeague.Click += new System.EventHandler(this.btnDeleteLeague_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Enabled = false;
            this.btnDeleteTeam.Location = new System.Drawing.Point(581, 383);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTeam.TabIndex = 8;
            this.btnDeleteTeam.Text = "Delete";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnAddLeague
            // 
            this.btnAddLeague.Enabled = false;
            this.btnAddLeague.Location = new System.Drawing.Point(169, 328);
            this.btnAddLeague.Name = "btnAddLeague";
            this.btnAddLeague.Size = new System.Drawing.Size(75, 23);
            this.btnAddLeague.TabIndex = 10;
            this.btnAddLeague.Text = "Add";
            this.btnAddLeague.UseVisualStyleBackColor = true;
            this.btnAddLeague.Click += new System.EventHandler(this.btnAddLeague_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Enabled = false;
            this.btnAddTeam.Location = new System.Drawing.Point(581, 328);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 11;
            this.btnAddTeam.Text = "Add";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnEditLeague
            // 
            this.btnEditLeague.Enabled = false;
            this.btnEditLeague.Location = new System.Drawing.Point(169, 358);
            this.btnEditLeague.Name = "btnEditLeague";
            this.btnEditLeague.Size = new System.Drawing.Size(75, 23);
            this.btnEditLeague.TabIndex = 12;
            this.btnEditLeague.Text = "Edit";
            this.btnEditLeague.UseVisualStyleBackColor = true;
            this.btnEditLeague.Click += new System.EventHandler(this.btnEditLeague_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Enabled = false;
            this.btnEditTeam.Location = new System.Drawing.Point(581, 356);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(75, 23);
            this.btnEditTeam.TabIndex = 13;
            this.btnEditTeam.Text = "Edit";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(662, 326);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 82);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Write File";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtAddLeague
            // 
            this.txtAddLeague.Location = new System.Drawing.Point(34, 328);
            this.txtAddLeague.Name = "txtAddLeague";
            this.txtAddLeague.Size = new System.Drawing.Size(129, 20);
            this.txtAddLeague.TabIndex = 15;
            this.txtAddLeague.TextChanged += new System.EventHandler(this.txtAddLeague_TextChanged);
            // 
            // txtAddTeam
            // 
            this.txtAddTeam.Enabled = false;
            this.txtAddTeam.Location = new System.Drawing.Point(312, 328);
            this.txtAddTeam.Name = "txtAddTeam";
            this.txtAddTeam.Size = new System.Drawing.Size(263, 20);
            this.txtAddTeam.TabIndex = 16;
            this.txtAddTeam.TextChanged += new System.EventHandler(this.txtAddTeam_TextChanged);
            // 
            // txtEditLeague
            // 
            this.txtEditLeague.Enabled = false;
            this.txtEditLeague.Location = new System.Drawing.Point(34, 358);
            this.txtEditLeague.Name = "txtEditLeague";
            this.txtEditLeague.Size = new System.Drawing.Size(129, 20);
            this.txtEditLeague.TabIndex = 17;
            this.txtEditLeague.TextChanged += new System.EventHandler(this.txtEditLeague_TextChanged);
            // 
            // txtEditTeam
            // 
            this.txtEditTeam.Enabled = false;
            this.txtEditTeam.Location = new System.Drawing.Point(312, 357);
            this.txtEditTeam.Name = "txtEditTeam";
            this.txtEditTeam.Size = new System.Drawing.Size(263, 20);
            this.txtEditTeam.TabIndex = 18;
            this.txtEditTeam.TextChanged += new System.EventHandler(this.txtEditTeam_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditTeam);
            this.Controls.Add(this.txtEditLeague);
            this.Controls.Add(this.txtAddTeam);
            this.Controls.Add(this.txtAddLeague);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.btnEditLeague);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnAddLeague);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.btnDeleteLeague);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewTeams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewLeagues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Teams File";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbClubs;
        private System.Windows.Forms.RadioButton rbNationalTeams;
        private System.Windows.Forms.ListView listViewLeagues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewTeams;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteLeague;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Button btnAddLeague;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnEditLeague;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtAddLeague;
        private System.Windows.Forms.TextBox txtAddTeam;
        private System.Windows.Forms.TextBox txtEditLeague;
        private System.Windows.Forms.TextBox txtEditTeam;
    }
}

