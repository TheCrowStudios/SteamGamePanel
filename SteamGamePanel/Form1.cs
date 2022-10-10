using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text;
using WindowsInput;
using WindowsInput.Native;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Security.Cryptography;
using Microsoft.Win32;
using SteamAuth;

namespace SteamGamePanel
{
    public partial class Form1 : MaterialForm
    {
        public static string configFile = "config.json";
        public static string maFileDirectory = "maFiles";
        public static string[] maFiles;
        public static string[,] users;
        public static string[,] selectedUsers;
        public static string steamLauncher;
        public static string maFileDirectoryToCopy;
        public static string sandboxieLauncher;
        public static string sandboxieConfigurationFile;
        public static int screenWidth;
        public static int screenHeight;
        public static int windowWidth;
        public static int windowHeight;
        public static int keyPressSleep = 50;
        public static bool launching = false;
        public static bool saved = true;
        public static bool setup = false;

        [DllImport("user32.dll")] static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")] static extern bool SetWindowTextA(IntPtr hWnd, string text);

        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Red400, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(configFile))
            {
                if (Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam").GetValue("SteamExe").ToString() != null) steamLauncher = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam").GetValue("SteamExe").ToString().Replace("/", "\\\\");
                else steamLauncher = "";

                if (File.Exists("C:\\Program Files\\Sandboxie-Plus\\Start.exe")) sandboxieLauncher = "C:\\\\Program Files\\\\Sandboxie-Plus\\\\Start.exe";
                else sandboxieLauncher = "";

                if (File.Exists("C:\\Windows\\Sandboxie.ini")) sandboxieConfigurationFile = "C:\\\\Windows\\\\Sandboxie.ini";
                else sandboxieConfigurationFile = "";

                using (FileStream fs = File.Create(configFile)) { }
                using (StreamWriter sw = new StreamWriter(configFile)) sw.Write($"{{\n\t\"steamLauncher\": \"{steamLauncher}\",\n\t\"maFileDirectory\": \"\",\n\t\"sandboxieLauncher\": \"{sandboxieLauncher}\",\n\t\"sandboxieConfigurationFile\": \"{sandboxieConfigurationFile}\",\n\t\"screenWidth\": 1920,\n\t\"screenHeight\": 1080,\n\t\"windowWidth\": 640,\n\t\"windowHeight\": 480,\n\t\"users\": [\n\t\t\"buckflacks1987,Illuminati8888!\",\n\t\t\"embodyingocean,Illuminati8888!\"\n\t]\n}}");

                setup = true;
            }

            if (!Directory.Exists(maFileDirectory)) Directory.CreateDirectory(maFileDirectory);

