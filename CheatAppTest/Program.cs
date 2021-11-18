using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// cheat client for single player game AssaultCube for fun

namespace CheatAppTest
{
    class Program
    {
        static string titleScreen = @"


_________ .__                   __ ___________              .__               
\_   ___ \|  |__   ____ _____ _/  |\_   _____/ ____    ____ |__| ____   ____  
/    \  \/|  |  \_/ __ \\__  \\   __\    __)_ /    \  / ___\|  |/    \_/ __ \ 
\     \___|   Y  \  ___/ / __ \|  | |        \   |  \/ /_/  >  |   |  \  ___/ 
 \______  /___|  /\___  >____  /__|/_______  /___|  /\___  /|__|___|  /\___  >
        \/     \/     \/     \/            \/     \//_____/         \/     \/ 
                        




";
        


        public static int Base = 0x50F4F4;
        public static int Health = 0xF8;


        static void Main(string[] args)
        {
            Console.ForegroundColor
            = ConsoleColor.Blue;
            Console.WriteLine(titleScreen);
            Console.ReadKey();

            VAMemory vam = new VAMemory("ac_client");

            
            int LocalPlayer = vam.ReadInt32((IntPtr)Base);
            string userInput = "";
            while (userInput != "yes" | userInput != "y")
            {
                Console.ForegroundColor
            = ConsoleColor.Green;
                Console.WriteLine("would you like to enable unlimited hp?");

                userInput = Console.ReadLine();



                if (userInput == "yes" | userInput == "y")
                {
                    int address = LocalPlayer + Health;


                    vam.WriteInt32((IntPtr)address, 9999);
                    break;
                    


                }
                else
                {
                    Console.WriteLine("Incorrect input");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            Console.Clear();
            Console.WriteLine("Unlimited HP Enabled");
            Console.ReadLine();
            






        }


        public static void mainTitle()
        {
          



        }






    }
}
