# SteamGamePanel
Panel for farming CSGO cases

## Setting up
- You need to have installed Steam and Sandboxie [https://sandboxie-plus.com/]. Steam Desktop Authenticator [https://github.com/Jessecar96/SteamDesktopAuthenticator] is recommended
- You need to run the installed programs once
- The program will atempt to find the file locations for Steam, maFiles, Sandboxie and the Sandboxie configuration file
- If one of the files or directories is not found by the program you will get a warning and you will be able to specify the file locations in the GUI and then save

## Adding users
- Below the user list view there are text boxzes for username and the password, type the steam username and password in them and press add user
- Press save to save changes
- A sandbox will be generated for the user and the user will be saved to the configuration file

## Logging in
**Make sure you have logged in to the Steam accounts before on the system**

- Steam guard codes can be set up using SDA which will also generate maFiles required for generating a login code
- When the configuration is reloaded the maFiles from the specified directory will be copied into the working directory of the program
- If a user does not have Steam guard linked the user will be able to be launched without a maFile
- If a user has Steam guard linked to the account, when logging in the program will generate a log in code and fill it in

## Running CSGO
- You need to specify an IP and port for the server you want to connect to in the IP port configuration in the GUI and save
- You are able to select the accounts you want to launch by selecting them in the list view
- Press Run Steam to launch Steam and log in to each account
- Press Run to log in to Steam and launch CSGO for each account
