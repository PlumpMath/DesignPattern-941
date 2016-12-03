using DesignPatternModel.CreatePattern.FactoryMethod.Abstruct;
using System.Collections.Generic;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Stantard.Abstruct
{
    abstract class abstructCreator
    {
        public string anOperation(List<string> list)
        {
            //並び替える機能を持った抽象クラスを取得
            abstructProdact comparator = factoryMethod();

            list.Sort(comparator);

            string ret = string.Empty;
            string spliter = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                ret += list[i] + System.Environment.NewLine;
            }

            return ret;
        }

        //並び替える機能を持った抽象クラスを取得
        protected abstract abstructProdact factoryMethod();
    }
}
