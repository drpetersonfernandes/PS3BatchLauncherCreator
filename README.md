# PS3BatchLauncherCreator

This utility will create bat files for ps3 games to easy launch then on RPCS3 emulator.

The utility ask the user for the folder were you store all your ps3 game folders, then it will ask the location of the RPCS3 emulator.

It will also create bat files for every game folder inside the asked folder. Will also create bat files for the game folder inside the RPCS3 emulator folder (RPCS3\dev_hdd0\game).

The bat files will be saved inside the folder originaly asked.

The aplication will automatic read the PARAM.SFO to extract the game TITLE. That TITLE will be used to name the bat created.

To launch a game you just need to double click on the bat file.

This bat can be called directly from any Emulator Launcher or Emulator Frontend or even from Steam.

Was originaly designed by the creator of Simple Launcher emulator frontend, but can be used with any frontend or even without any frontend.

```bat
Example of bat file created from 'RPCS3\dev_hdd0\game' folder:

"G:\Emulators\RPCS3\rpcs3.exe" --no-gui "G:\Emulators\RPCS3\dev_hdd0\game\NPUB30024\USRDIR\EBOOT.BIN"
```

```bat
Example of bat file created from 'User Folder':

"G:\Emulators\RPCS3\rpcs3.exe" --no-gui "J:\Sony PS3 Roms\King of Fighters XIII, The (USA) (En,Ja,Fr,De,Es,It,Zh,Ko)\PS3_GAME\USRDIR\EBOOT.BIN"
```

## Screnshots

![Screenshot](screenshot1.png)

![Screenshot](screenshot2.png)

![Screenshot](screenshot3.png)