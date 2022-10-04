namespace SteamGamePanel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddUser = new MaterialSkin.Controls.MaterialButton();
            this.mlwUsers = new MaterialSkin.Controls.MaterialListView();
            this.chdUsername = new System.Windows.Forms.ColumnHeader();
            this.chdPassword = new System.Windows.Forms.ColumnHeader();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRemoveUser = new MaterialSkin.Controls.MaterialButton();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSteamLauncher = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSteamDesktopAuthentiator = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSandboxieLauncher = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSandboxieConfigurationFile = new MaterialSkin.Controls.MaterialTextBox();
            this.tmrSteamGuard = new System.Windows.Forms.Timer(this.components);
            this.tmrLaunchCsgo = new System.Windows.Forms.Timer(this.components);
            this.mcbResolution = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenUsersFile = new MaterialSkin.Controls.MaterialButton();
            this.btnAddUsersFromFile = new MaterialSkin.Controls.MaterialButton();
            this.btnReloadConfig = new MaterialSkin.Controls.MaterialButton();
            this.btnKillSteam = new MaterialSkin.Controls.MaterialButton();
            this.btnKill = new MaterialSkin.Controls.MaterialButton();
            this.btnRunSteam = new MaterialSkin.Controls.MaterialButton();
            this.btnRun = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(8, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Steam launcher";
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddUser.Depth = 0;
            this.btnAddUser.HighEmphasis = true;
            this.btnAddUser.Icon = null;
            this.btnAddUser.Location = new System.Drawing.Point(528, 405);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUser.MinimumSize = new System.Drawing.Size(128, 0);
            this.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddUser.Size = new System.Drawing.Size(128, 36);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddUser.UseAccentColor = false;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // mlwUsers
            // 
            this.mlwUsers.AutoSizeTable = false;
            this.mlwUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlwUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdUsername,
            this.chdPassword});
            this.mlwUsers.Depth = 0;
            this.mlwUsers.FullRowSelect = true;
            this.mlwUsers.Location = new System.Drawing.Point(528, 67);
            this.mlwUsers.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlwUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlwUsers.MouseState = MaterialSkin.MouseState.OUT;
            this.mlwUsers.Name = "mlwUsers";
            this.mlwUsers.OwnerDraw = true;
            this.mlwUsers.Size = new System.Drawing.Size(266, 269);
            this.mlwUsers.TabIndex = 2;
            this.mlwUsers.UseCompatibleStateImageBehavior = false;
            this.mlwUsers.View = System.Windows.Forms.View.Details;
            // 
            // chdUsername
            // 
            this.chdUsername.Text = "Username";
            this.chdUsername.Width = 128;
            // 
            // chdPassword
            // 
            this.chdPassword.Text = "Password";
            this.chdPassword.Width = 128;
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(528, 346);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 50);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveUser.Depth = 0;
            this.btnRemoveUser.HighEmphasis = true;
            this.btnRemoveUser.Icon = null;
            this.btnRemoveUser.Location = new System.Drawing.Point(666, 405);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveUser.MinimumSize = new System.Drawing.Size(128, 0);
            this.btnRemoveUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveUser.Size = new System.Drawing.Size(128, 36);
            this.btnRemoveUser.TabIndex = 4;
            this.btnRemoveUser.Text = "Remove user";
            this.btnRemoveUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveUser.UseAccentColor = false;
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(666, 346);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(128, 50);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtSteamLauncher
            // 
            this.txtSteamLauncher.AnimateReadOnly = false;
            this.txtSteamLauncher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSteamLauncher.Depth = 0;
            this.txtSteamLauncher.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSteamLauncher.LeadingIcon = null;
            this.txtSteamLauncher.Location = new System.Drawing.Point(219, 86);
            this.txtSteamLauncher.MaxLength = 100;
            this.txtSteamLauncher.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSteamLauncher.Multiline = false;
            this.txtSteamLauncher.Name = "txtSteamLauncher";
            this.txtSteamLauncher.Size = new System.Drawing.Size(283, 36);
            this.txtSteamLauncher.TabIndex = 13;
            this.txtSteamLauncher.Text = "";
            this.txtSteamLauncher.TrailingIcon = null;
            this.txtSteamLauncher.UseTallSize = false;
            // 
            // txtSteamDesktopAuthentiator
            // 
            this.txtSteamDesktopAuthentiator.AnimateReadOnly = false;
            this.txtSteamDesktopAuthentiator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSteamDesktopAuthentiator.Depth = 0;
            this.txtSteamDesktopAuthentiator.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSteamDesktopAuthentiator.LeadingIcon = null;
            this.txtSteamDesktopAuthentiator.Location = new System.Drawing.Point(219, 128);
            this.txtSteamDesktopAuthentiator.MaxLength = 100;
            this.txtSteamDesktopAuthentiator.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSteamDesktopAuthentiator.Multiline = false;
            this.txtSteamDesktopAuthentiator.Name = "txtSteamDesktopAuthentiator";
            this.txtSteamDesktopAuthentiator.Size = new System.Drawing.Size(283, 36);
            this.txtSteamDesktopAuthentiator.TabIndex = 14;
            this.txtSteamDesktopAuthentiator.Text = "";
            this.txtSteamDesktopAuthentiator.TrailingIcon = null;
            this.txtSteamDesktopAuthentiator.UseTallSize = false;
            // 
            // txtSandboxieLauncher
            // 
            this.txtSandboxieLauncher.AnimateReadOnly = false;
            this.txtSandboxieLauncher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSandboxieLauncher.Depth = 0;
            this.txtSandboxieLauncher.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSandboxieLauncher.LeadingIcon = null;
            this.txtSandboxieLauncher.Location = new System.Drawing.Point(219, 170);
            this.txtSandboxieLauncher.MaxLength = 100;
            this.txtSandboxieLauncher.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSandboxieLauncher.Multiline = false;
            this.txtSandboxieLauncher.Name = "txtSandboxieLauncher";
            this.txtSandboxieLauncher.Size = new System.Drawing.Size(283, 36);
            this.txtSandboxieLauncher.TabIndex = 15;
            this.txtSandboxieLauncher.Text = "";
            this.txtSandboxieLauncher.TrailingIcon = null;
            this.txtSandboxieLauncher.UseTallSize = false;
            // 
            // txtSandboxieConfigurationFile
            // 
            this.txtSandboxieConfigurationFile.AnimateReadOnly = false;
            this.txtSandboxieConfigurationFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSandboxieConfigurationFile.Depth = 0;
            this.txtSandboxieConfigurationFile.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSandboxieConfigurationFile.LeadingIcon = null;
            this.txtSandboxieConfigurationFile.Location = new System.Drawing.Point(219, 212);
            this.txtSandboxieConfigurationFile.MaxLength = 100;
            this.txtSandboxieConfigurationFile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSandboxieConfigurationFile.Multiline = false;
            this.txtSandboxieConfigurationFile.Name = "txtSandboxieConfigurationFile";
            this.txtSandboxieConfigurationFile.Size = new System.Drawing.Size(283, 36);
            this.txtSandboxieConfigurationFile.TabIndex = 16;
            this.txtSandboxieConfigurationFile.Text = "";
            this.txtSandboxieConfigurationFile.TrailingIcon = null;
            this.txtSandboxieConfigurationFile.UseTallSize = false;
            // 
            // tmrSteamGuard
            // 
            this.tmrSteamGuard.Tick += new System.EventHandler(this.tmrSteamGuard_Tick);
            // 
            // tmrLaunchCsgo
            // 
            this.tmrLaunchCsgo.Tick += new System.EventHandler(this.tmrLaunchCsgo_Tick);
            // 
            // mcbResolution
            // 
            this.mcbResolution.AutoResize = false;
            this.mcbResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcbResolution.Depth = 0;
            this.mcbResolution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbResolution.DropDownHeight = 174;
            this.mcbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbResolution.DropDownWidth = 121;
            this.mcbResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcbResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcbResolution.FormattingEnabled = true;
            this.mcbResolution.IntegralHeight = false;
            this.mcbResolution.ItemHeight = 43;
            this.mcbResolution.Items.AddRange(new object[] {
            "1920x1080"});
            this.mcbResolution.Location = new System.Drawing.Point(219, 254);
            this.mcbResolution.MaxDropDownItems = 4;
            this.mcbResolution.MouseState = MaterialSkin.MouseState.OUT;
            this.mcbResolution.Name = "mcbResolution";
            this.mcbResolution.Size = new System.Drawing.Size(176, 49);
            this.mcbResolution.StartIndex = 0;
            this.mcbResolution.TabIndex = 17;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(8, 145);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(205, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Steam desktop authenticator";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(8, 187);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(141, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Sandboxie launcher";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(8, 229);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(201, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Sandboxie configuration file";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(8, 284);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(123, 19);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Screen resolution";
            // 
            // btnOpenUsersFile
            // 
            this.btnOpenUsersFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenUsersFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenUsersFile.Depth = 0;
            this.btnOpenUsersFile.HighEmphasis = true;
            this.btnOpenUsersFile.Icon = null;
            this.btnOpenUsersFile.Location = new System.Drawing.Point(219, 360);
            this.btnOpenUsersFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenUsersFile.MinimumSize = new System.Drawing.Size(180, 0);
            this.btnOpenUsersFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenUsersFile.Name = "btnOpenUsersFile";
            this.btnOpenUsersFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenUsersFile.Size = new System.Drawing.Size(180, 36);
            this.btnOpenUsersFile.TabIndex = 7;
            this.btnOpenUsersFile.Text = "Open users file";
            this.btnOpenUsersFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenUsersFile.UseAccentColor = false;
            this.btnOpenUsersFile.UseVisualStyleBackColor = true;
            this.btnOpenUsersFile.Click += new System.EventHandler(this.btnOpenUsersFile_Click);
            // 
            // btnAddUsersFromFile
            // 
            this.btnAddUsersFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUsersFromFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddUsersFromFile.Depth = 0;
            this.btnAddUsersFromFile.HighEmphasis = true;
            this.btnAddUsersFromFile.Icon = null;
            this.btnAddUsersFromFile.Location = new System.Drawing.Point(219, 408);
            this.btnAddUsersFromFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUsersFromFile.MinimumSize = new System.Drawing.Size(180, 0);
            this.btnAddUsersFromFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUsersFromFile.Name = "btnAddUsersFromFile";
            this.btnAddUsersFromFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddUsersFromFile.Size = new System.Drawing.Size(180, 36);
            this.btnAddUsersFromFile.TabIndex = 6;
            this.btnAddUsersFromFile.Text = "Add users from file";
            this.btnAddUsersFromFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddUsersFromFile.UseAccentColor = false;
            this.btnAddUsersFromFile.UseVisualStyleBackColor = true;
            this.btnAddUsersFromFile.Click += new System.EventHandler(this.btnAddUsersFromFile_Click);
            // 
            // btnReloadConfig
            // 
            this.btnReloadConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReloadConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReloadConfig.Depth = 0;
            this.btnReloadConfig.HighEmphasis = true;
            this.btnReloadConfig.Icon = null;
            this.btnReloadConfig.Location = new System.Drawing.Point(219, 312);
            this.btnReloadConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReloadConfig.MinimumSize = new System.Drawing.Size(180, 0);
            this.btnReloadConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReloadConfig.Name = "btnReloadConfig";
            this.btnReloadConfig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReloadConfig.Size = new System.Drawing.Size(180, 36);
            this.btnReloadConfig.TabIndex = 8;
            this.btnReloadConfig.Text = "Reload config";
            this.btnReloadConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReloadConfig.UseAccentColor = false;
            this.btnReloadConfig.UseVisualStyleBackColor = true;
            this.btnReloadConfig.Click += new System.EventHandler(this.btnReloadConfig_Click);
            // 
            // btnKillSteam
            // 
            this.btnKillSteam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKillSteam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKillSteam.Depth = 0;
            this.btnKillSteam.HighEmphasis = true;
            this.btnKillSteam.Icon = null;
            this.btnKillSteam.Location = new System.Drawing.Point(99, 408);
            this.btnKillSteam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKillSteam.MinimumSize = new System.Drawing.Size(110, 0);
            this.btnKillSteam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKillSteam.Name = "btnKillSteam";
            this.btnKillSteam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKillSteam.Size = new System.Drawing.Size(110, 36);
            this.btnKillSteam.TabIndex = 11;
            this.btnKillSteam.Text = "Kill steam";
            this.btnKillSteam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKillSteam.UseAccentColor = false;
            this.btnKillSteam.UseVisualStyleBackColor = true;
            this.btnKillSteam.Click += new System.EventHandler(this.btnKillSteam_Click);
            // 
            // btnKill
            // 
            this.btnKill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKill.Depth = 0;
            this.btnKill.HighEmphasis = true;
            this.btnKill.Icon = null;
            this.btnKill.Location = new System.Drawing.Point(7, 408);
            this.btnKill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKill.MinimumSize = new System.Drawing.Size(90, 0);
            this.btnKill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKill.Name = "btnKill";
            this.btnKill.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKill.Size = new System.Drawing.Size(90, 36);
            this.btnKill.TabIndex = 10;
            this.btnKill.Text = "Kill";
            this.btnKill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKill.UseAccentColor = false;
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnRunSteam
            // 
            this.btnRunSteam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRunSteam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRunSteam.Depth = 0;
            this.btnRunSteam.HighEmphasis = true;
            this.btnRunSteam.Icon = null;
            this.btnRunSteam.Location = new System.Drawing.Point(99, 360);
            this.btnRunSteam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRunSteam.MinimumSize = new System.Drawing.Size(110, 0);
            this.btnRunSteam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRunSteam.Name = "btnRunSteam";
            this.btnRunSteam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRunSteam.Size = new System.Drawing.Size(110, 36);
            this.btnRunSteam.TabIndex = 12;
            this.btnRunSteam.Text = "Run steam";
            this.btnRunSteam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRunSteam.UseAccentColor = false;
            this.btnRunSteam.UseVisualStyleBackColor = true;
            this.btnRunSteam.Click += new System.EventHandler(this.btnRunSteam_Click);
            // 
            // btnRun
            // 
            this.btnRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRun.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRun.Depth = 0;
            this.btnRun.HighEmphasis = true;
            this.btnRun.Icon = null;
            this.btnRun.Location = new System.Drawing.Point(7, 360);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRun.MinimumSize = new System.Drawing.Size(90, 0);
            this.btnRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRun.Name = "btnRun";
            this.btnRun.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRun.Size = new System.Drawing.Size(90, 36);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRun.UseAccentColor = false;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnRunSteam);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnKillSteam);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnReloadConfig);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnAddUsersFromFile);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnOpenUsersFile);
            this.Controls.Add(this.mcbResolution);
            this.Controls.Add(this.txtSandboxieConfigurationFile);
            this.Controls.Add(this.txtSandboxieLauncher);
            this.Controls.Add(this.txtSteamDesktopAuthentiator);
            this.Controls.Add(this.txtSteamLauncher);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.mlwUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "SteamGamePanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnAddUser;
        private MaterialSkin.Controls.MaterialListView mlwUsers;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialButton btnRemoveUser;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private ColumnHeader chdUsername;
        private ColumnHeader chdPassword;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox txtSteamLauncher;
        private MaterialSkin.Controls.MaterialTextBox txtSteamDesktopAuthentiator;
        private MaterialSkin.Controls.MaterialTextBox txtSandboxieLauncher;
        private MaterialSkin.Controls.MaterialTextBox txtSandboxieConfigurationFile;
        private System.Windows.Forms.Timer tmrSteamGuard;
        private System.Windows.Forms.Timer tmrLaunchCsgo;
        private MaterialSkin.Controls.MaterialComboBox mcbResolution;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnOpenUsersFile;
        private MaterialSkin.Controls.MaterialButton btnAddUsersFromFile;
        private MaterialSkin.Controls.MaterialButton btnReloadConfig;
        private MaterialSkin.Controls.MaterialButton btnKillSteam;
        private MaterialSkin.Controls.MaterialButton btnKill;
        private MaterialSkin.Controls.MaterialButton btnRunSteam;
        private MaterialSkin.Controls.MaterialButton btnRun;
    }
}