using DesignPatternModel.CreatePattern.FactoryMethod.Abstruct;
using DesignPatternModel.CreatePattern.FactoryMethod.Stantard.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Stantard
{
    class cDictionaryOrderCreator : abstructCreator
    {
        //五十音順で並び替える機能を持ったクラスを返す
        protected override abstructProdact factoryMethod()
        {
            return new cDictionaryOrderProduct();
        }
    }
}
