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
    class JanitorDroid : UtilityDroid
    {
        // Variables
        private bool _trashCompactor;
        private bool _vacuum;

        // Constructor
        public JanitorDroid(string material, string model, string color,
            bool toolBox, bool computerConnection, bool arm,
            bool trashCompactor, bool vacuum)
            // Call base Utility Droid constructor
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this._trashCompactor = trashCompactor;
            this._vacuum = vacuum;

            this.CalculateTotalCost();
        }

        // Methods
        public override string ToString()
        {
            string allOutput = base.ToString();

            // Add optional features if they were chosen
            if (_trashCompactor)
                allOutput += "|TrashCompact|  ";
            if (_vacuum)
                allOutput += "|Vacuum|  ";

            return allOutput;
        }

        // Call base CalculateTotalCost and then add to it based on optional features
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            if (_trashCompactor)
                _totalCost += OPTIONAL_FEATURE_PRICE;
            if (_vacuum)
                _totalCost += OPTIONAL_FEATURE_PRICE;
        }
    }
}
