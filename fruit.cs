using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._20
{
    abstract class Fruit
    {
        public string _name;
        public int _calories;

        abstract public bool IsThisMyFavorite();
        public override string ToString()
        {
            return base.ToString()+$" name: {_name} calories: {_calories}";
        }

    } 
}
