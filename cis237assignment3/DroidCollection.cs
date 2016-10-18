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
    class DroidCollection
    {
        // Variables for holding the array of droids and marking the current point in the array
        IDroid[] droids;
        private int currentIndex;

        // Constructor
        public DroidCollection()
        {
            // Instantiates droid array with a maximum amount of 100
            droids = new Droid[100];

            currentIndex = 0;
        }

        /// <summary>
        /// Adds Protocol Droid to array
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="languages"></param>
        public void addDroid(string material, string model, string color, int languages)
        {
            droids[currentIndex++] = new ProtocolDroid(material, model, color, languages);
        }

        /// <summary>
        /// Adds Utility Droid to array
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="toolBox"></param>
        /// <param name="compConnect"></param>
        /// <param name="arm"></param>
        public void addDroid(string material, string model, string color, bool toolBox, bool compConnect, bool arm)
        {
            droids[currentIndex++] = new UtilityDroid(material, model, color, toolBox, compConnect, arm);
        }

        /// <summary>
        /// Adds Janitor Droid to array
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="toolBox"></param>
        /// <param name="compConnect"></param>
        /// <param name="arm"></param>
        /// <param name="trashCompact"></param>
        /// <param name="vacuum"></param>
        public void addDroid(string material, string model, string color, bool toolBox, bool compConnect, bool arm, bool trashCompact, bool vacuum)
        {
            droids[currentIndex++] = new JanitorDroid(material, model, color, toolBox, compConnect, arm, trashCompact, vacuum);
        }

        /// <summary>
        /// Adds Astromech Droid to array
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="toolBox"></param>
        /// <param name="compConnect"></param>
        /// <param name="arm"></param>
        /// <param name="fireExtinguisher"></param>
        /// <param name="ships"></param>
        public void addDroid(string material, string model, string color, bool toolBox, bool compConnect, bool arm, bool fireExtinguisher, int ships)
        {
            droids[currentIndex++] = new AstromechDroid(material, model, color, toolBox, compConnect, arm, fireExtinguisher, ships);
        }

        /// <summary>
        /// Takes all elements of Droid array and concatenates them into one string
        /// </summary>
        /// <returns></returns>
        public string GetPrintString()
        {
            string allOutput = "";

            foreach(Droid droid in droids)
            {
                // Only attempts to add Droid to string if there is a droid to add
                if (droid != null)
                {
                    allOutput += droid.ToString() + droid.TotalCost.ToString("C") + Environment.NewLine;
                }
            }

            return allOutput;
        }
    }
}
