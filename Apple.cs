using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._20
{
    class Apple : Fruit
    {
        public string _color;
        public bool _pinkLady;
        public Apple(bool pinkLady, string color)
        {
            this._calories = 50;
            this._name = "Apple";
            this._color = color;
            this._pinkLady = pinkLady;

        }
        public override bool IsThisMyFavorite()
        {
            return false;
        }
        public override string ToString()
        {
            return base.ToString()+ $" color: {_color} pinkLady:_pinkLady ";
        }
    }
}
