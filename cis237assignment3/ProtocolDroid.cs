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
    class ProtocolDroid : Droid
    {
        // Variables
        private int _numberOfLanguages;

        // Constant price per language
        private const int COST_PER_LANGUAGE = 100;

        // Constructor
        public ProtocolDroid(string material, string model, string color, int languages)
            // Call base Droid constructor
            :base(material, model, color)
        {
            this._numberOfLanguages = languages;

            this.CalculateTotalCost();
        }

        // Add number of languages to ToString
        public override string ToString()
        {
            return base.ToString() + _numberOfLanguages.ToString() + " languages  ";
        }

        // Add to total cost based on number of languages
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            _totalCost += (_numberOfLanguages * COST_PER_LANGUAGE);
        }
    }
}
