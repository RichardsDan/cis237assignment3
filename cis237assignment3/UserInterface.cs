// Daniel Richards
// CIS 237
// 10/11/2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        /// <summary>
        /// Gets user input for navigating main menu
        /// </summary>
        /// <returns></returns>
        public int getUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine();

            // Prints error message if user enters invalid input
            while (input != "1" && input != "2" && input != "3")
            {
                Invalidinput();
                this.PrintMenu();

                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }

        // Prints list of droids
        public void PrintList(DroidCollection droids)
        {
            Console.WriteLine(droids.GetPrintString());
        }

        // Gets type of droid from user input
        public string GetDroidModel()
        {
            this.PrintGetModel();
            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Invalidinput();
                this.PrintGetModel();

                input = Console.ReadLine();
            }

            // Determines droid type based on selection
            switch (input)
            {
                case "1":
                    return "Protocol";
                case "2":
                    return "Utility";
                case "3":
                    return "Janitor";
                default:
                    return "Astromech";
            }
        }

        // Gets material of droid from user input
        public string GetDroidMaterial()
        {
            this.PrintGetMaterial();
            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Invalidinput();
                this.PrintGetMaterial();

                input = Console.ReadLine();
            }

            // Determines droid material based on selection
            switch (input)
            {
                case "1":
                    return "Steel";
                case "2":
                    return "Aluminum";
                case "3":
                    return "Titanium";
                default:
                    return "Nokinium";
            }
        }

        // Gets droid color from user input
        public string GetDroidColor()
        {
            this.PrintGetColor();
            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Invalidinput();
                this.PrintGetColor();

                input = Console.ReadLine();
            }

            // Determines Droid material based on selection
            switch (input)
            {
                case "1":
                    return "Red";
                case "2":
                    return "Blue";
                case "3":
                    return "Silver";
                default:
                    return "Gold";
            }
        }

        // Gets number of languages for protocol droids from user input
        public int GetNumberLanguages()
        {
            Console.WriteLine("Please enter the desired number of languages:");
            string input = Console.ReadLine();
            int result;

            // Checks that input is a valid number, prints error message if not
            while (!Int32.TryParse(input, out result))
            {
                Invalidinput();
                Console.WriteLine("Please enter the desired number of languages:");

                input = Console.ReadLine();
            }

            return result;
        }

        // Gets number of ships for astromech droids from user input
        public int GetNumberShips()
        {
            Console.WriteLine("Please enter the desired number of Ships:");
            string input = Console.ReadLine();
            int result;

            // Checks that user inputs valid number, prints error message if not
            while (!Int32.TryParse(input, out result))
            {
                Invalidinput();
                Console.WriteLine("Please enter the desired number of Ships:");

                input = Console.ReadLine();
            }

            return result;
        }

        // Asks user for optional ToolBox feature for utility droids
        public bool GetToolBox()
        {
            this.PrintGetToolBox();
            string input = Console.ReadLine();

            // Checks that user inputs valid number, prints error message if not
            while (input != "1" && input != "2")
            {
                Invalidinput();
                this.PrintGetToolBox();

                input = Console.ReadLine();
            }

            // Returns true or false based on user input
            if (input == "1")
                return true;
            else
                return false;
        }

        // Asks user for optional Computer Connection feature for utility droids
        public bool GetCompConnect()
        {
            this.PrintGetCompConnect();
            string input = Console.ReadLine();

            // Checks that user inputs valid number, prints error message if not
            while (input != "1" && input != "2")
            {
                Invalidinput();
                this.PrintGetCompConnect();

                input = Console.ReadLine();
            }

            // Returns true or false based on user input
            if (input == "1")
                return true;
            else
                return false;
        }

        // Asks user for optional Arm feature for utility droids
        public bool GetArm()
        {
            this.PrintGetArm();
            string input = Console.ReadLine();

            // Checks that user inputs valid number, prints error message if not
            while (input != "1" && input != "2")
            {
                Invalidinput();
                this.PrintGetArm();

                input = Console.ReadLine();
            }

            // Returns true or false based on user input
            if (input == "1")
                return true;
            else
                return false;
        }

        // Asks user for optional Trash Compactor feature for janitor droids
        public bool GetTrashCompact()
        {
            this.PrintGetTrashCompact();
            string input = Console.ReadLine();

            // Checks that user inputs valid number, prints error message if not
            while (input != "1" && input != "2")
            {
                Invalidinput();
                this.PrintGetTrashCompact();

                input = Console.ReadLine();
            }

            // Returns true or false based on user input
            if (input == "1")
                return true;
            else
                return false;
        }

        // Asks user for optional Vacuum feature for janitor droids
        public bool GetVacuum()
        {
            this.PrintGetVacuum();
            string input = Console.ReadLine();

            // Checks that user inputs valid number, prints error message if not
            while (input != "1" && input != "2")
            {
                Invalidinput();
                this.PrintGetVacuum();

                input = Console.ReadLine();
            }

            // Returns true or false based on user input
            if (input == "1")
                return true;
            else
                return false;
        }

        // Asks user for optional Fire Extinguisher feature for Astromech droids
        public bool GetFireExt()
        {
            this.PrintGetFireExt();
            string input = Console.ReadLine();

            // Checks that user inputs valid number, prints error message if not
            while (input != "1" && input != "2")
            {
                Invalidinput();
                this.PrintGetFireExt();

                input = Console.ReadLine();
            }

            // Returns true or false based on user input
            if (input == "1")
                return true;
            else
                return false;
        }

        // Print main menu of program
        private void PrintMenu()
        {
            Console.WriteLine("Please select an option...");
            Console.WriteLine("1: Add a Droid");
            Console.WriteLine("2: Print Droid list");
            Console.WriteLine("3: Exit");
            Console.WriteLine();
        }

        // Print menu for selecting Droid model
        private void PrintGetModel()
        {
            Console.WriteLine("Select a Droid model...");
            Console.WriteLine("[1] Protocol Droid ($500)");
            Console.WriteLine("[2] Utility Droid ($200)");
            Console.WriteLine("[3] Janitor Droid ($100)");
            Console.WriteLine("[4] Astromech Droid ($500)");
            Console.WriteLine();
        }

        // Print menu for selecting Droid material
        private void PrintGetMaterial()
        {
            Console.WriteLine("Select a material...");
            Console.WriteLine("[1] Steel ($75)");
            Console.WriteLine("[2] Aluminum ($90)");
            Console.WriteLine("[3] Titanium ($150)");
            Console.WriteLine("[4] Nokinium ($180)");
            Console.WriteLine();
        }

        // Print menu for selecting Droid color
        private void PrintGetColor()
        {
            Console.WriteLine("Select a color...");
            Console.WriteLine("[1] Red");
            Console.WriteLine("[2] Blue");
            Console.WriteLine("[3] Silver");
            Console.WriteLine("[4] Gold");
            Console.WriteLine();
        }

        //************************** Print Menus for Optional Features **************************
        private void PrintGetToolBox()
        {
            Console.WriteLine("Would you like to include the optional Toolbox feature?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            Console.WriteLine();
        }

        private void PrintGetCompConnect()
        {
            Console.WriteLine("Would you like to include the optional Computer Connection feature?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            Console.WriteLine();
        }

        private void PrintGetArm()
        {
            Console.WriteLine("Would you like to include the optional Arm feature?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            Console.WriteLine();
        }

        private void PrintGetTrashCompact()
        {
            Console.WriteLine("Would you like to include the optional Trash Compactor feature?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            Console.WriteLine();
        }

        private void PrintGetVacuum()
        {
            Console.WriteLine("Would you like to include the optional Vacuum feature?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            Console.WriteLine();
        }

        private void PrintGetFireExt()
        {
            Console.WriteLine("Would you like to include the optional Fire Extinguisher feature?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            Console.WriteLine();
        }
        // ************************** End Optional Feature menus **************************

        // Prints invalid input message
        private void Invalidinput()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please enter a valid entry");
            Console.WriteLine();
        }
    }
}
