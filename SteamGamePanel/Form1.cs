using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text;
using WindowsInput;
using WindowsInput.Native;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Security.Cryptography;

namespace SteamGamePanel
{
    public partial class Form1 : MaterialForm
    {
        public static string configFile = "config.json";
        public static string[,] users;
        public static string steamLauncher;
        public static string sdaLauncher;
        public static string sandboxieLauncher;
        public static string sandboxieConfigurationFile;
        public static int screenWidth;
        public static int screenHeight;
        public static int windowWidth;
        public static int windowHeight;
        public static int keyPressSleep = 50;

        [DllImport("user32.dll")] static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")] static extern bool SetWindowTextA(IntPtr hWnd);

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
                using (FileStream fs = File.Create(configFile)) { }
                using (StreamWriter sw = new StreamWriter(configFile)) sw.Write("{\n\t\"steamLauncher\": \"C:\\\\Program Files (x86)\\\\Steam\\\\steam.exe\",\n\t\"steamDesktopAuthenticator\": \"C:\\\\Users\\\\madga\\\\Downloads\\\\SDA-1.0.10\\\\Steam Desktop Authenticator.exe\",\n\t\"sandboxieLauncher\": \"C:\\\\Program Files\\\\Sandboxie-Plus\\\\Start.exe\",\n\t\"sandboxieConfigurationFile\": \"C:\\\\Windows\\\\Sandboxie.ini\",\n\t\"screenWidth\": 1920,\n\t\"screenHeight\": 1080,\n\t\"windowWidth\": 640,\n\t\"windowHeight\": 480,\n\t\"users\": [\n\t\t\"buckflacks1987,Illuminati8888!\",\n\t\t\"embodyingocean,Illuminati8888!\"\n\t]\n}");
            }

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

            string[] configuration;
            
            using (StreamReader sr = new StreamReader(configFile))
            {
                configuration = sr.ReadToEnd().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            bool usersFound = false;
            
            for (var i = 0; i < configuration.Length; i ++)
            {
                if (configuration[i].Contains("\"users\": [")) usersFound = true;

                if (usersFound && configuration[i].Contains(']'))
                {
                    if (configuration[i - 1][configuration[i - 1].Length - 1] != ',') configuration[i - 1] += $",\n\t\t\"{txtUsername.Text},{txtPassword.Text}\"";
                    else configuration[i - 1] += $"\n\t\t\"{txtUsername.Text},{txtPassword.Text}\"";
                }
            }
            
            using (StreamWriter sw = new StreamWriter(configFile))
            {
                for (var i = 0; i < configuration.Length; i++)
                {
                    sw.WriteLine(configuration[i]);
                }   
            }

            txtUsername.Text = "";
            txtPassword.Text = "";

            LoadConfig();
            UpdateSandboxie();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            int selected = mlwUsers.SelectedItems.Count;

            if (selected == 0) return;

            string[] configuration;
            string[] sandboxieConfiguration;

            using (StreamReader sr = new StreamReader(configFile))
            {
                configuration = sr.ReadToEnd().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            using (StreamReader sr = new StreamReader(sandboxieConfigurationFile))
            {
                sandboxieConfiguration = sr.ReadToEnd().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            int usersPosition = 0;

            for (var i = 0; i < selected; i++)
            {
                for (var j = usersPosition; j < configuration.Length; j++)
                {
                    if (configuration[j].Contains("\"users\": [")) usersPosition = j;

                    if (configuration[j].Contains($"\"{mlwUsers.SelectedItems[0].Text},{mlwUsers.SelectedItems[0].SubItems[1].Text}\"")) configuration[j] = "";
                }

                bool userFound = false;
                
                for (var j = 0; j < sandboxieConfiguration.Length; j++)
                {
                    if (sandboxieConfiguration[j].Contains($"[{mlwUsers.SelectedItems[0].Text}]"))
                    {
                        sandboxieConfiguration[j] = "";
                        userFound = true;
                    }

                    if (userFound && !sandboxieConfiguration[j].Contains('[')) sandboxieConfiguration[j] = "";
                    else if (userFound) break;
                }

                mlwUsers.Items.Remove(mlwUsers.SelectedItems[0]);
            }

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
            }

            LoadConfig();
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
            using (StreamReader sr = new StreamReader(configFile))
            {
                string text = sr.ReadToEnd();
                JsonDocumentOptions jsonDocumentOptions = new JsonDocumentOptions();
                jsonDocumentOptions.AllowTrailingCommas = true;
                JsonDocument jsonDocument = JsonDocument.Parse(text, jsonDocumentOptions);

                steamLauncher = jsonDocument.RootElement.GetProperty("steamLauncher").GetString();
                sdaLauncher = jsonDocument.RootElement.GetProperty("steamDesktopAuthenticator").GetString();
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
                users = new string[currentUsers.Length, 2];

                for (var i = 0; i < currentUsers.Length; i++)
                {
                    string[] currentUser = currentUsers[i].Split(',');
                    users[i, 0] = currentUser[0];
                    users[i, 1] = currentUser[1];
                }
            }

            mlwUsers.Items.Clear();
            
            for (var i = 0; i < users.GetLength(0); i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = users[i, 0];
                listViewItem.SubItems.Add(users[i, 1]);

                mlwUsers.Items.Add(listViewItem);
            }
        }

        public void UpdateSandboxie()
        {
            string configuration;

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
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            LaunchSteam("-applaunch 730 -sw -w {windowWidth} -h {windowHeight} -x {50 + i * windowWidth} -y {heightUsed + 50} +sv_upload +connect 86.14.115.126 +port 27015");
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
            LaunchSteam("");
        }

        public void LaunchSteam(string _args)
        {
            Process sandboxie = new Process();

            int widthUsed = 0;
            int heightUsed = 0;

            for (var i = 0; i < users.GetLength(0); i++)
            {
                sandboxie.StartInfo.FileName = sandboxieLauncher;
                sandboxie.StartInfo.Arguments = $"/box:{users[i, 0]} {steamLauncher} -login {users[i, 0]} {users[i, 1]} {_args}";
                widthUsed += windowWidth + 50;

                if (widthUsed + windowWidth + 50 > screenWidth)
                {
                    heightUsed += windowHeight;
                    widthUsed = 0;
                }

                sandboxie.StartInfo.UseShellExecute = true;
                sandboxie.Start();
            }
        }

        public void EnterSteamGuard()
        {
            Process sda = new Process();

            if (Process.GetProcessesByName("Steam Desktop Authenticator").Length == 0)
            {
                sda.StartInfo.FileName = sdaLauncher;
                sda.Start();
            }
            else sda = Process.GetProcessesByName("Steam Desktop Authenticator")[0];

            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.Sleep(10000);

            Process[] processes;
            processes = Process.GetProcessesByName("steam");

            int userCount = 0;

            for (var i = 0; i < processes.Length; i++)
            {
                if (processes[i].MainWindowTitle == "[#] Steam Sign In [#]")
                {
                    SetForegroundWindow(sda.MainWindowHandle);

                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                    inputSimulator.Keyboard.TextEntry($"\b{users[userCount, 0]}");
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.UP);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    SetForegroundWindow(processes[i].MainWindowHandle);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    inputSimulator.Keyboard.Sleep(keyPressSleep);

                    userCount += 1;
                }
            }
        }
    }
}