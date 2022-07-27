using System;
using System.Net;
using System.Threading;

namespace RobloxOofer
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Restoring Roblox Death Sound");
            Console.WriteLine("\nReplacing ouch.ogg at " + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Roblox\Versions\version-9045f70ea522489c\content\sounds\ouch.ogg");
            Thread.Sleep(2000);
            var n = new WebClient();
            try
            {
                n.DownloadFile("https://cdn.discordapp.com/attachments/893283087570595840/1001869210860929024/ouch.ogg", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Roblox\Versions\version-9045f70ea522489c\content\sounds\ouch.ogg");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Replacement Failed!\n\nAre you connected to the internet? :(");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Replacement Success!\n\nNow go enjoy that oof!");
            Console.ReadLine();
        }
    }
}
