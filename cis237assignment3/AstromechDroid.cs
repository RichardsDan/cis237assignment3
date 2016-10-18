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
    class AstromechDroid : UtilityDroid
    {
        // Variables
        private bool _fireExtinguisher;
        private int _numberOfShips;

        // Constant price per ship
        private const int COST_PER_SHIP = 1000;

        // Constructor
        public AstromechDroid(string material, string model, string color,
            bool toolBox, bool computerConnection, bool arm,
            bool fireExtinguisher, int numberOfShips)
            // Call base UtilityDroid Constructor
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this._fireExtinguisher = fireExtinguisher;
            this._numberOfShips = numberOfShips;

            this.CalculateTotalCost();
        }

        // Methods
        public override string ToString()
        {
            string allOutput = base.ToString();

            // Checks if Droid has Fire Extinguisher feature
            if (_fireExtinguisher)
                allOutput += "|Fire Extinguisher|  ";

            // Outputs number of ships available to droid
            allOutput += _numberOfShips.ToString() + " ships  ";

            return allOutput;
        }

        // Calls base calculation then adds to total cost based on number of ships and optional features
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            this._totalCost += (COST_PER_SHIP * _numberOfShips);
            if (this._fireExtinguisher)
                _totalCost += OPTIONAL_FEATURE_PRICE;
        }
    }
}
