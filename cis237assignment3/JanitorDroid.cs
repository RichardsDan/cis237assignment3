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
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this._trashCompactor = trashCompactor;
            this._vacuum = vacuum;
        }

        // Methods
        public override string ToString()
        {
            string allOutput = base.ToString();

            if (_trashCompactor)
                allOutput += "|TrashCompact|  ";
            if (_vacuum)
                allOutput += "|Vacuum|  ";

            return allOutput;
        }

        public override void CalculateTotalCost()
        {
            if (_trashCompactor)
                _totalCost += OPTIONAL_FEATURE_PRICE;
            if (_vacuum)
                _totalCost += OPTIONAL_FEATURE_PRICE;
        }
    }
}
