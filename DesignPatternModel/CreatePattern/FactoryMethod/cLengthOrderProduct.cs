using DesignPatternModel.CreatePattern.FactoryMethod.Abstruct;

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
