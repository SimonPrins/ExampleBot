using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Launcher
{
    /* This program is used to launch the actual bot program.
     * This launcher is necesary, since the sc2ai.net ladder doesn't allow files to go with the bot exe.
     * The bot exe needs files such as dll libraries to run.
     * The actual bot with its files can be put in the /data/<botName>/ folder and launched through this program.
     */
    class Program
    {
        // The name of the bot.
        private static string botName = "<YourBot>";

        // The executable of your bot.
        private static string botExe = botName + ".exe";

        // Turn logging of information on or off.
        private static bool logging = true;

        static void Main(string[] args)
        {
            if (AppDomain.CurrentDomain.FriendlyName == "BotLauncher.exe")
                throw new Exception("The current exe name of this launcher is BotLauncher.exe. Please rename it to something else, so it doesn't conflict with other bot launchers.");

            if (botName == "<YourBot>")
                throw new Exception("The botName is still set to <YourBot>. Please change it to the name of your bot.");

            string botFile = Directory.GetCurrentDirectory() + "/data/" + botName + "/" + botExe;
            if (!File.Exists(botFile))
                throw new Exception("Could not launch bot. The file " + botFile + " does bot exists.");

            // Get the command line arguments as a single string to pass to the bot.
            string arguments = "";
            foreach (string arg in args)
                arguments += arg + " ";
            arguments = arguments.Trim();

            if (logging)
            {
                string[] lines = { "Starting " + botExe, "arguments: " + arguments };
                File.AppendAllLines(Directory.GetCurrentDirectory() + "/data/" + botName + "/Launcher.log", lines);
            }

            // Launch the bot program.
            Process process = Process.Start(botFile, arguments);

            // When this launcher is closed, also close the bot process.
            Application.ApplicationExit += (caller, ea)=>process.Close();
            
            // Wait until the bot exits.
            while (!process.HasExited)
                Thread.Sleep(10000);
        }
    }
}
