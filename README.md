# ExampleBot
This repository contains an example C# bot to play Starcraft 2. It is a blank bot, which does nothing, which you can use as a base to build your own bot. It makes use of the [Starcraft 2 Client protocol](https://github.com/Blizzard/s2client-proto). By starting from this bot, it will be easy to upload your bot for use on the [ladder](http://sc2ai.net) To get started simply follow the instructions below.

## Getting started
### Preperations
First you will have to install some things, if you haven't already.
1. Download [Starcraft 2](https://starcraft2.com/)
2. Install [Visual studio](https://www.visualstudio.com/downloads/). In the installer, choose the .NET desktop development IDE.
3. Go [here](https://github.com/Blizzard/s2client-proto#downloads) and download the Season 3 map pack.
4. Extract the maps to 'C:\Program Files (x86)\StarCraft II\Maps\'. Make sure you have extracted the maps directly into the folder, if they aren't in exactly the right place the program will be unable to find them.

### Preparing the bot
In this section you will prepare the bot for your own use. It is imortant that you have picked a name for your bot! You will have to rename a number of files for your bot. It is important to rename these files if you intend to use your bot on the ladder, since the bot will have to have a unique filename.

1. Clone or download this repository.
2. Open ExampleBot.sln in Visual Studio.
3. Right click on the DotnetCoreRunner project and go to properties. In the Application tab set the Assembly name to the name of your bot. This will determine the name of your bot's .dll file. If you plan to upload your bot to ai-arena it is important that this matches your bot name as chosen in ai-arena exactly as ai-arena finds the dll based on the name of your bot.

### Writing your bot
To start writing your bot, let's first look at the existing files.
1. Open the Program.cs file in the ExampleBot project.
2. Set the race variable to the race you want your bot to play.
3. You can set the mapName, opponentRace and opponentDifficulty variables when testing against the built in Blizzard AI.
4. Open the Bot.cs file.
5. In the onFrame method you can program the behaviour for your bot. The observation parameter provides all the information about the current frame of the game. The gameInfo parameter will have the same value each frame. It provides static game information such as which parts of the map are buildable. The playerId parameter is the ID for your bot. You can use it to figure out which units are yours.
6. The onFrame method will return a list of actions you want your bot to perform. An action can, for instance, be a command for a unit to move somewhere, or a command for a building to start training a unit. You can simply add actions to the list and the bot will carry them out.
7. To try your bot against the Blizzard AI, you can simply run the ExampleBot project by right clicking it and selecting Debug -> Start new instance. If you haven't specified any actions for your bot to take your bot will do nothing. You will be able to order the units around yourself. It is a good idea to try this, to see if the game manages to load correctly.

### Preparing your bot for the ladder
You will need to take a number of steps to prepare your bot for the ladder.
1. Publish your bot by using the command `dotnet publish DotnetCoreRunner` from the root folder of this project.
2. All the necesary files for your bot will be created in the `ExampleBot\DotnetCoreRunner\bin\Debug\netcoreapp3.1\publish\` folder.
3. Add a ladderbots.json file. An example file can be found in the root of this project. All you have to do is fill in your bots name and race. Also note the name of the dll file specified in the ladderbots.json. This should match the name you set for your bot in step 3 of Preparing your bot.
4. You can now create a zip file from the folder created at step 1 by right clicking on the contents of the folder and selecting Send to -> Compressed (zipped) folder.
5. You can upload the zipped file to the [sc2ai ladder](http://sc2ai.net) or the [ai-arena ladder](https://aiarena.net/). You may have to create an account first.

### Playing your bot against other bots through the LadderManager
You can also run the LadderManager locally. The following instructions will allow you to do so.
1. Follow the instructions [here](https://github.com/Cryptyc/Sc2LadderServer#developer-install--compile-instructions-windows) to install the LadderManager. If you only have the .NET version of visual studio you may also need to install the C++ version. This can be done by using the installer from step 2 of the 'Preperations' section and choosing the C++ IDE.
2. Create a new folder inside the Bots folder and set the name of the new folder to the name of your bot.
3. Move the contents of the folder created in 'Preparing your bot for the ladder' to the new folder.
4. Add a game between your bot and another to the matchuplist.
