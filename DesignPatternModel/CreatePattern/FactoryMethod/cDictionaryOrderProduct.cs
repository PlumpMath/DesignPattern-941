using DesignPatternModel.CreatePattern.FactoryMethod.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Stantard
{
    //五十音順で並び替える機能
    class cDictionaryOrderProduct : abstructProdact
    {
        public override int Compare(string x, string y)
        {
            return StringComparer.CurrentCulture.Compare(x, y);
        }
    }
}
