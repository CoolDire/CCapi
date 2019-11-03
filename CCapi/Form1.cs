using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Jason;
using Launcher;
using ServiceStack.Text;

namespace CCapi {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            getLastFive();
            DateTime now = DateTime.Now.ToLocalTime();
            tbTimeNow.Text = now.ToLongDateString() + " at " + now.ToShortTimeString();
        }
        #region Players
        private void bLookup_Click(object sender, EventArgs e) {
            lbNotes.Items.Clear();
            tabPage1.BackColor = Color.White;
            DateTime now = DateTime.Now.ToLocalTime();
            tbTimeNow.Text = now.ToLongDateString() + " at " + now.ToShortTimeString();
            getPlayer(4);
        }
        private void BName_Click(object sender, EventArgs e) {
            lbNotes.Items.Clear();
            tabPage1.BackColor = Color.White;
            DateTime now = DateTime.Now.ToLocalTime();
            tbTimeNow.Text = now.ToLongDateString() + " at " + now.ToShortTimeString();
            getPlayer(3);
        }
        private void bIDLookup_Click(object sender, EventArgs e) {
            lbNotes.Items.Clear();
            tabPage1.BackColor = Color.White;
            DateTime now = DateTime.Now.ToLocalTime();
            tbTimeNow.Text = now.ToLongDateString() + " at " + now.ToShortTimeString();
            getPlayer(2);
        }
        private void tBSearch_Key(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                getPlayer(4);
            }
        }


        // Gets a players info
        private void getPlayer(byte function) {
            string name = tBSearch.Text;
            JsonObject result = null;
            string api;

            if (function == 2) {
                api = "id/";
                int id;               
                if (!int.TryParse(name, out id)) {
                    MessageBox.Show("That is not a valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else if (function == 3) {
                api = "player/";
            } else {
                api = "player/";
            }

            switch (function) {
                case 1:
                case 2:
                    result = GetUserData(api + name);
                    if (result == null) return;

                    if (result.Get("error") == Constants.NotFound) {
                        MessageBox.Show("No player found by that ID!, it may have belonged to a deleted account", "Non Existent ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 3:
                    result = GetUserData(api + name);
                    if (result == null) return;

                    if (result.Get("error") == Constants.NotFound)
                    {
                        MessageBox.Show("No player found by that username!, it hasn't been registered yet or may have been a former deleted account", "Non Existent Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 4:
                    result = GetUserData("player/" + name);
                    if (result == null) return;
                    if (result.Get("error") != Constants.NotFound) break;

                    result = GetUserData("id/" + name);
                    if (result == null) return;

                    if (result.Get("error") == Constants.NotFound) {
                        MessageBox.Show("No player found by that username or ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }

            JsonObject pcount = null;
            pcount = JsonObject.Parse((new WebClient()).DownloadString("https://www.classicube.net/api/players"));
            int totalplayers = Int32.Parse(pcount.Get("playercount"));
            int modifier = 173;
            int realpcount = totalplayers + modifier;
            int playerid = Int32.Parse(result.Get("id"));
            int regsince = realpcount - playerid;
            int regsinceexcldel = totalplayers - playerid;
            tbAccSince.Text = regsince.ToString();
            tbAccSinceExclDel.Text = regsinceexcldel.ToString();
            tbUserName.Text = result.Get("username");
            if (result.Get("premium") == "true") {
                cbPremium.Checked = true;
                lbNotes.Items.Add("This Account was once a premium account");
            }
            else {
                cbPremium.Checked = false;
                lbNotes.Items.Remove("This Account was once a premium account");
            }

            int adjid = Int32.Parse(result.Get("id")) - modifier;
            tbID.Text = result.Get("id");
            tbAdjID.Text = adjid.ToString();            
            DateTime registered = Constants.Epoch.AddSeconds(double.Parse(result.Get("registered"))).ToLocalTime();
            DateTime ESTregistered = Constants.Epoch.AddSeconds(double.Parse(result.Get("registered"))).Subtract(TimeSpan.FromHours(5));
            tbRegistered.Text = registered.ToLongDateString() + " at " + registered.ToShortTimeString();
            tbESTRegistered.Text = ESTregistered.ToLongDateString() + " at " + ESTregistered.ToShortTimeString();
            string flagsResult = result.Get("flags");
            string flags = "User - ";
            //TimeSpan reg = now - registered;
            //double yreg = (int)(reg.TotalDays / 365);
            //double mreg = ((reg.TotalDays / 365) / 12 * 12);

            foreach (var kvp in Constants.UserFlags) {
                if (flagsResult.IndexOf(kvp.Key) >= 0)
                    flags += kvp.Value + " - ";
            }
            tbFlags.Text = flags.Remove(flags.Length - 2, 2);
            tbFlagsRaw.Text = flagsResult.ToString();
            pictureBox1.Image = getAvatar(result.Get("username"));
            if (getSkin(result.Get("username")) == null) {
                try {
                    pictureBox2.Image = getDefaultSkin();
                } catch {
                    MessageBox.Show("Unable to retrieve skin, is classicube.net down", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                pictureBox2.Image = getSkin(result.Get("username"));
            }
            rtbURaw.Text = result.Dump();
            llURaw.Text = "Data for " + result.Get("username");
            if (flagsResult.Contains("a") && flagsResult.Contains("p"))
            {
                cbAdmin.Checked = true;
                cbPatron.Checked = true;
                lbNotes.Items.Add("This Account can access the Classicube Admin Panel");
                lbNotes.Items.Add("This Account also belongs to a player who supports Classicube");
                tabPage1.BackColor = Color.Goldenrod;
            }
            else if (flagsResult.Contains("a"))
            {
                cbAdmin.Checked = true;
                lbNotes.Items.Add("This Account can access the Classicube Admin Panel and Forum Admin Panel");
                tabPage1.BackColor = Color.Goldenrod;
            }
            else if (flagsResult.Contains("p"))
            {
                cbPatron.Checked = true;
                lbNotes.Items.Add("This Account belongs to a player who supports Classicube");
                tabPage1.BackColor = Color.Lavender;
            }
            else
            {
                cbAdmin.Checked = false;
                cbPatron.Checked = false;
                lbNotes.Items.Remove("This Account can access the Classicube Admin Panel");
                lbNotes.Items.Remove("This Account belongs to a player who supports Classicube");
            }
            if (flagsResult.Contains("e"))
            {
                cbEditor.Checked = true;
                lbNotes.Items.Add("This Account has Classicube home page blog editing permissions");
            }
            else
            {
                cbEditor.Checked = false;
                lbNotes.Items.Remove("This Account has Classicube home page blog editing permissions");
            }
            if (flagsResult.Contains("d")) {
                cbDev.Checked = true;
                lbNotes.Items.Add("This Account belongs to an Official Classicube Developer");
            }
            else
            {
                cbDev.Checked = false;
                lbNotes.Items.Remove("This Account belongs to an Official Classicube Developer");

            }
            if (flagsResult.Contains("m")) {
                cbMod.Checked = true;
                lbNotes.Items.Add("This Account can Moderate the Classicube Forum and view any post (including hidden posts)");
            }
            else
            {
                cbMod.Checked = false;
                lbNotes.Items.Remove("This Account can Moderate the Classicube Forum and view any post (including hidden posts)");
            }
            if (flagsResult.Contains("b")) {
                cbBanned.Checked = true;
                lbNotes.Items.Add("This Account is banned from the forums thus it does not have access");
                tabPage1.BackColor = Color.Red;
            }
            else
            {
                cbBanned.Checked = false;
                lbNotes.Items.Remove("This Account is banned from the forums thus it does not have access");

            }
            if (flagsResult.Contains("u")) {
                cbUnverified.Checked = true;
                lbNotes.Items.Add("This Account hasn't been verified yet");
                tabPage1.BackColor = Color.Gray;
            }
            else
            {
                cbUnverified.Checked = false;
                lbNotes.Items.Remove("This Account hasn't been verified yet");

            }
            if (flagsResult.Contains("r")) {
                cbRecover.Checked = true;
                lbNotes.Items.Add("This Account has a pending password recovery email request");
                tabPage1.BackColor = Color.SkyBlue;
            }
            else
            {
                cbRecover.Checked = false;
                lbNotes.Items.Remove("This Account has a pending password recovery email request");
            }
            if (flagsResult.Length == 2)
            {
                tabPage1.BackColor = Color.White;
                lbNotes.Items.Add("This is a regular Classicube User");
            }

        }

        // Gets User Data from the API
        JsonObject GetUserData(string apiPoint) {
            try {
                string raw = new WebClient().DownloadString("https://www.classicube.net/api/" + apiPoint);
                return JsonObject.Parse(raw);
            } catch {
                MessageBox.Show("Failed to retrieve API data. ClassiCube.net might be down!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        
        // Gets the Users Avatar from the website
        private Image getAvatar(string name) {
            try {
                Stream stream = new WebClient().OpenRead("https://classicube.s3.amazonaws.com/face/" + name + ".png");
                return Image.FromStream(stream);
            } catch {
                MessageBox.Show("Failed to retrieve avatar. ClassiCube.net might be down!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // Gets the Users Skin from the skin server

        private Image getSkin(string name) {
            try
            {
                Stream stream = new WebClient().OpenRead("https://classicube.s3.amazonaws.com/skin/" + name + ".png");
                return Image.FromStream(stream);
            } catch {
                MessageBox.Show("Failed to retrieve skin. ClassiCube.net might be down!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // Gets the Default Skin from the skin server

        private Image getDefaultSkin()
        {
                Stream stream = new WebClient().OpenRead("https://www.classicube.net/static/default.png");
                return Image.FromStream(stream);
        }

        // Gets the Last 5 Accounts registered
        private void getLastFive() {
            JsonObject result = null;
            Regex nan = new Regex("[^a-zA-Z0-9_.,]");
            try {
                result = JsonObject.Parse((new WebClient()).DownloadString("https://www.classicube.net/api/players"));
                tbLast5.Text = nan.Replace(result.Get("lastfive"), "").Replace(",", Environment.NewLine);
                int plcount = Int32.Parse(result.Get("playercount"));
                int modifier = 173;
                int realpcount = plcount + modifier;
                tbTotal.Text = realpcount.ToString();
                tbTotalexdel.Text = result.Get("playercount");
            } catch {
                MessageBox.Show("Failed to retrieve last five accounts. ClassiCube.net might be down!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void BRawLast5_Click_1(object sender, EventArgs e) {

        }
        private void BRefresh_Click(object sender, EventArgs e)
        {
            lbNotes.Items.Clear();
            tabPage1.BackColor = Color.White;
            DateTime now = DateTime.Now.ToLocalTime();
            tbTimeNow.Text = now.ToLongDateString() + " at " + now.ToShortTimeString();
            getPlayer(4);
        }
        private void LlURaw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string name = tBSearch.Text;
            System.Diagnostics.Process.Start("https://www.classicube.net/api/player/" + name);
        }
        private void BRefreshLast5_Click_1(object sender, EventArgs e) {
           getLastFive();
        }
        #endregion
        #region Servers

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e) {
            getServerInfo();
        }         
        private void tabControl1_Change(object sender, EventArgs e) {
            if (tabs.TabIndex == 1) {
                getServers();
                FilterList();
            }
        }
        private void bRefreshServers_Click(object sender, EventArgs e) {
            getServers();
        }
        List<ccServer> servers;
        private void getServers() {
            servers = GetPublicServers();
            cbServer.Items.Clear();
            tbPlayers.Text = "";
            txMaxPlayers.Text = "";
            tbUptime.Text = "";
            tbSoftware.Text = "";
            tbCountry.Text = "";
            tbCountryFull.Text = "";
            tbName.Text = "";
            tbFeatured.Text = "";
            for (int i = 0; i < servers.Count; i++) {
                cbServer.Items.Add(servers[i].Name);
            }
        }

        public List<ccServer> GetPublicServers()
        {
            List<ccServer> servers = new List<ccServer>();
            string response = new WebClient().DownloadString("https://www.classicube.net/api/servers");
            int index = 0; bool success = true;
            Dictionary<string, object> root =
                (Dictionary<string, object>)Json.ParseValue(response, ref index, ref success);
            List<object> list = (List<object>)root["servers"];

            foreach (object server in list)
            {
                Dictionary<string, object> pairs = (Dictionary<string, object>)server;
                servers.Add(new ccServer(
                    (string)pairs["hash"], (string)pairs["name"],
                    (string)pairs["players"], (string)pairs["maxplayers"],
                     (string)pairs["uptime"], (string)pairs["software"],
                    (string)pairs["country_abbr"], (bool)pairs["featured"]));
            }
            return servers;
        }

        public void FilterList() {
            serverstable.Items.Clear();
            IComparer sorter = serverstable.ListViewItemSorter;
            serverstable.ListViewItemSorter = null;

            for (int i = 0; i < servers.Count; i++) {
                ccServer entry = servers[i];
                   string[] row = { entry.Name, entry.Players, entry.MaximumPlayers, entry.Software, timeToString(TimeSpan.FromSeconds(double.Parse(entry.Uptime))), entry.Country.ToString(), entry.Featured.ToString(), entry.Hash};
                   serverstable.Items.Add(new ListViewItem(row));              
            }

            if ( sorter != null) {
                serverstable.ListViewItemSorter = sorter;
                serverstable.Sort();
            }
            serverstable.EndUpdate();
        }

        private void getServerInfo() {
            tbName.Text = servers[cbServer.SelectedIndex].Name;
            tbPlayers.Text = servers[cbServer.SelectedIndex].Players;
            txMaxPlayers.Text = servers[cbServer.SelectedIndex].MaximumPlayers;
            tbUptime.Text = timeToString(TimeSpan.FromSeconds(double.Parse(servers[cbServer.SelectedIndex].Uptime)));
            tbSoftware.Text = servers[cbServer.SelectedIndex].Software;
            tbHash.Text = servers[cbServer.SelectedIndex].Hash;
            tbCountry.Text = servers[cbServer.SelectedIndex].Country;
            tbFeatured.Text = servers[cbServer.SelectedIndex].Featured.ToString();
            rtbSRaw.Text = servers[cbServer.SelectedIndex].Dump();
            llSRaw.Text = "Data for " + servers[cbServer.SelectedIndex].Name; 
            
                        
            string countryresult = servers[cbServer.SelectedIndex].Country;
            string country = countryresult + " - ";

            foreach (var kvp in Constants.Country)
            {
                if (countryresult.IndexOf(kvp.Key) >= 0)
                    country += kvp.Value + " - ";
            }
            tbCountryFull.Text = country.Remove(country.Length - 2, 2);
            return;
        }

        private string timeToString(TimeSpan span) {
            if (span.TotalSeconds < 60) {
                return String.Format("{0} seconds", span.Seconds);
            } else if (span.TotalMinutes < 60) {
                return String.Format("{0} minutes {1} seconds", span.Minutes, span.Seconds);
            } else if (span.TotalHours < 48) {
                return String.Format("{0} hours {1} minutes", (int)Math.Floor(span.TotalHours), span.Minutes);
            } else if (span.TotalDays < 15) {
                return String.Format("{0} days {1} hours", span.Days, span.Hours);
            } else {
                return String.Format("{0:0} weeks {1:0} days", Math.Floor(span.TotalDays / 7), Math.Floor(span.TotalDays) % 7);
            }
        }

        private void bRawLast5_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.classicube.net/api/players");
        }

        private void bRawPlayer_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.classicube.net/api/id/" + tbID.Text);
        }

        private void bRawServer_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.classicube.net/api/servers");
        }

        private void bOpenHash_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.classicube.net/server/play/" + servers[cbServer.SelectedIndex].Hash);
        }

        private void lSRaw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            string shash = tbHash.Text;
            System.Diagnostics.Process.Start("https://www.classicube.net/api/server/" + shash);
        }

        private void bFServers_Click(object sender, EventArgs e)
        {
            rtSList.Text = servers.Dump();
        }

        private void BtnDload_Click(object sender, EventArgs e)
        {
            string uname = tbUserName.Text;
            System.Diagnostics.Process.Start("https://classicube.s3.amazonaws.com/skin/" + uname + ".png");
        }

        private void BtnDload2_Click(object sender, EventArgs e)
        {
            string uname = tbUserName.Text;
            System.Diagnostics.Process.Start("https://classicube.s3.amazonaws.com/face/" + uname + ".png");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        private void Serverstable_ColumnClick_1(object sender, ColumnClickEventArgs e)
        {
            NameComparer ccNameComparer = new NameComparer(0);
            NumericalComparer ccPlayersComparer = new NumericalComparer(1);
            NumericalComparer ccMaxPlayersComparer = new NumericalComparer(2);
            UptimeComparer ccUptimeComparer = new UptimeComparer(3);
            CountryComparer ccCountryComparer = new CountryComparer(4);
            NameComparer ccFeaturedComparer = new NameComparer(5);

            if (e.Column == 0)
            {
                ccNameComparer.Invert = !ccNameComparer.Invert;
                serverstable.ListViewItemSorter = ccNameComparer;
            }
            else if (e.Column == 1)
            {
                ccPlayersComparer.Invert = !ccPlayersComparer.Invert;
                serverstable.ListViewItemSorter = ccPlayersComparer;
            }
            else if (e.Column == 2)
            {
                ccMaxPlayersComparer.Invert = !ccMaxPlayersComparer.Invert;
                serverstable.ListViewItemSorter = ccMaxPlayersComparer;
            }
            
            else if (e.Column == 3)
            {
                ccNameComparer.Invert = !ccNameComparer.Invert;
                serverstable.ListViewItemSorter = ccNameComparer;
            }
            else if (e.Column == 4)
            {
                ccUptimeComparer.Invert = !ccUptimeComparer.Invert;
                serverstable.ListViewItemSorter = ccUptimeComparer;
            }
            else if (e.Column == 5)
            {
                ccCountryComparer.Invert = !ccCountryComparer.Invert;
                serverstable.ListViewItemSorter = ccCountryComparer;
            }
            else if (e.Column == 6)
            {
                ccFeaturedComparer.Invert = !ccFeaturedComparer.Invert;
                serverstable.ListViewItemSorter = ccFeaturedComparer;
            }
            serverstable.Sort();
        }

        private void BDloadDefault_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.classicube.net/static/default.png");
        }
    }
    public class ccServer {
        public string Hash { get; set; }
        public string MaximumPlayers { get; set; }
        public string Name { get; set; }
        public string Players { get; set; }
        public string Software { get; set; }
        public string Uptime { get; set; }
        public string Country { get; set; }
        public bool Featured { get; set; }

        public ccServer(string hash, string name, string players, string maxPlayers, string uptime, string software, string country_abbr, bool featured) {
            Hash = hash;
            Name = name;
            Players = players;
            MaximumPlayers = maxPlayers;
            Uptime = uptime;
            Software = software;
            Country = country_abbr;
            Featured = featured;
        }
    }
    #endregion
}
