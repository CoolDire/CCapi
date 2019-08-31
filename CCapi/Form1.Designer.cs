namespace CCapi {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbAccSinceExclDel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAccSince = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefreshSkin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbUserFor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bRawPlayer = new System.Windows.Forms.Button();
            this.lRegistered = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.bIDLookup = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbRegistered = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.bLookup = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFlags = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalexdel = new System.Windows.Forms.TextBox();
            this.bRawLast5 = new System.Windows.Forms.Button();
            this.tbLast5 = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.bRefreshLast5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bOpenHash = new System.Windows.Forms.Button();
            this.lHash = new System.Windows.Forms.Label();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.bRawServer = new System.Windows.Forms.Button();
            this.lof = new System.Windows.Forms.Label();
            this.lPlayers = new System.Windows.Forms.Label();
            this.lSoftware = new System.Windows.Forms.Label();
            this.lUptime = new System.Windows.Forms.Label();
            this.lServer = new System.Windows.Forms.Label();
            this.txMaxPlayers = new System.Windows.Forms.TextBox();
            this.tbSoftware = new System.Windows.Forms.TextBox();
            this.tbUptime = new System.Windows.Forms.TextBox();
            this.tbPlayers = new System.Windows.Forms.TextBox();
            this.bRefreshServers = new System.Windows.Forms.Button();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(4, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(594, 438);
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_Change);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbAccSinceExclDel);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.tbAccSince);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(9, 306);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(574, 90);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "User\'s Stats";
            // 
            // tbAccSinceExclDel
            // 
            this.tbAccSinceExclDel.Location = new System.Drawing.Point(274, 43);
            this.tbAccSinceExclDel.Name = "tbAccSinceExclDel";
            this.tbAccSinceExclDel.ReadOnly = true;
            this.tbAccSinceExclDel.Size = new System.Drawing.Size(100, 22);
            this.tbAccSinceExclDel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accounts registered since this user excl Deleted:";
            // 
            // tbAccSince
            // 
            this.tbAccSince.Location = new System.Drawing.Point(209, 15);
            this.tbAccSince.Name = "tbAccSince";
            this.tbAccSince.ReadOnly = true;
            this.tbAccSince.Size = new System.Drawing.Size(100, 22);
            this.tbAccSince.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts registered since this user:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRefreshSkin);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(443, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 175);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Skin";
            // 
            // btnRefreshSkin
            // 
            this.btnRefreshSkin.Enabled = false;
            this.btnRefreshSkin.Location = new System.Drawing.Point(6, 146);
            this.btnRefreshSkin.Name = "btnRefreshSkin";
            this.btnRefreshSkin.Size = new System.Drawing.Size(127, 23);
            this.btnRefreshSkin.TabIndex = 1;
            this.btnRefreshSkin.Text = "Refresh";
            this.toolTip1.SetToolTip(this.btnRefreshSkin, "Refresh the selected user\'s skin.");
            this.btnRefreshSkin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbUserFor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.bRawPlayer);
            this.groupBox3.Controls.Add(this.lRegistered);
            this.groupBox3.Controls.Add(this.lID);
            this.groupBox3.Controls.Add(this.lUserName);
            this.groupBox3.Controls.Add(this.bIDLookup);
            this.groupBox3.Controls.Add(this.tbUserName);
            this.groupBox3.Controls.Add(this.tbRegistered);
            this.groupBox3.Controls.Add(this.tbID);
            this.groupBox3.Controls.Add(this.bLookup);
            this.groupBox3.Controls.Add(this.tBSearch);
            this.groupBox3.Location = new System.Drawing.Point(215, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 216);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Info";
            // 
            // tbUserFor
            // 
            this.tbUserFor.Location = new System.Drawing.Point(9, 181);
            this.tbUserFor.Name = "tbUserFor";
            this.tbUserFor.ReadOnly = true;
            this.tbUserFor.Size = new System.Drawing.Size(159, 22);
            this.tbUserFor.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Classicube User for:";
            // 
            // bRawPlayer
            // 
            this.bRawPlayer.Location = new System.Drawing.Point(182, 97);
            this.bRawPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.bRawPlayer.Name = "bRawPlayer";
            this.bRawPlayer.Size = new System.Drawing.Size(37, 23);
            this.bRawPlayer.TabIndex = 32;
            this.bRawPlayer.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawPlayer, "Open the account\'s info in raw JSON.");
            this.bRawPlayer.UseVisualStyleBackColor = true;
            this.bRawPlayer.Click += new System.EventHandler(this.bRawPlayer_Click);
            // 
            // lRegistered
            // 
            this.lRegistered.AutoSize = true;
            this.lRegistered.Location = new System.Drawing.Point(6, 107);
            this.lRegistered.Name = "lRegistered";
            this.lRegistered.Size = new System.Drawing.Size(65, 13);
            this.lRegistered.TabIndex = 31;
            this.lRegistered.Text = "Registered:";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(166, 50);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 13);
            this.lID.TabIndex = 30;
            this.lID.Text = "ID:";
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(6, 50);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(61, 13);
            this.lUserName.TabIndex = 29;
            this.lUserName.Text = "Username:";
            // 
            // bIDLookup
            // 
            this.bIDLookup.Location = new System.Drawing.Point(190, 21);
            this.bIDLookup.Name = "bIDLookup";
            this.bIDLookup.Size = new System.Drawing.Size(29, 23);
            this.bIDLookup.TabIndex = 28;
            this.bIDLookup.Text = "ID";
            this.toolTip1.SetToolTip(this.bIDLookup, "Perform a lookup with a user\'s ID.");
            this.bIDLookup.UseVisualStyleBackColor = true;
            this.bIDLookup.Click += new System.EventHandler(this.bIDLookup_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(6, 67);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(153, 22);
            this.tbUserName.TabIndex = 27;
            // 
            // tbRegistered
            // 
            this.tbRegistered.Location = new System.Drawing.Point(6, 124);
            this.tbRegistered.Multiline = true;
            this.tbRegistered.Name = "tbRegistered";
            this.tbRegistered.ReadOnly = true;
            this.tbRegistered.Size = new System.Drawing.Size(213, 34);
            this.tbRegistered.TabIndex = 26;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(165, 67);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(54, 22);
            this.tbID.TabIndex = 25;
            // 
            // bLookup
            // 
            this.bLookup.Location = new System.Drawing.Point(130, 21);
            this.bLookup.Name = "bLookup";
            this.bLookup.Size = new System.Drawing.Size(54, 23);
            this.bLookup.TabIndex = 24;
            this.bLookup.Text = "Lookup Player/ID";
            this.toolTip1.SetToolTip(this.bLookup, "Perform a lookup with a username.");
            this.bLookup.UseVisualStyleBackColor = true;
            this.bLookup.Click += new System.EventHandler(this.bLookup_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(6, 21);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(118, 22);
            this.tBSearch.TabIndex = 23;
            this.tBSearch.Text = "Player Name/ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFlags);
            this.groupBox2.Location = new System.Drawing.Point(9, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 72);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User\'s Flag(s):";
            // 
            // tbFlags
            // 
            this.tbFlags.Location = new System.Drawing.Point(6, 17);
            this.tbFlags.Multiline = true;
            this.tbFlags.Name = "tbFlags";
            this.tbFlags.ReadOnly = true;
            this.tbFlags.Size = new System.Drawing.Size(561, 49);
            this.tbFlags.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTotalexdel);
            this.groupBox1.Controls.Add(this.bRawLast5);
            this.groupBox1.Controls.Add(this.tbLast5);
            this.groupBox1.Controls.Add(this.lTotal);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.bRefreshLast5);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 216);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Five Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Accounts excl Deleted:";
            // 
            // tbTotalexdel
            // 
            this.tbTotalexdel.Location = new System.Drawing.Point(16, 177);
            this.tbTotalexdel.Name = "tbTotalexdel";
            this.tbTotalexdel.ReadOnly = true;
            this.tbTotalexdel.Size = new System.Drawing.Size(94, 22);
            this.tbTotalexdel.TabIndex = 10;
            // 
            // bRawLast5
            // 
            this.bRawLast5.Location = new System.Drawing.Point(6, 21);
            this.bRawLast5.Margin = new System.Windows.Forms.Padding(2);
            this.bRawLast5.Name = "bRawLast5";
            this.bRawLast5.Size = new System.Drawing.Size(37, 23);
            this.bRawLast5.TabIndex = 23;
            this.bRawLast5.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawLast5, "Open the last five accounts in raw JSON.");
            this.bRawLast5.UseVisualStyleBackColor = true;
            this.bRawLast5.Click += new System.EventHandler(this.bRawLast5_Click);
            // 
            // tbLast5
            // 
            this.tbLast5.Location = new System.Drawing.Point(6, 48);
            this.tbLast5.Multiline = true;
            this.tbLast5.Name = "tbLast5";
            this.tbLast5.ReadOnly = true;
            this.tbLast5.Size = new System.Drawing.Size(191, 76);
            this.tbLast5.TabIndex = 2;
            this.tbLast5.Text = "1\r\n2\r\n3\r\n4\r\n5";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(13, 139);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(84, 13);
            this.lTotal.TabIndex = 6;
            this.lTotal.Text = "Total Accounts:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(103, 136);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(94, 22);
            this.tbTotal.TabIndex = 0;
            // 
            // bRefreshLast5
            // 
            this.bRefreshLast5.Location = new System.Drawing.Point(129, 21);
            this.bRefreshLast5.Name = "bRefreshLast5";
            this.bRefreshLast5.Size = new System.Drawing.Size(68, 23);
            this.bRefreshLast5.TabIndex = 4;
            this.bRefreshLast5.Text = "Refresh";
            this.toolTip1.SetToolTip(this.bRefreshLast5, "Refresh the last five accounts list.");
            this.bRefreshLast5.UseVisualStyleBackColor = true;
            this.bRefreshLast5.Click += new System.EventHandler(this.bRefreshLast5_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbCountry);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bOpenHash);
            this.tabPage2.Controls.Add(this.lHash);
            this.tabPage2.Controls.Add(this.tbHash);
            this.tabPage2.Controls.Add(this.bRawServer);
            this.tabPage2.Controls.Add(this.lof);
            this.tabPage2.Controls.Add(this.lPlayers);
            this.tabPage2.Controls.Add(this.lSoftware);
            this.tabPage2.Controls.Add(this.lUptime);
            this.tabPage2.Controls.Add(this.lServer);
            this.tabPage2.Controls.Add(this.txMaxPlayers);
            this.tabPage2.Controls.Add(this.tbSoftware);
            this.tabPage2.Controls.Add(this.tbUptime);
            this.tabPage2.Controls.Add(this.tbPlayers);
            this.tabPage2.Controls.Add(this.bRefreshServers);
            this.tabPage2.Controls.Add(this.cbServer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bOpenHash
            // 
            this.bOpenHash.Location = new System.Drawing.Point(533, 160);
            this.bOpenHash.Margin = new System.Windows.Forms.Padding(2);
            this.bOpenHash.Name = "bOpenHash";
            this.bOpenHash.Size = new System.Drawing.Size(47, 23);
            this.bOpenHash.TabIndex = 26;
            this.bOpenHash.Text = "Play";
            this.toolTip1.SetToolTip(this.bOpenHash, "Join the selected server in your browser.");
            this.bOpenHash.UseVisualStyleBackColor = true;
            this.bOpenHash.Click += new System.EventHandler(this.bOpenHash_Click);
            // 
            // lHash
            // 
            this.lHash.AutoSize = true;
            this.lHash.Location = new System.Drawing.Point(6, 142);
            this.lHash.Name = "lHash";
            this.lHash.Size = new System.Drawing.Size(56, 13);
            this.lHash.TabIndex = 25;
            this.lHash.Text = "Play Hash";
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(6, 161);
            this.tbHash.Name = "tbHash";
            this.tbHash.ReadOnly = true;
            this.tbHash.Size = new System.Drawing.Size(522, 22);
            this.tbHash.TabIndex = 24;
            // 
            // bRawServer
            // 
            this.bRawServer.Location = new System.Drawing.Point(9, 374);
            this.bRawServer.Margin = new System.Windows.Forms.Padding(2);
            this.bRawServer.Name = "bRawServer";
            this.bRawServer.Size = new System.Drawing.Size(47, 23);
            this.bRawServer.TabIndex = 23;
            this.bRawServer.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawServer, "Open the list of servers in raw JSON.");
            this.bRawServer.UseVisualStyleBackColor = true;
            this.bRawServer.Click += new System.EventHandler(this.bRawServer_Click);
            // 
            // lof
            // 
            this.lof.AutoSize = true;
            this.lof.Location = new System.Drawing.Point(487, 28);
            this.lof.Name = "lof";
            this.lof.Size = new System.Drawing.Size(18, 13);
            this.lof.TabIndex = 19;
            this.lof.Text = "of";
            // 
            // lPlayers
            // 
            this.lPlayers.AutoSize = true;
            this.lPlayers.Location = new System.Drawing.Point(408, 6);
            this.lPlayers.Name = "lPlayers";
            this.lPlayers.Size = new System.Drawing.Size(72, 13);
            this.lPlayers.TabIndex = 18;
            this.lPlayers.Text = "Player Count";
            // 
            // lSoftware
            // 
            this.lSoftware.AutoSize = true;
            this.lSoftware.Location = new System.Drawing.Point(6, 100);
            this.lSoftware.Name = "lSoftware";
            this.lSoftware.Size = new System.Drawing.Size(53, 13);
            this.lSoftware.TabIndex = 17;
            this.lSoftware.Text = "Software";
            // 
            // lUptime
            // 
            this.lUptime.AutoSize = true;
            this.lUptime.Location = new System.Drawing.Point(6, 58);
            this.lUptime.Name = "lUptime";
            this.lUptime.Size = new System.Drawing.Size(44, 13);
            this.lUptime.TabIndex = 16;
            this.lUptime.Text = "Uptime";
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(6, 6);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(38, 13);
            this.lServer.TabIndex = 15;
            this.lServer.Text = "Server";
            // 
            // txMaxPlayers
            // 
            this.txMaxPlayers.Location = new System.Drawing.Point(508, 25);
            this.txMaxPlayers.Name = "txMaxPlayers";
            this.txMaxPlayers.ReadOnly = true;
            this.txMaxPlayers.Size = new System.Drawing.Size(72, 22);
            this.txMaxPlayers.TabIndex = 13;
            // 
            // tbSoftware
            // 
            this.tbSoftware.Location = new System.Drawing.Point(6, 119);
            this.tbSoftware.Name = "tbSoftware";
            this.tbSoftware.ReadOnly = true;
            this.tbSoftware.Size = new System.Drawing.Size(574, 22);
            this.tbSoftware.TabIndex = 11;
            // 
            // tbUptime
            // 
            this.tbUptime.Location = new System.Drawing.Point(6, 77);
            this.tbUptime.Name = "tbUptime";
            this.tbUptime.ReadOnly = true;
            this.tbUptime.Size = new System.Drawing.Size(574, 22);
            this.tbUptime.TabIndex = 9;
            // 
            // tbPlayers
            // 
            this.tbPlayers.Location = new System.Drawing.Point(411, 25);
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.ReadOnly = true;
            this.tbPlayers.Size = new System.Drawing.Size(72, 22);
            this.tbPlayers.TabIndex = 5;
            this.tbPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bRefreshServers
            // 
            this.bRefreshServers.Location = new System.Drawing.Point(490, 374);
            this.bRefreshServers.Name = "bRefreshServers";
            this.bRefreshServers.Size = new System.Drawing.Size(75, 23);
            this.bRefreshServers.TabIndex = 1;
            this.bRefreshServers.Text = "Refresh";
            this.toolTip1.SetToolTip(this.bRefreshServers, "Refresh the selected server\'s statistics.");
            this.bRefreshServers.UseVisualStyleBackColor = true;
            this.bRefreshServers.Click += new System.EventHandler(this.bRefreshServers_Click);
            // 
            // cbServer
            // 
            this.cbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(6, 25);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(390, 21);
            this.cbServer.TabIndex = 0;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Country";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(9, 220);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(129, 22);
            this.tbCountry.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 452);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassiCube API";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tbLast5;
		private System.Windows.Forms.TextBox tbTotal;
		private System.Windows.Forms.TextBox tbSoftware;
		private System.Windows.Forms.TextBox tbUptime;
		private System.Windows.Forms.TextBox tbPlayers;
		private System.Windows.Forms.Button bRefreshServers;
		private System.Windows.Forms.ComboBox cbServer;
		private System.Windows.Forms.TextBox txMaxPlayers;
		private System.Windows.Forms.TextBox tbFlags;
		private System.Windows.Forms.Button bRefreshLast5;
		private System.Windows.Forms.Label lTotal;
		private System.Windows.Forms.Label lof;
		private System.Windows.Forms.Label lPlayers;
		private System.Windows.Forms.Label lSoftware;
		private System.Windows.Forms.Label lUptime;
		private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.Button bRawLast5;
        private System.Windows.Forms.Button bRawServer;
        private System.Windows.Forms.Label lHash;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Button bOpenHash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bRawPlayer;
        private System.Windows.Forms.Label lRegistered;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Button bIDLookup;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbRegistered;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button bLookup;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRefreshSkin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbAccSince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalexdel;
        private System.Windows.Forms.TextBox tbAccSinceExclDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserFor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label4;
    }
}

