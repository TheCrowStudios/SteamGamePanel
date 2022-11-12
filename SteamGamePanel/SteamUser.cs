using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePanel
{
    public class SteamUser
    {
        public static int ArgCount = 4;
        public string Username;
        public string Password;
        public string SharedSecret;
        public string SteamID;
        public string SteamInventory = "";
        public bool GameRunning = false;
        public Process GameProcess;

        [DllImport("user32.dll")] static extern bool SetWindowTextA(IntPtr hWnd, string text);

        public SteamUser(string[] _args)
        {
            Username = _args[0];
            Password = _args[1];
            SharedSecret = _args[2];
            SteamID = _args[3];
        }

        public string[] GetUserArgs()
        {
            return new string[] { Username, Password, SharedSecret, SteamID };
        }

        public void SetGameWindowTitle()
        {
            SetWindowTextA(GameProcess.MainWindowHandle, Username);
        }
    }
}
