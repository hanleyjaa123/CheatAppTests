using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace CheatAppTest
{
    class Program
    {

        public static int Base = 0x50F4F4;
        public static int Health = 0xF8;


        static void Main(string[] args)
        {

            VAMemory vam = new VAMemory("ac_client");

            int LocalPlayer = vam.ReadInt32((IntPtr)Base);
            string userInput = "";
            while (userInput != "yes" | userInput != "y")
            {
                Console.WriteLine("would you like to enable unlimited hp?");

                userInput = Console.ReadLine();



                if (userInput == "yes" | userInput == "y")
                {
                    int address = LocalPlayer + Health;


                    vam.WriteInt32((IntPtr)address, 9999);
                    


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
            






        }
    }
}
