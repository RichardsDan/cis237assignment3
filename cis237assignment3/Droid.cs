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
    abstract class Droid : IDroid
    {
        // Variables
        protected string _material;
        protected string _model;
        protected string _color;
        protected decimal _baseCost;
        protected decimal _totalCost;

        // Properties
        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        // Constructors
        public Droid(string material, string model, string color)
        {
            this._material = material;
            this._model = model;
            this._color = color;

            this._totalCost = 0m;

            // Calculates total cost of Droid so far
            CalculateTotalCost();
        }

        public override string ToString()
        {
            return _material.PadRight(10) + _model.PadRight(10) + _color.PadRight(8);
        }

        /// <summary>
        /// Calculate base cost of droid based on the type of droid and the material used to make it
        /// </summary>
        /// <returns></returns>
        private decimal CalculateBaseCost()
        {
            decimal cost = 0m;

            // Determines the type of droid and adds cost accordingly
            switch(_model)
            {
                case "Protocol":
                    cost += 500m;
                    break;
                case "Utility":
                    cost += 200m;
                    break;
                case "Janitor":
                    cost += 100m;
                    break;
                default:
                    cost += 500m;
                    break;
            }

            // Determines the material of the droid and adds cost accordingly
            switch (_material)
            {
                case "Steel":
                    cost += 75m;
                    break;
                case "Aluminum":
                    cost += 90m;
                    break;
                case "Titanium":
                    cost += 150m;
                    break;
                default:
                    cost += 180m;
                    break;
            }

            return cost;
        }

        /// <summary>
        /// Calculates the total cost of a droid based on it's base cost and extra features
        /// </summary>
        public virtual void CalculateTotalCost()
        {
            _baseCost = CalculateBaseCost();
            _totalCost = _baseCost;
        }
    }
}
