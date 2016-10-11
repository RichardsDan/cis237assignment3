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
        public const int OPTIONAL_FEATURE_PRICE = 70;

        // Constructor
        public UtilityDroid(string material, string model, string color, 
            bool toolBox, bool computerConnection, bool arm)
            :base(material, model, color)
        {
            this._toolBox = toolBox;
            this._computerConnection = computerConnection;
            this._arm = arm;
        }

        // Methods
        public override string ToString()
        {
            string allOutput = base.ToString();

            if (_toolBox)
                allOutput += "|ToolBox|  ";
            if (_computerConnection)
                allOutput += "|Comp Connect|  ";
            if (_arm)
                allOutput += "|Arm|  ";

            return allOutput;
        }

        public override void CalculateTotalCost()
        {
            if (_toolBox)
                _totalCost += OPTIONAL_FEATURE_PRICE;
            if (_computerConnection)
                _totalCost += OPTIONAL_FEATURE_PRICE;
            if (_arm)
                _totalCost += OPTIONAL_FEATURE_PRICE;
        }
    }
}
