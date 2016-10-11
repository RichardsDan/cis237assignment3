using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid : UtilityDroid
    {
        // Variables
        private bool _fireExtinguisher;
        private int _numberOfShips;

        const int COST_PER_SHIP = 1000;

        // Constructor
        public AstromechDroid(string material, string model, string color,
            bool toolBox, bool computerConnection, bool arm,
            bool fireExtinguisher, int numberOfShips)
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this._fireExtinguisher = fireExtinguisher;
            this._numberOfShips = numberOfShips;
        }

        // Methods
        public override string ToString()
        {
            string allOutput = base.ToString();

            if (_fireExtinguisher)
                allOutput += "|Fire Extinguisher|  ";

            allOutput += _numberOfShips.ToString() + " ships";

            return allOutput;
        }
    }
}
