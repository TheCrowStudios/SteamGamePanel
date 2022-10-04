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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddUser = new MaterialSkin.Controls.MaterialButton();
            this.mlwUsers = new MaterialSkin.Controls.MaterialListView();
            this.chdUsername = new System.Windows.Forms.ColumnHeader();
            this.chdPassword = new System.Windows.Forms.ColumnHeader();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRemoveUser = new MaterialSkin.Controls.MaterialButton();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddUsersFromFile = new MaterialSkin.Controls.MaterialButton();
            this.btnOpenUsersFile = new MaterialSkin.Controls.MaterialButton();
            this.btnReloadConfig = new MaterialSkin.Controls.MaterialButton();
            this.btnRun = new MaterialSkin.Controls.MaterialButton();
            this.btnKill = new MaterialSkin.Controls.MaterialButton();
            this.btnKillSteam = new MaterialSkin.Controls.MaterialButton();
            this.btnRunSteam = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(192, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "materialLabel1";
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
            this.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddUser.Size = new System.Drawing.Size(90, 36);
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
            this.btnRemoveUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveUser.Size = new System.Drawing.Size(120, 36);
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
            // btnAddUsersFromFile
            // 
            this.btnAddUsersFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUsersFromFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddUsersFromFile.Depth = 0;
            this.btnAddUsersFromFile.HighEmphasis = true;
            this.btnAddUsersFromFile.Icon = null;
            this.btnAddUsersFromFile.Location = new System.Drawing.Point(326, 405);
            this.btnAddUsersFromFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUsersFromFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUsersFromFile.Name = "btnAddUsersFromFile";
            this.btnAddUsersFromFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddUsersFromFile.Size = new System.Drawing.Size(176, 36);
            this.btnAddUsersFromFile.TabIndex = 6;
            this.btnAddUsersFromFile.Text = "Add users from file";
            this.btnAddUsersFromFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddUsersFromFile.UseAccentColor = false;
            this.btnAddUsersFromFile.UseVisualStyleBackColor = true;
            this.btnAddUsersFromFile.Click += new System.EventHandler(this.btnAddUsersFromFile_Click);
            // 
            // btnOpenUsersFile
            // 
            this.btnOpenUsersFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenUsersFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenUsersFile.Depth = 0;
            this.btnOpenUsersFile.HighEmphasis = true;
            this.btnOpenUsersFile.Icon = null;
            this.btnOpenUsersFile.Location = new System.Drawing.Point(326, 360);
            this.btnOpenUsersFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenUsersFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenUsersFile.Name = "btnOpenUsersFile";
            this.btnOpenUsersFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenUsersFile.Size = new System.Drawing.Size(141, 36);
            this.btnOpenUsersFile.TabIndex = 7;
            this.btnOpenUsersFile.Text = "Open users file";
            this.btnOpenUsersFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenUsersFile.UseAccentColor = false;
            this.btnOpenUsersFile.UseVisualStyleBackColor = true;
            this.btnOpenUsersFile.Click += new System.EventHandler(this.btnOpenUsersFile_Click);
            // 
            // btnReloadConfig
            // 
            this.btnReloadConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReloadConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReloadConfig.Depth = 0;
            this.btnReloadConfig.HighEmphasis = true;
            this.btnReloadConfig.Icon = null;
            this.btnReloadConfig.Location = new System.Drawing.Point(326, 312);
            this.btnReloadConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReloadConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReloadConfig.Name = "btnReloadConfig";
            this.btnReloadConfig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReloadConfig.Size = new System.Drawing.Size(133, 36);
            this.btnReloadConfig.TabIndex = 8;
            this.btnReloadConfig.Text = "Reload config";
            this.btnReloadConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReloadConfig.UseAccentColor = false;
            this.btnReloadConfig.UseVisualStyleBackColor = true;
            this.btnReloadConfig.Click += new System.EventHandler(this.btnReloadConfig_Click);
            // 
            // btnRun
            // 
            this.btnRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRun.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRun.Depth = 0;
            this.btnRun.HighEmphasis = true;
            this.btnRun.Icon = null;
            this.btnRun.Location = new System.Drawing.Point(31, 312);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRun.Name = "btnRun";
            this.btnRun.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRun.Size = new System.Drawing.Size(64, 36);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRun.UseAccentColor = false;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnKill
            // 
            this.btnKill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKill.Depth = 0;
            this.btnKill.HighEmphasis = true;
            this.btnKill.Icon = null;
            this.btnKill.Location = new System.Drawing.Point(31, 360);
            this.btnKill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKill.Name = "btnKill";
            this.btnKill.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKill.Size = new System.Drawing.Size(64, 36);
            this.btnKill.TabIndex = 10;
            this.btnKill.Text = "Kill";
            this.btnKill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKill.UseAccentColor = false;
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnKillSteam
            // 
            this.btnKillSteam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKillSteam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKillSteam.Depth = 0;
            this.btnKillSteam.HighEmphasis = true;
            this.btnKillSteam.Icon = null;
            this.btnKillSteam.Location = new System.Drawing.Point(103, 360);
            this.btnKillSteam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKillSteam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKillSteam.Name = "btnKillSteam";
            this.btnKillSteam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKillSteam.Size = new System.Drawing.Size(103, 36);
            this.btnKillSteam.TabIndex = 11;
            this.btnKillSteam.Text = "Kill steam";
            this.btnKillSteam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKillSteam.UseAccentColor = false;
            this.btnKillSteam.UseVisualStyleBackColor = true;
            this.btnKillSteam.Click += new System.EventHandler(this.btnKillSteam_Click);
            // 
            // btnRunSteam
            // 
            this.btnRunSteam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRunSteam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRunSteam.Depth = 0;
            this.btnRunSteam.HighEmphasis = true;
            this.btnRunSteam.Icon = null;
            this.btnRunSteam.Location = new System.Drawing.Point(103, 312);
            this.btnRunSteam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRunSteam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRunSteam.Name = "btnRunSteam";
            this.btnRunSteam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRunSteam.Size = new System.Drawing.Size(103, 36);
            this.btnRunSteam.TabIndex = 12;
            this.btnRunSteam.Text = "Run steam";
            this.btnRunSteam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRunSteam.UseAccentColor = false;
            this.btnRunSteam.UseVisualStyleBackColor = true;
            this.btnRunSteam.Click += new System.EventHandler(this.btnRunSteam_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(326, 80);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(176, 36);
            this.materialTextBox1.TabIndex = 13;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(326, 122);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(176, 36);
            this.materialTextBox2.TabIndex = 14;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.UseTallSize = false;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(326, 164);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(176, 36);
            this.materialTextBox3.TabIndex = 15;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            this.materialTextBox3.UseTallSize = false;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(326, 206);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(176, 36);
            this.materialTextBox4.TabIndex = 16;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            this.materialTextBox4.UseTallSize = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTextBox4);
            this.Controls.Add(this.materialTextBox3);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.btnRunSteam);
            this.Controls.Add(this.btnKillSteam);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnReloadConfig);
            this.Controls.Add(this.btnOpenUsersFile);
            this.Controls.Add(this.btnAddUsersFromFile);
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
        private MaterialSkin.Controls.MaterialButton btnAddUsersFromFile;
        private MaterialSkin.Controls.MaterialButton btnOpenUsersFile;
        private MaterialSkin.Controls.MaterialButton btnReloadConfig;
        private MaterialSkin.Controls.MaterialButton btnRun;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnKill;
        private MaterialSkin.Controls.MaterialButton btnKillSteam;
        private MaterialSkin.Controls.MaterialButton btnRunSteam;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
    }
}