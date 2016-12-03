using DesignPatternModel.CreatePattern.FactoryMethod.Abstruct;
using DesignPatternModel.CreatePattern.FactoryMethod.Stantard.Abstruct;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Stantard
{
    class cLengthOrderCreator : abstructCreator
    {
        //長さで並び替える機能を持ったクラスを返す
        protected override abstructProdact factoryMethod()
        {
            return new cLengthOrderProduct();
        }
    }
}
