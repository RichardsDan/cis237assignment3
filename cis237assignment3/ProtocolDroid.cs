using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class ProtocolDroid : Droid
    {
        // Variables
        private int _numberOfLanguages;

        // Constant price per language
        const int COST_PER_LANGUAGE = 100;

        // Constructor
        public ProtocolDroid(string material, string model, string color, int languages)
            :base(material, model, color)
        {
            this._numberOfLanguages = languages;
        }

        public override string ToString()
        {
            return base.ToString() + _numberOfLanguages.ToString().PadRight(5);
        }

        public override void CalculateTotalCost()
        {
            _totalCost += (_numberOfLanguages * COST_PER_LANGUAGE);
        }
    }
}
