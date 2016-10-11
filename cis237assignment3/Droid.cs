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
        }

        public Droid()
        {

        }

        public override string ToString()
        {
            return _material.PadRight(15) + _model.PadRight(10) + _color.PadRight(10);
        }

        protected decimal CalculateBaseCost()
        {
            return 1m;
        }

        public virtual void CalculateTotalCost()
        {
            CalculateBaseCost();
            _totalCost = _baseCost;
        }
    }
}
