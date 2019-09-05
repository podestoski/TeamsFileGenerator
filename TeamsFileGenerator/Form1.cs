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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TeamsFileGenerator
{
    public partial class Form1 : Form
    {

        private const string CLUBS_FILE = @"C:\Users\Spodesta\Documents\Projects\Android\FifaTournament\app\src\main\res\raw\teamsdata.xml";
        private const string NATIONAL_TEAMS_FILE = @"C:\Users\Spodesta\Documents\Projects\Android\FifaTournament\app\src\main\res\raw\nationalteamsdata.xml";

        private const string CLUBS_FILE_COPY = @"clubs_copy.xml";
        private const string NATIONAL_TEAMS_FILE_COPY = @"national_teams_copy.xml";

        LeagueCollection clubsCollection = null;
        LeagueCollection nationalTeamsCollection = null;
        LeagueCollection currentCollectionOnScreen;

        League selectedLeague;
        Team selectedTeam;

        int currentLeagueIndexSelected;
        int currentTeamIndexSelected;


        public Form1()
        {
            InitializeComponent();
            File.Copy(CLUBS_FILE, CLUBS_FILE_COPY, true);
            File.Copy(NATIONAL_TEAMS_FILE, NATIONAL_TEAMS_FILE_COPY, true);

            loadTeamsFromFileToCollection();
            currentCollectionOnScreen = clubsCollection;
            refreshListOnScreen();

        }

        private void listViewLeagues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLeagues.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listViewLeagues.SelectedIndices[0];
            currentLeagueIndexSelected = intselectedindex;
            selectedLeague = currentCollectionOnScreen.leagues.First(l => l.leaguename == listViewLeagues.Items[intselectedindex].Text);
            listViewTeams.Items.Clear();
            foreach (Team t in selectedLeague.teams)
            {
                listViewTeams.Items.Add(t.teamname);
            }
            

            btnDeleteLeague.Enabled = true;
            txtEditLeague.Text = selectedLeague.leaguename;
            btnEditLeague.Enabled = true;
            txtEditLeague.Enabled = true;

            btnDeleteTeam.Enabled = false;
            txtEditTeam.Text = String.Empty;
            btnEditTeam.Enabled = false;
            txtAddTeam.Enabled = true;
        }

        private void listViewTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeams.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listViewTeams.SelectedIndices[0];
            selectedTeam = selectedLeague.teams.First(t => t.teamname == listViewTeams.Items[intselectedindex].Text);
            currentTeamIndexSelected = intselectedindex;

            btnDeleteTeam.Enabled = true;
            txtEditTeam.Text = selectedTeam.teamname;
            btnEditTeam.Enabled = true;
            txtEditTeam.Enabled = true;
        }

        private void rbNationalTeams_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNationalTeams.Checked)
            {
                currentCollectionOnScreen = nationalTeamsCollection;
            }
            else
                currentCollectionOnScreen = clubsCollection;

            refreshListOnScreen();

        }

        private void txtAddLeague_TextChanged(object sender, EventArgs e)
        {
            btnAddLeague.Enabled = !(txtAddLeague.Text.Equals(String.Empty));
        }

        private void txtAddTeam_TextChanged(object sender, EventArgs e)
        {
            btnAddTeam.Enabled = !(txtAddTeam.Text.Equals(String.Empty));
        }

        private void txtEditLeague_TextChanged(object sender, EventArgs e)
        {
            btnEditLeague.Enabled = !(txtEditLeague.Text.Equals(String.Empty));
        }

        private void txtEditTeam_TextChanged(object sender, EventArgs e)
        {
            btnEditTeam.Enabled = !(txtEditTeam.Text.Equals(String.Empty));
        }


        private void btnDeleteLeague_Click(object sender, EventArgs e)
        {
            if (listViewLeagues.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("No League Selected");
                return;
            }
            int intselectedindex = listViewLeagues.SelectedIndices[0];
            currentCollectionOnScreen.leagues.Remove(selectedLeague);
            MessageBox.Show("League Deleted");
            refreshListOnScreen();

        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (listViewTeams.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("No Team Selected");
                return;
            }
            selectedLeague.teams.Remove(selectedTeam);
            refreshListOnScreen();
            MessageBox.Show("Team Deleted");
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LeagueCollection));

            orderTeams();

            StreamWriter writer = new StreamWriter(CLUBS_FILE_COPY);
            serializer.Serialize(writer, clubsCollection);
            writer.Close();

            writer = new StreamWriter(NATIONAL_TEAMS_FILE_COPY);
            serializer.Serialize(writer, nationalTeamsCollection);
            writer.Close();

            loadTeamsFromFileToCollection();
            refreshListOnScreen();
            MessageBox.Show("File Written");

        }

        private void btnAddLeague_Click(object sender, EventArgs e)
        {
            League newLeague = new League();
            newLeague.leaguename = txtAddLeague.Text;
            List<Team> teams = new List<Team>();
            newLeague.teams = teams;
            currentCollectionOnScreen.leagues.Add(newLeague);
            refreshListOnScreen();
            MessageBox.Show("League Added");
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            Team newTeam = new Team();
            newTeam.teamname = txtAddTeam.Text;
            selectedLeague.teams.Add(newTeam);
            refreshListOnScreen();
            MessageBox.Show("Team Added");
        }

        private void btnEditLeague_Click(object sender, EventArgs e)
        {
            selectedLeague.leaguename = txtEditLeague.Text;
            refreshListOnScreen();
            MessageBox.Show("League Edited");
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            selectedTeam.teamname = txtEditTeam.Text;
            refreshListOnScreen();
            MessageBox.Show("Team Edited");
        }

        private void refreshListOnScreen()
        {
            orderTeams();
            listViewLeagues.Items.Clear();
            foreach (League l in currentCollectionOnScreen.leagues)
            {
                listViewLeagues.Items.Add(l.leaguename);
            }
            listViewTeams.Items.Clear();

            btnDeleteLeague.Enabled = false;
            txtEditLeague.Text = String.Empty;
            btnEditLeague.Enabled = false;
            txtAddLeague.Text = String.Empty;
            btnAddLeague.Enabled = false;
            txtEditLeague.Enabled = false;

            btnDeleteTeam.Enabled = false;
            txtEditTeam.Text = String.Empty;
            btnEditTeam.Enabled = false;
            txtAddTeam.Text = String.Empty;
            btnAddTeam.Enabled = false;
            txtAddTeam.Enabled = false;
            txtEditTeam.Enabled = false;
        }

        private void orderTeams()
        {
            clubsCollection.leagues = clubsCollection.leagues.OrderBy(league => league.leaguename).ToList();
            int i = 1;
            int j = 1;
            foreach (League league in clubsCollection.leagues)
            {
                league.idLeague = i;
                i++;
                if (league.teams.Count > 0)
                {
                    league.teams = league.teams.OrderBy(team => team.teamname).ToList();
                    foreach (Team team in league.teams)
                    {
                        team.idTeam = j;
                        j++;
                        team.teamresource = "club_" + team.teamname.ToLower().Replace(" ", "_") + ".png";
                    }
                }
            }

            nationalTeamsCollection.leagues = nationalTeamsCollection.leagues.OrderBy(league => league.leaguename).ToList();
            i = 1;
            j = 1;
            foreach (League league in nationalTeamsCollection.leagues)
            {
                league.idLeague = i;
                i++;
                league.teams = league.teams.OrderBy(team => team.teamname).ToList();
                if (league.teams.Count > 0)
                { 
                    foreach (Team team in league.teams)
                    {
                        team.idTeam = j;
                        j++;
                        team.teamresource = "nt_" + team.teamname.ToLower().Replace(" ", "_") + ".png";
                    }
                }
            }
        }

        private void loadTeamsFromFileToCollection()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LeagueCollection));

            // Clubs
            string path = CLUBS_FILE_COPY;
            StreamReader reader = new StreamReader(path);
            clubsCollection = (LeagueCollection)serializer.Deserialize(reader);
            reader.Close();

            // National Teams
            path = NATIONAL_TEAMS_FILE_COPY;
            reader = new StreamReader(path);
            nationalTeamsCollection = (LeagueCollection)serializer.Deserialize(reader);
            reader.Close();

        }

        
    }
}
