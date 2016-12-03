using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Abstruct
{
    //並び替える機能を抽象化したクラス
    abstract class abstructProdact : IComparer<string>
    {
        public abstract int Compare(string x, string y);
    }
}
