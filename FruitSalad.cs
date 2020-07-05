using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._20
{
    class FruitSalad
    {
        public Fruit[] _fruits;

        public FruitSalad(Fruit[] fruits)
        {
            this._fruits = fruits;
        }
        public int GetTotalCalories()
        {
            int total=0;
            for (int i = 0; i < _fruits.Length; i++)
            {
                total += _fruits[i]._calories;
            }
            return total;
          
        }

        public bool ContainMyFavoriteFruit()
        {
            for (int i = 0; i < _fruits.Length; i++)
            {
                if (_fruits[i].IsThisMyFavorite())
                    return true;
            }
            return false;

        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < _fruits.Length; i++)
            {
                str += _fruits[i].ToString()+"\n";
            }
            return base.ToString()+"\n"+str;
        }
    }
}
