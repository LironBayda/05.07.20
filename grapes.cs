using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._20
{
    class Grapes:Fruit
    {
        public string _color;
        public bool _seeds;

        public Grapes(bool seeds,string color)
        {
            this._calories = 100;
            this._name = "grapes";
            this._color = color;
            this._seeds = seeds;

        }

        public override bool IsThisMyFavorite()
        {
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + $" color: {_color} seeds:{_seeds} ";
        }
    }
}
