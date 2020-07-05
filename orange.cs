using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._20
{
    class Orange:Fruit
    {

        public string _color;
        public float _size;
        public Orange(float size)
        {
            this._calories = 90;
            this._name = "orange";
            this._color = "orange";
            this._size = size;

        }

        public override bool IsThisMyFavorite()
        {
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + $" color: {_color} size:{_size} ";
        }
    }
}

