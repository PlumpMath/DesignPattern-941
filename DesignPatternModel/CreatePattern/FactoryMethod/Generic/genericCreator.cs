using DesignPatternModel.CreatePattern.FactoryMethod.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Generic.Abstruct
{
    class genericCreator<T>
        where T : abstructProdact,new()//abstructProdactを基底とした型を抽象化
    {
        public string anOperation(List<string> list)
        {
            //並び替える機能を持った抽象クラスを取得
            T comparator = factoryMethod();

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
        private T factoryMethod()
        {
            return new T();
        }
    }
}
