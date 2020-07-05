using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._20
{
    class Banana:Fruit
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;

        public Banana(bool hasBlackSpots, bool isGreen, float size)
        {
            this._calories = 50;
            this._name = "Banana";
            this._hasBlackSpots = hasBlackSpots;
            this._isGreen = isGreen;
            this._size = size;


        }

        public override bool IsThisMyFavorite()
        {
            return true;
        }
        public override string ToString()
        {
            return base.ToString() + $" hasBlackSpots: {_hasBlackSpots} isGreen: {_isGreen} size {_size}";
        }
    }
}
