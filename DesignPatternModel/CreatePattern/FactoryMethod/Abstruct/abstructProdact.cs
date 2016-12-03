using System.Collections.Generic;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Abstruct
{
    //並び替える機能を抽象化したクラス
    abstract class abstructProdact : IComparer<string>
    {
        public abstract int Compare(string x, string y);
    }
}
