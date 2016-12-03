using DesignPatternModel.CreatePattern.FactoryMethod.Abstruct;
using DesignPatternModel.CreatePattern.FactoryMethod.Stantard.Abstruct;

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
