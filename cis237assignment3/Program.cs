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
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            DroidCollection droids = new DroidCollection();

            // integer for storing user input in menus
            int choice = ui.getUserInput();

            // Loops menu until user presses 3 to exit program
            while (choice != 3)
            {
                // Option for adding Droid to list
                if (choice == 1)
                {
                    // Prompts user for the type of droid, then adds droid to array using overloaded methods, with each variable prompting user for input
                    switch (ui.GetDroidModel())
                    {
                        case "Protocol":
                            droids.addDroid(ui.GetDroidMaterial(), "Protocol", ui.GetDroidColor(),
                                ui.GetNumberLanguages());
                            break;
                        case "Utility":
                            droids.addDroid(ui.GetDroidMaterial(), "Utility", ui.GetDroidColor(),
                                ui.GetToolBox(), ui.GetCompConnect(), ui.GetArm());
                            break;
                        case "Janitor":
                            droids.addDroid(ui.GetDroidMaterial(), "Janitor", ui.GetDroidColor(),
                                ui.GetToolBox(), ui.GetCompConnect(), ui.GetArm(),
                                ui.GetTrashCompact(), ui.GetVacuum());
                            break;
                        default:
                            droids.addDroid(ui.GetDroidMaterial(), "Astromech", ui.GetDroidColor(),
                                ui.GetToolBox(), ui.GetCompConnect(), ui.GetArm(),
                                ui.GetFireExt(), ui.GetNumberShips());
                            break;
                    }
                }
                // Option for printing list of droids
                if (choice == 2)
                {
                    ui.PrintList(droids);
                }

                // Gets user input again
                choice = ui.getUserInput();
            }
        }
    }
}