            LoadConfig();
            UpdateSandboxie();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtPassword.Text)) return;

            for (var i = 0; i < mlwUsers.Items.Count; i++)
            {
                if (mlwUsers.Items[i].SubItems[0].Text == txtUsername.Text) return;
            }

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = txtUsername.Text;
            listViewItem.SubItems.Add(txtPassword.Text);
            mlwUsers.Items.Add(listViewItem);

            txtUsername.Text = "";
            txtPassword.Text = "";
            SetSaved(false);
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            int selected = mlwUsers.SelectedItems.Count;

            if (selected == 0) return;

            for (var i = 0; i < selected; i++)
            {
                mlwUsers.Items.Remove(mlwUsers.SelectedItems[0]);
            }

            SetSaved(false);
        }

        private void btnOpenUsersFile_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = configFile;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void btnAddUsersFromFile_Click(object sender, EventArgs e)
        {

        }

        private void btnReloadConfig_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        public void LoadConfig()
        {
            try
            {
                using (StreamReader sr = new StreamReader(configFile))
                {
                    string text = sr.ReadToEnd();
                    JsonDocumentOptions jsonDocumentOptions = new JsonDocumentOptions();
                    jsonDocumentOptions.AllowTrailingCommas = true;
                    JsonDocument jsonDocument = JsonDocument.Parse(text, jsonDocumentOptions);

                    steamLauncher = jsonDocument.RootElement.GetProperty("steamLauncher").GetString();
                    maFileDirectoryToCopy = jsonDocument.RootElement.GetProperty("maFileDirectory").GetString();
                    sandboxieLauncher = jsonDocument.RootElement.GetProperty("sandboxieLauncher").GetString();
                    sandboxieConfigurationFile = jsonDocument.RootElement.GetProperty("sandboxieConfigurationFile").GetString();
                    screenWidth = jsonDocument.RootElement.GetProperty("screenWidth").GetInt32();
                    screenHeight = jsonDocument.RootElement.GetProperty("screenHeight").GetInt32();
                    windowWidth = jsonDocument.RootElement.GetProperty("windowWidth").GetInt32();
                    windowHeight = jsonDocument.RootElement.GetProperty("windowHeight").GetInt32();

                    JsonElement.ArrayEnumerator enumerator = jsonDocument.RootElement.GetProperty("users").EnumerateArray();
                    string usersRead = "";

                    for (var i = 0; enumerator.MoveNext(); i++)
                    {
                        if (usersRead == "") usersRead += $"{enumerator.Current.GetString()}";
                        else usersRead += $"\n{enumerator.Current.GetString()}";
                    }

                    string[] currentUsers = usersRead.Split('\n');
                    users = new string[currentUsers.Length, 3];

                    for (var i = 0; i < currentUsers.Length; i++)
                    {
                        string[] currentUser = currentUsers[i].Split(',');

                        for (var j = 0; j < currentUser.Length; j++)
                        {
                            users[i, j] = currentUser[j];
                        }
                    }
                }

                if (Directory.Exists(maFileDirectoryToCopy))
                {
                    string[] maFilesToCopy = Directory.GetFiles(maFileDirectoryToCopy);

                    for (var i = 0; i < maFilesToCopy.Length; i++)
                    {
                        string[] maFile = maFilesToCopy[i].Split('\\');
                        File.Copy(maFilesToCopy[i], $"{maFileDirectory}\\{maFile[maFile.Length - 1]}", true);
                    }
                }
                
                maFiles = Directory.GetFiles(maFileDirectory);

                for (var i = 0; i < maFiles.Length; i++)
                {
                    if (maFiles[i].Contains(".maFile"))
                    {
                        string maFile;

                        using (StreamReader sr = new StreamReader(maFiles[i]))
                        {
                            maFile = sr.ReadToEnd();
                        }

                        JsonDocument jsonDocument = JsonDocument.Parse(maFile);
                        string username = jsonDocument.RootElement.GetProperty("account_name").GetString();

                        for (var j = 0; j < users.GetLength(0); j++)
                        {
                            if (users[j, 0] == username)
                            {
                                users[j, 2] = jsonDocument.RootElement.GetProperty("shared_secret").GetString();
                                break;
                            }
                        }
                    }
                }
            } catch(Exception e)
            {
                ShowError(e, true);
            }

            mlwUsers.Items.Clear();

            try
            {
                for (var i = 0; i < users.GetLength(0); i++)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    
                    for (var j = 0; j < mlwUsers.Columns.Count; j ++)
                    {
                        if (j == 0) listViewItem.Text = users[i, j];
                        else listViewItem.SubItems.Add(users[i, j]);
                    }

                    mlwUsers.Items.Add(listViewItem);
                }
            } catch(Exception e)
            {
                ShowError(e, true);
            }

            if (!File.Exists(steamLauncher)) MaterialMessageBox.Show("Could not find Steam launcher. Check if you have Steam installed.", "Uwaga", MessageBoxButtons.OK, false);
            if (!Directory.Exists(maFileDirectoryToCopy)) MaterialMessageBox.Show("Could not find the maFile directory. Check if you have chosen the right file location.", "Uwaga", MessageBoxButtons.OK, false);
            if (!File.Exists(sandboxieLauncher)) MaterialMessageBox.Show("Could not find Sandboxie. Check if you have chosen the right file location.", "Uwaga", MessageBoxButtons.OK, false);
            if (!File.Exists(sandboxieConfigurationFile)) MaterialMessageBox.Show("Could not find Sandboxie configuration. Run Sandboxie to create it and check if you have chosen the right file location.", "Uwaga", MessageBoxButtons.OK, false);

            txtSteamLauncher.Text = steamLauncher;
            txtMaFileDirectory.Text = maFileDirectoryToCopy;
            txtSandboxieLauncher.Text = sandboxieLauncher;
            txtSandboxieConfigurationFile.Text = sandboxieConfigurationFile;
            mcbResolution.Text = $"{screenWidth}x{screenHeight}";
            SetSaved(true);
        }

        public void UpdateSandboxie()
        {
            string configuration;

            try
            {
                using (StreamReader sr = new StreamReader(sandboxieConfigurationFile))
                {
                    configuration = sr.ReadToEnd();
                }

                using (StreamWriter sw = new StreamWriter(sandboxieConfigurationFile, true, Encoding.Unicode))
                {
                    for (var i = 0; i < users.GetLength(0); i++)
                    {
                        if (!configuration.Contains($"[{users[i, 0]}]"))
                        {
                            sw.WriteLine($"[{users[i, 0]}]\nEnabled=y\nBlockNetworkFiles=y\nRecoverFolder=%{{374DE290-123F-4565-9164-39C4925E467B}}%\nRecoverFolder=%Personal%\nRecoverFolder=%Desktop%\nBorderColor=#02f6f6,ttl\nTemplate=OpenBluetooth\nTemplate=SkipHook\nTemplate=FileCopy\nTemplate=qWave\nTemplate=BlockPorts\nTemplate=LingerPrograms\nTemplate=AutoRecoverIgnore\nConfigLevel=9\nAutoRecover=y\nUseSecurityMode=n\nUsePrivacyMode=n\nOpenPipePath=D:\\SteamLibrary\n");
                        }
                    }
                }
            } catch (Exception e)
            {
                ShowError(e, true);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            LaunchSteam(true);
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("csgo");

            for (var i = 0; i < processes.Length; i ++)
            {
                processes[i].Kill();
            }
        }

        private void btnKillSteam_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("steam");

            for (var i = 0; i < processes.Length; i++)
            {
                processes[i].Kill();
            }
        }

        private void btnRunSteam_Click(object sender, EventArgs e)
        {
            LaunchSteam(false);
        }

        public void LaunchSteam(bool _launchCsgo)
        {
            if (launching) return;

            launching = true;

            if (mlwUsers.SelectedItems.Count == 0)
            {
                selectedUsers = new string[mlwUsers.Items.Count, 3];

                for (var i = 0; i < selectedUsers.GetLength(0); i++)
                {
                    for (var j = 0; j < mlwUsers.Items[i].SubItems.Count; j++)
                    {
                        selectedUsers[i, j] = mlwUsers.Items[i].SubItems[j].Text;
                    }
                }
            } else
            {
                selectedUsers = new string[mlwUsers.SelectedItems.Count, 2];

                for (var i = 0; i < selectedUsers.GetLength(0); i++)
                {
                    for (var j = 0; j < mlwUsers.Items[i].SubItems.Count; j++)
                    {
                        selectedUsers[i, j] = mlwUsers.SelectedItems[i].SubItems[j].Text;
                    }

                }
            }
            
            Process sandboxie = new Process();

            int widthUsed = 0;
            int heightUsed = 0;

            for (var i = 0; i < selectedUsers.GetLength(0); i++)
            {
                sandboxie.StartInfo.FileName = sandboxieLauncher;
                sandboxie.StartInfo.Arguments = $"/box:{selectedUsers[i, 0]} {steamLauncher} -login {selectedUsers[i, 0]} {selectedUsers[i, 1]} ";
                if (_launchCsgo) sandboxie.StartInfo.Arguments += $"-applaunch 730 -sw -w {windowWidth} -h {windowHeight} -x {50 + i * windowWidth} -y {heightUsed + 50} +sv_upload +connect 86.14.115.126 +port 27015";
                widthUsed += windowWidth + 50;

                if (widthUsed + windowWidth + 50 > screenWidth)
                {
                    heightUsed += windowHeight;
                    widthUsed = 0;
                }

                sandboxie.StartInfo.UseShellExecute = true;
                sandboxie.Start();
            }

            EnterSteamGuard();

            if (_launchCsgo)
            {
                tmrLaunchCsgo.Interval = 10000;
                tmrLaunchCsgo.Start();
                launching = false;
                return;
            }

            launching = false;
        }

        public void EnterSteamGuard()
        {
            tmrSteamGuard.Interval = 10000;
            tmrSteamGuard.Start();
        }

        private void tmrSteamGuard_Tick(object sender, EventArgs e)
        {
            InputSimulator inputSimulator = new InputSimulator();

            Process[] processes = Process.GetProcessesByName("steam");

            int userCount = 0;

            for (var i = 0; i < processes.Length; i++)
            {
                if (processes[i].MainWindowTitle == "[#] Steam Sign In [#]" && selectedUsers[userCount, 2] != "")
                {
                    SteamGuardAccount steamGuardAccount = new SteamGuardAccount();
                    steamGuardAccount.SharedSecret = selectedUsers[userCount, 2];
                    string steamGuardCode = steamGuardAccount.GenerateSteamGuardCode();
                    SetForegroundWindow(processes[i].MainWindowHandle);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.TextEntry(steamGuardCode);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);

                    userCount += 1;
                }
            }

            tmrSteamGuard.Stop();
        }

        private void tmrLaunchCsgo_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("csgo");

            if (processes.Length != selectedUsers.GetLength(0)) return;

            for (var i = 0; i < processes.Length; i++)
            {
                SetWindowTextA(processes[i].MainWindowHandle, selectedUsers[i, 0]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] configuration;
            string[] sandboxieConfiguration;

            try
            {
                using (StreamReader sr = new StreamReader(configFile))
                {
                    configuration = sr.ReadToEnd().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                }

                using (StreamReader sr = new StreamReader(sandboxieConfigurationFile))
                {
                    sandboxieConfiguration = sr.ReadToEnd().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                }
            } catch(Exception _e)
            {
                ShowError(_e, false);
                return;
            }

            bool usersFound = false;
            int usersLocation = 0;

            for (var i = 0; i < configuration.Length; i++)
            {
                if (configuration[i].Contains("steamLauncher")) configuration[i] = $"\t\"steamLauncher\": \"{txtSteamLauncher.Text.Replace("\\", "\\\\")}\",";
                if (configuration[i].Contains("maFileDirectory")) configuration[i] = $"\t\"maFileDirectory\": \"{txtMaFileDirectory.Text.Replace("\\", "\\\\")}\",";
                if (configuration[i].Contains("sandboxieLauncher")) configuration[i] = $"\t\"sandboxieLauncher\": \"{txtSandboxieLauncher.Text.Replace("\\", "\\\\")}\",";
                if (configuration[i].Contains("sandboxieConfigurationFile")) configuration[i] = $"\t\"sandboxieConfigurationFile\": \"{txtSandboxieConfigurationFile.Text.Replace("\\", "\\\\")}\",";
                if (configuration[i].Contains("\"users\": ["))
                {
                    usersFound = true;
                    usersLocation = i + 1;
                }
            }

            try
            {
                if (usersFound)
                {
                    for (var i = usersLocation; i < configuration.Length; i++)
                    {
                        int mlwPosition = i - usersLocation;
                        string listViewUser = "";

                        if (mlwUsers.Items.Count > mlwPosition) listViewUser = CreateUserFromListView(mlwPosition);

                        if (usersFound && configuration[i].Contains(']') && mlwUsers.Items.Count > mlwPosition)
                        {
                            do
                            {
                                if (configuration[i - 1][configuration[i - 1].Length - 1] != ',') configuration[i - 1] += $",\n\t\t{listViewUser}";
                                else configuration[i - 1] += $"\n\t\t{listViewUser},";

                                mlwPosition += 1;
                            } while (mlwUsers.Items.Count > mlwPosition);

                            break;
                        }
                        else if (usersFound && mlwUsers.Items.Count > mlwPosition)
                        {
                            if (!configuration[i].Contains($"{listViewUser}"))
                            {
                                bool userFound = false;

                                for (var j = 0; j < sandboxieConfiguration.Length; j++)
                                {
                                    if (sandboxieConfiguration[j].Contains($"[{users[mlwPosition, 0]}]"))
                                    {
                                        sandboxieConfiguration[j] = "";
                                        userFound = true;
                                    }

                                    if (userFound && !sandboxieConfiguration[i].Contains('[')) sandboxieConfiguration[i] = "";
                                    else if (userFound) break;
                                }
                            }

                            configuration[i] = $"\t\t{listViewUser}";
                        }
                        else if (usersFound)
                        {
                            if (configuration[i].Contains(']')) break;

                            if (users.GetLength(0) > mlwPosition)
                            {
                                bool userFound = false;

                                for (var j = 0; j < sandboxieConfiguration.Length; j++)
                                {
                                    if (sandboxieConfiguration[j].Contains($"[{users[mlwPosition, 0]}]"))
                                    {
                                        sandboxieConfiguration[j] = "";
                                        userFound = true;
                                    }

                                    if (userFound && !sandboxieConfiguration[j].Contains('[')) sandboxieConfiguration[j] = "";
                                    else if (userFound) break;
                                }

                                configuration[i] = "";
                            }
                        }
                    }
                }
            } catch(Exception _e)
            {
                ShowError(_e, false);
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(configFile))
                {
                    for (var i = 0; i < configuration.Length; i++)
                    {
                        if (configuration[i] != "") sw.WriteLine(configuration[i]);
                    }
                }

                using (StreamWriter sw = new StreamWriter(sandboxieConfigurationFile, false, Encoding.Unicode))
                {
                    for (var i = 0; i < sandboxieConfiguration.Length - 1; i++)
                    {
                        if (sandboxieConfiguration[i] != "") sw.WriteLine(sandboxieConfiguration[i]);

                        if (sandboxieConfiguration[i + 1].Contains('[')) sw.WriteLine();
                    }

                    sw.WriteLine();
                }
            } catch(Exception _e)
            {
                ShowError(_e, false);
                return;
            }

            LoadConfig();
            UpdateSandboxie();
        }

        public void ShowError(Exception _e, bool _exit)
        {
            MaterialMessageBox.Show(_e.ToString(), "Error", MessageBoxButtons.OK, true);
            if (_exit) Environment.Exit(1);
        }

        public void SetSaved(bool _saved)
        {
            if (!_saved && saved != _saved) this.Text += " - not saved";
            else if (_saved) this.Text = this.Text.Replace(" - not saved", "");
            
            saved = _saved;
        }

        private void txtSteamLauncher_TextChanged(object sender, EventArgs e)
        {
            SetSaved(false);
        }

        private void txtSteamDesktopAuthentiator_TextChanged(object sender, EventArgs e)
        {
            SetSaved(false);
        }

        private void txtSandboxieLauncher_TextChanged(object sender, EventArgs e)
        {
            SetSaved(false);
        }

        private void txtSandboxieConfigurationFile_TextChanged(object sender, EventArgs e)
        {
            SetSaved(false);
        }

        private void mcbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSaved(false);
        }

        public string CreateUserFromListView(int _mlwPosition)
        {
            string configuration = "";

            for (var i = 0; i < mlwUsers.Items[_mlwPosition].SubItems.Count; i++)
            {
                if (i == 0) configuration += "\"";

                configuration += $"{mlwUsers.Items[_mlwPosition].SubItems[i].Text}";

                if (i == mlwUsers.Items[_mlwPosition].SubItems.Count - 1) configuration += "\",";
                else configuration += ",";
            }

            return configuration;
        }
    }
}