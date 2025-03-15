# CreateBatchFilesForPS3Games

CreateBatchFilesForPS3Games is a utility that creates batch files for launching PS3 games using the RPCS3 emulator.
With a simple, guided interface, users can quickly generate launcher files for all games in a specified directory.

## How It Works

The application walks you through the following steps:

1. **Select RPCS3 Executable:** Choose the location of the RPCS3 emulator executable (`rpcs3.exe`).
2. **Select Games Folder:** Choose the root folder that contains your PS3 game folders.
3. **Create Batch Files:** Click the "Create Batch Files" button to generate a launcher for each game.

The program generates two sets of batch files:
- One for each game folder found within the selected directory.
- One for game folders located inside the RPCS3 directory (`RPCS3\dev_hdd0\game\`).

The application automatically reads the `PARAM.SFO` file in each game folder to extract the official game title,
which is then used to name the batch file.

## Features

- **User-Friendly Interface:** Clear guidance through each step of the process.
- **Automatic Game Detection:** Identifies game folders within the specified directories.
- **Accurate Batch File Naming:** Extracts game titles from `PARAM.SFO` to name batch files appropriately.
- **Seamless Game Launching:** Batch files can be used to launch games directly, integrated into any emulator frontend, or added to Steam.
- **Detailed Logging:** Real-time logs inform you of the progress and any errors during the batch file creation process.

## Usage Examples

After generating the batch files, you can launch your games by simply double-clicking the corresponding file.
These scripts are also compatible with any emulator launcher or frontend.

### Example Batch File Command

```bat
"G:\Emulators\RPCS3\rpcs3.exe" --no-gui "G:\Emulators\RPCS3\dev_hdd0\game\NPUB30024\USRDIR\EBOOT.BIN"
```

```bat
"G:\Emulators\RPCS3\rpcs3.exe" --no-gui "J:\Sony PS3 Roms\King of Fighters XIII, The (USA) (En,Ja,Fr,De,Es,It,Zh,Ko)\PS3_GAME\USRDIR\EBOOT.BIN"
```

## Screenshots

![Application Interface](screenshot1.png)  
*The main interface of PS3BatchLauncherCreator.*

![Batch File Creation Process](screenshot2.png)  
*Log messages during the batch file creation process.*

![Successful Batch File Creation](screenshot3.png)  
*Confirmation that all batch files have been successfully created.*

## Technical Details

- **Language & Framework:** Developed in C# using WPF.
- **Target Framework:** .NET 9.0 for Windows.
- **Compatibility:** Designed for Windows and tested on Windows 11 (expected to work with Windows 7 and later).

## Support

If you like the software, please give us a star.<br>
Consider [donating](https://www.purelogiccode.com/donate) to support the project or simply to express your gratitude!

## Contributors

- **Peterson Fernandes** - [GitHub Profile](https://github.com/drpetersonfernandes)