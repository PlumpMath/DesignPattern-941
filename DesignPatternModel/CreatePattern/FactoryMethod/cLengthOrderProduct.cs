using DesignPatternModel.CreatePattern.FactoryMethod.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Stantard
{
    //長さで並び替える機能
    class cLengthOrderProduct : abstructProdact
    {
        public override int Compare(string x, string y)
        {
            return x.Length - y.Length;
        }
    }
}
