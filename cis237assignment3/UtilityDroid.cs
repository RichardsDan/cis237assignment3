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
    class UtilityDroid : Droid
    {
        // Variables
        protected bool _toolBox;
        protected bool _computerConnection;
        protected bool _arm;

        // Constant price per optional feature
        protected const int OPTIONAL_FEATURE_PRICE = 70;

        // Constructor
        public UtilityDroid(string material, string model, string color, 
            bool toolBox, bool computerConnection, bool arm)
            // Call base Droid constructor
            :base(material, model, color)
        {
            this._toolBox = toolBox;
            this._computerConnection = computerConnection;
            this._arm = arm;

            this.CalculateTotalCost();
        }

        // Methods
        public override string ToString()
        {
            string allOutput = base.ToString();

            // Add optional features if they are chosen
            if (_toolBox)
                allOutput += "|ToolBox|  ";
            if (_computerConnection)
                allOutput += "|Comp Connect|  ";
            if (_arm)
                allOutput += "|Arm|  ";

            return allOutput;
        }

        // Call base total cost then add to it based on optional features
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            if (_toolBox)
                _totalCost += OPTIONAL_FEATURE_PRICE;
            if (_computerConnection)
                _totalCost += OPTIONAL_FEATURE_PRICE;
            if (_arm)
                _totalCost += OPTIONAL_FEATURE_PRICE;
        }
    }
}
